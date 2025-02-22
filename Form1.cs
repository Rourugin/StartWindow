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
            System.Windows.Forms.Application.Exit();
        }

        private void StartupCS_Click(object sender, EventArgs e)
        {
            Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
            Process.Start("\"C:\\Users\\maks\\AppData\\Roaming\\Telegram Desktop\\Telegram.exe\"");
            System.Windows.Forms.Application.Exit();
        }

        private void StartupVES_Click(object sender, EventArgs e)
        {
            if (IsGoogleChromeVES.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
            }
            if (IsTelegramVES.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Roaming\\Telegram Desktop\\Telegram.exe\"");
            }
            Process.Start("\"C:\\Users\\maks\\AppData\\Local\\CapCut\\Apps\\CapCut.exe\"");
            System.Windows.Forms.Application.Exit();
        }

        private void IsGoogleChromeVES_CheckedChanged(object sender, EventArgs e)
        {
            if (IsGoogleChromeVES.Checked == false)
            {
                GoogleChromeVES.Enabled = false;
            }
            else if (IsGoogleChromeVES.Checked == true)
            {
                GoogleChromeVES.Enabled = true;
            }
        }

        private void IsTelegramVES_CheckedChanged(object sender, EventArgs e)
        {
            if (IsTelegramVES.Checked == false)
            {
                TelegramVES.Enabled = false;
            }
            else if (IsTelegramVES.Checked == true)
            {
                TelegramVES.Enabled = true;
            }
        }

        private void DropDownListGS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownListGS.SelectedIndex == 0)
            {
                LauncherGS.BackgroundImage = Resources.steam_logo;
            }
            else if (DropDownListGS.SelectedIndex == 1)
            {
                LauncherGS.BackgroundImage = Resources.epic_games_logo;
            }
        }

        private void StartupGS_Click(object sender, EventArgs e)
        {
            if (IsGoogleChromeGS.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
            }
            if (DropDownListGS.SelectedIndex == 0)
            {
                Process.Start("\"C:\\Program Files (x86)\\Steam\\steam.exe\"");
            }
            else if (DropDownListGS.SelectedIndex == 1)
            {
                Process.Start("\"C:\\Program Files (x86)\\Epic Games\\Launcher\\Portal\\Binaries\\Win32\\EpicGamesLauncher.exe\"");
            }
            System.Windows.Forms.Application.Exit();
        }

        private void StartupCustomSet_Click(object sender, EventArgs e)
        {
            if (GoogleChromeCustom.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe\"");
            }
            if (TelegramCustom.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Roaming\\Telegram Desktop\\Telegram.exe\"");
            }
            if (CapCutCustom.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Local\\CapCut\\Apps\\CapCut.exe\"");
            }
            if (DiscordCustom.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\Documents\\ds\\discord.bat\"");
                Process.Start("\"C:\\Users\\maks\\AppData\\Local\\Discord\\Update.exe\"");
            }
            if (EpicGamesCustom.Checked == true)
            {
                Process.Start("\"C:\\Program Files (x86)\\Epic Games\\Launcher\\Portal\\Binaries\\Win32\\EpicGamesLauncher.exe\"");
            }
            if (GitBashCustom.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Git\\git-bash.exe\"");
            }
            if (SteamCustom.Checked == true)
            {
                Process.Start("\"C:\\Program Files (x86)\\Steam\\steam.exe\"");
            }
            if (UE5Custom.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Epic Games\\UE_5.5\\Engine\\Binaries\\Win64\\UnrealEditor.exe\"");
            }
            if (VSCodeCustom.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Local\\Programs\\Microsoft VS Code\\Code.exe\"");
            }
            if (VisualStudioCustom.Checked == true)
            {
                Process.Start("\"C:\\Program Files\\Microsoft Visual Studio\\2022\\Community\\Common7\\IDE\\devenv.exe\"");
            }
            if (YandexMusicCustom.Checked == true)
            {
                Process.Start("\"C:\\Users\\maks\\AppData\\Local\\Programs\\YandexMusic\\Яндекс Музыка.exe\"");
            }

            System.Windows.Forms.Application.Exit();
        }
    }
}