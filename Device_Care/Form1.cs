using HeCopUI_Framework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Care
{
    public partial class Form1 : HeCopUI_Framework.Forms.HFormFlat
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDrives();
            loadListAppStartup();
        }

        string isReady = " (Ready)";

        void loadDrives()
        {
            list_drives.Controls.Clear();
            foreach (var drive in DriveInfo.GetDrives())
            {
                HCheckBox c = new HCheckBox();
                c.Text = drive +  (drive.IsReady? isReady :"");
                c.Size = new Size(100, 30);
                c.Location = new Point(0, 0);
                list_drives.Controls.Add(c);
            }
            LB_NumberOfDisk.Text = "Drive(s): " + list_drives.Controls.Count;
        }

        private void btn_reloadlistappstartup_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                loadListAppStartup();
            }
        }

        void loadListAppStartup()
        {
            List<AppStartupInfo> list = Process_Care.ListStartupApps();

            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item.Name, item.Path, Process_Care.ConvertEnumToString(item.AppStartupType));
            }
            LB_CntStartupApps.Text=list.Count.ToString()+" startup apps.";
        }
    }
}
