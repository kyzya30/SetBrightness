using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using Utilities;
using System.Threading;
using System.IO;

namespace SetBrightness
{
    public partial class Form1 : Form
    {
        string lineToKey1 = null;
         string lineToKey2 = null;
         byte[] LevelsOfBrightness;
        
        globalKeyboardHook gkh = new globalKeyboardHook();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
         {
             GetAllLevelsOfBrightness();
             this.WindowState = FormWindowState.Minimized;
             if (this.WindowState == FormWindowState.Minimized)
             {
                 this.ShowInTaskbar = false;
                 notifyIcon1.Visible = true;
             }
             LoadValuesFromFileAndSetKeys();

             
           }
        void LoadValuesFromFileAndSetKeys()
        {
            string line;
            string path = Directory.GetCurrentDirectory();
            StreamReader file = File.OpenText(path + "\\config.txt");
            
            while ((line = file.ReadLine()) != null)
            {
                if (lineToKey1 == null)
                { lineToKey1 = line; }
                if (lineToKey1 != null)
                { lineToKey2 = line; }
            }
            //maskedTextBox1.Text = lineToMask1;
           // maskedTextBox2.Text = lineToMask2;
            file.Close();
            if (lineToKey1 == "1") {gkh.HookedKeys.Add(Keys.F1);}
            if (lineToKey1 == "2") {gkh.HookedKeys.Add(Keys.F2);}
            if (lineToKey1 == "3") {gkh.HookedKeys.Add(Keys.F3);}
            if (lineToKey1 == "4") { gkh.HookedKeys.Add(Keys.F4); }
            if (lineToKey1 == "5") { gkh.HookedKeys.Add(Keys.F5); }
            if (lineToKey1 == "6") { gkh.HookedKeys.Add(Keys.F6); }
            if (lineToKey1 == "7") { gkh.HookedKeys.Add(Keys.F7); }
            if (lineToKey1 == "8") { gkh.HookedKeys.Add(Keys.F8); }
            if (lineToKey1 == "9") { gkh.HookedKeys.Add(Keys.F9); }
            if (lineToKey1 == "10") { gkh.HookedKeys.Add(Keys.F10); }
            if (lineToKey1 == "11") { gkh.HookedKeys.Add(Keys.F11); }
            if (lineToKey1 == "12") { gkh.HookedKeys.Add(Keys.F12); }
            ///////////
            if (lineToKey2 == "1") { gkh.HookedKeys.Add(Keys.F1); }
            if (lineToKey2 == "2") { gkh.HookedKeys.Add(Keys.F2); }
            if (lineToKey2 == "3") { gkh.HookedKeys.Add(Keys.F3); }
            if (lineToKey2 == "4") { gkh.HookedKeys.Add(Keys.F4); }
            if (lineToKey2 == "5") { gkh.HookedKeys.Add(Keys.F5); }
            if (lineToKey2 == "6") { gkh.HookedKeys.Add(Keys.F6); }
            if (lineToKey2 == "7") { gkh.HookedKeys.Add(Keys.F7); }
            if (lineToKey2 == "8") { gkh.HookedKeys.Add(Keys.F8); }
            if (lineToKey2 == "9") { gkh.HookedKeys.Add(Keys.F9); }
            if (lineToKey2 == "10") { gkh.HookedKeys.Add(Keys.F10); }
            if (lineToKey2 == "11") { gkh.HookedKeys.Add(Keys.F11); }
            if (lineToKey2 == "12") { gkh.HookedKeys.Add(Keys.F12); }
                // gkh.HookedKeys.Add(Keys.F5);
                // gkh.HookedKeys.Add(Keys.F6);
                
                gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && lineToKey2 == "1") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F2 && lineToKey2 == "2") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F3 && lineToKey2 == "3") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F4 && lineToKey2 == "4") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F5 && lineToKey2 == "5") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F6 && lineToKey2 == "6") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F7 && lineToKey2 == "7") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F8 && lineToKey2 == "8") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F9 && lineToKey2 == "9") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F10 && lineToKey2 == "10") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F11 && lineToKey2 == "11") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
            if (e.KeyCode == Keys.F12 && lineToKey2 == "12") { e.Handled = true; Thread tt = new Thread(BrightnessUpStep); tt.Start(); }
              ////////// 
            if (e.KeyCode == Keys.F1 && lineToKey1 == "1") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F2 && lineToKey1 == "2") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F3 && lineToKey1 == "3") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F4 && lineToKey1 == "4") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F5 && lineToKey1 == "5") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F6 && lineToKey1 == "6") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F7 && lineToKey1 == "7") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F8 && lineToKey1 == "8") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F9 && lineToKey1 == "9") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F10 && lineToKey1 == "10") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F11 && lineToKey1 == "11") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
            if (e.KeyCode == Keys.F12 && lineToKey1 == "12") { e.Handled = true; Thread tt = new Thread(BrightnessDownStep); tt.Start(); }
        }
       

       
        
//...
    public static void SetBrightness(byte targetBrightness) {
       
    ManagementScope scope = new ManagementScope("root\\WMI");
    SelectQuery query = new SelectQuery("WmiMonitorBrightnessMethods");
    using(ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query)) {
        using(ManagementObjectCollection objectCollection = searcher.Get()) {
            foreach(ManagementObject mObj in objectCollection) {
                mObj.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, targetBrightness });
             
                break;
            }
        }
    }
}

    void GetAllLevelsOfBrightness()
    {
        ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher("root\\WMI",
                        "SELECT * FROM WmiMonitorBrightness");
        foreach (ManagementObject queryObj in searcher.Get())
        {

                LevelsOfBrightness = (Byte[])(queryObj["Level"]);
                //foreach (Byte arrValue in LevelsOfBrightness)
                //{
                //    Console.WriteLine("Level: {0} {1}", arrValue);
                //}     
        }
    }
    object GetBrightness()
    {
       object BrightnessLevel =0;
        ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\WMI","SELECT * FROM WmiMonitorBrightness");
                    

        foreach (ManagementObject queryObj in searcher.Get())
        {
           
           // Console.WriteLine("CurrentBrightness: {0}", queryObj["CurrentBrightness"]);
            BrightnessLevel = queryObj["CurrentBrightness"];
           // MessageBox.Show(queryObj["CurrentBrightness"].ToString());
        }
        return BrightnessLevel;
    }

   
    private void BrightnessUP_btn_Click(object sender, EventArgs e)
    {
        
        BrightnessUpStep();
    }

    private void BrightnessDown_btn_Click(object sender, EventArgs e)
    {
        BrightnessDownStep();
    }
    void BrightnessDownStep()
    {
        //DOWN VALUES
        object CurrentBrightnessLvl1 = 0;
        CurrentBrightnessLvl1 = GetBrightness();
        byte CurrentBrightnessLvl = (byte)CurrentBrightnessLvl1;
        for (int i = 0; i <= LevelsOfBrightness.Length - 1; i++)
        {
            if (CurrentBrightnessLvl == LevelsOfBrightness[i])
            {
                if (LevelsOfBrightness[i] == LevelsOfBrightness[0])// If min value do nothing
                { }
                else
                {
                    SetBrightness(LevelsOfBrightness[i - 1]);
                }
            }
        }
    }
    void BrightnessUpStep()
    {
        
            //UP VALUES
            object CurrentBrightnessLvl1 = 0;
            CurrentBrightnessLvl1 = GetBrightness();
            byte CurrentBrightnessLvl = (byte)CurrentBrightnessLvl1;
            for (int i = 0; i <= LevelsOfBrightness.Length-1; i++)
            {
                if (CurrentBrightnessLvl == LevelsOfBrightness[i] )
                {
                    if (LevelsOfBrightness[i] == LevelsOfBrightness[LevelsOfBrightness.Length-1])// If max value do nothing
                    { }
                    else
                    {
                        SetBrightness(LevelsOfBrightness[i + 1]);
                    }
                }
            }
            

    } 
    
    private void Form1_Resize(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Minimized)
        {

            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }
    }
    private void notifyIcon1_Click(object sender, EventArgs e)
    {
        if (this.WindowState == FormWindowState.Minimized)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        } 
    }
    private void Exit_btn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
    {
        About_Form ab = new About_Form();
        ab.Show();
    }

    private void Settings_Click(object sender, EventArgs e)
    {
        SettingsForm SF = new SettingsForm();
        SF.Show();
    }

   

   

   

    

    

    

   
    

    

   
}
    
}

