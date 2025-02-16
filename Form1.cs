using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StartWindow.Properties;

namespace StartWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListPS.SelectedIndex == 0)
            {
                IdePS.BackgroundImage = Resources.VS_logo;
                GoogleChromePSLbl.Location = new Point(49, 245);
                GoogleChromePS.Location = new Point(54, 88);
                plusPS1.Location = new Point(258, 135);
                IdePS.Location = new Point(355, 88);
                plusPS2.Visible = false;
                UnrealEngine.Visible = false;
            }
            else if (DropDownListPS.SelectedIndex == 1)
            {
                IdePS.BackgroundImage = Resources.VS_logo;
                GoogleChromePSLbl.Location = new Point(6, 245);
                GoogleChromePS.Location = new Point(6, 88);
                plusPS1.Location = new Point(167, 135);
                IdePS.Location = new Point(213, 88);
                plusPS2.Location = new Point(374, 135);
                UnrealEngine.Location = new Point(414, 88);
                plusPS2.Visible = true;
                UnrealEngine.Visible = true;
            }
            else if (DropDownListPS.SelectedIndex == 2)
            {
                IdePS.BackgroundImage = Resources.VSCode_logo;
                GoogleChromePSLbl.Location = new Point(49, 245);
                GoogleChromePS.Location = new Point(54, 88);
                plusPS1.Location = new Point(258, 135);
                IdePS.Location = new Point(355, 88);
                plusPS2.Visible = false;
                UnrealEngine.Visible = false;
            }
        }

        private void startupPS_Click(object sender, EventArgs e)
        {
            Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
            if (DropDownListPS.SelectedIndex == 0)
            {
                Process.Start("\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe\"");
            }
            else if (DropDownListPS.SelectedIndex == 1)
            {
                Process.Start("\"C:\\Program Files\\Epic Games\\UE_5.5\\Engine\\Binaries\\Win64\\UnrealEditor.exe\"");
                Process.Start("\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe\"");
            }
            else if (DropDownListPS.SelectedIndex == 2)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe\"");
            }
        }
    }
}
