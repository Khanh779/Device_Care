using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static HeCopUI_Framework.GetAppResources;

namespace Device_Care.CustomControls
{

    public class ProgressRing : Control
    {
        private const float START_ANGLE = -90F;
        private const ulong TOTAL_DURATION = 2000; // Tổng thời gian của một chu kỳ
        private const ulong HALF_DURATION = TOTAL_DURATION / 2; // Nửa chu kỳ

        private readonly Color _color;
        private readonly System.Windows.Forms.Timer _timer;

        private RectangleF _arcBounds;

        private bool _isIndeterminate;
        private float _maxValue;
        private float _value;
        private float _ellipseWidth;

        private float _startAngle;
        private float _sweepAngle;

        // Thời gian bắt đầu của Timer
        private DateTime _startTime;

        [Category("Appearance")]
        [Description("Set the width of ellipse.")]
        public float EllipseWidth
        {
            get => _ellipseWidth;
            set
            {
                _ellipseWidth = value;
                _arcBounds = CreateArcBounds(_ellipseWidth, ClientSize);

                Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Indicates whether progress represents a known amount of work.")]
        public bool IsIndeterminate
        {
            get => _isIndeterminate;
            set
            {
                _isIndeterminate = value;
                if (_isIndeterminate && !DesignMode)
                {
                    _startAngle = -90f;
                    _sweepAngle = 0f;
                    _timer.Start();
                }
                else
                {
                    _startAngle = -90f;
                    _sweepAngle = ValueToAngle(_value, _maxValue);
                    _timer.Stop();
                }

                Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Set the progress max value.")]
        public float MaxValue
        {
            get => _maxValue;
            set
            {
                _maxValue = value;
                _sweepAngle = ValueToAngle(_value, _maxValue);
                Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Set the progress value.")]
        public float Value
        {
            get => _value;
            set
            {
                _value = Math.Max(Math.Min(value, _maxValue), 0);
                _sweepAngle = ValueToAngle(_value, _maxValue);
                Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Set the timer interval.")]
        public int Interval
        {
            get => _timer.Interval;
            set => _timer.Interval = value;
        }


        public ProgressRing()
        {
            SetStyle(
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );

            _value = 0;
            _maxValue = 100;
            _ellipseWidth = 8;

            _startAngle = START_ANGLE;
            _sweepAngle = 90f;

            _color = Color.FromArgb(0, 120, 215); // Accent Color
            _arcBounds = CreateArcBounds(_ellipseWidth, ClientSize);

            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 10; // Khoảng thời gian giữa các lần tick
            _timer.Tick += TimerTick; // Định nghĩa sự kiện Tick
        }

     
        private void TimerTick(object sender, EventArgs e)
        {
            // Thời gian đã trôi qua kể từ khi Timer bắt đầu
            var milliSinceBeginning = (ulong)(DateTime.Now - _startTime).TotalMilliseconds;

            TimerElapse(milliSinceBeginning); // Gọi hàm với thời gian thực tế
        }

        private void TimerElapse(ulong milliSinceBeginning)
        {
            if (milliSinceBeginning < TOTAL_DURATION)
            {
                var sweepTime = milliSinceBeginning <= HALF_DURATION ? milliSinceBeginning : TOTAL_DURATION - milliSinceBeginning;

                _startAngle = -90f + (milliSinceBeginning * 360f) / TOTAL_DURATION;
                _sweepAngle = (sweepTime * 180f) / HALF_DURATION;

                Invalidate(); // Yêu cầu vẽ lại
            }
            else
            {
                _timer.Stop(); // Dừng Timer sau khi hoàn thành chu kỳ
                _timer.Start(); // Khởi động lại Timer
                _startTime = DateTime.Now; // Đặt lại thời gian bắt đầu
            }
        }

        public void StartTimer()
        {
            _startTime = DateTime.Now; // Đặt thời gian bắt đầu
            _timer.Start(); // Bắt đầu Timer
        }

        public void StopTimer()
        {
            _timer.Stop(); // Dừng Timer
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            lock(this)
            {
              
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                // Draw center
                _arcBounds = new RectangleF(Width/2 - _arcBounds.Width/2, Height/2 -_arcBounds.Height/2, _arcBounds.Width , _arcBounds.Height);

                if (DesignMode)
                {
                    var guidePen = new Pen(Color.FromKnownColor(KnownColor.ControlLight), _ellipseWidth);
                    e.Graphics.DrawEllipse(guidePen, _arcBounds);
                }

                var pen = new Pen(_color, _ellipseWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                e.Graphics.DrawArc(pen, _arcBounds, _startAngle, _sweepAngle);

             
            }    
        }

        const int WM_CREATE = 0x0001;
        const int WM_DESTROY = 0x0002;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_CREATE:
                    if (_isIndeterminate)
                    {
                        _startAngle = -90f;
                        _sweepAngle = 0f;
                        _timer.Start();
                    }
                    break;
                case WM_DESTROY:
                    if (_isIndeterminate)
                    {
                    }
                    break;
            }

            base.WndProc(ref m);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            _arcBounds = CreateArcBounds(_ellipseWidth, ClientSize);
            Invalidate();
            base.OnSizeChanged(e);
        }

        private static RectangleF CreateArcBounds(float arcWidth, Size clientSize)
        {
            var offset = arcWidth / 2;
            var point = new PointF(offset, offset);
            int min = Math.Min(clientSize.Width, clientSize.Height);
            clientSize = new Size(min, min);
            var size = AddSizeF(clientSize, -arcWidth);

            return new RectangleF(point, size);
        }


        private static float ValueToAngle(float value, float max)
        {
            var percentage = (value * max) / 100;
            return (percentage / 100) * 360;
        }

        private static SizeF AddSizeF(SizeF s, float v)
        {
            s.Width += v;
            s.Height += v;

            return s;
        }


    }

}