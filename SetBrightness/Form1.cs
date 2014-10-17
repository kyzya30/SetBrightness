﻿using System;
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

namespace SetBrightness
{
    public partial class Form1 : Form
    {
        globalKeyboardHook gkh = new globalKeyboardHook();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
         {
            
             this.WindowState = FormWindowState.Minimized;
             if (this.WindowState == FormWindowState.Minimized)
             {
                 this.ShowInTaskbar = false;
                 notifyIcon1.Visible = true;
             } 

             gkh.HookedKeys.Add(Keys.F6);
             gkh.HookedKeys.Add(Keys.F5);
             gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
           }
        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
           {
            e.Handled = true;
           
            Thread tt = new Thread(BrightnessUpStep);
            tt.Start();
            
            }
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true;
                Thread tt1 = new Thread(BrightnessDownStep);
                tt1.Start();
            }
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

   
    public object GetBrightness()
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
        if (CurrentBrightnessLvl == 20)
        {
            SetBrightness(20);
        }
        if (CurrentBrightnessLvl == 25)
        {
            SetBrightness(20);
        }
        if (CurrentBrightnessLvl == 30)
        {
            SetBrightness(25);
        }
        if (CurrentBrightnessLvl == 35)
        {
            SetBrightness(30);
        }
        if (CurrentBrightnessLvl == 40)
        {
            SetBrightness(35);
        }
        if (CurrentBrightnessLvl == 45)
        {
            SetBrightness(40);
        }
        if (CurrentBrightnessLvl == 50)
        {
            SetBrightness(45);
        }
        if (CurrentBrightnessLvl == 55)
        {
            SetBrightness(50);
        }
        if (CurrentBrightnessLvl == 65)
        {
            SetBrightness(55);
        }
        if (CurrentBrightnessLvl == 80)
        {
            SetBrightness(65);
        }
        if (CurrentBrightnessLvl == 100)
        {
            SetBrightness(80);
        }
    }
    void BrightnessUpStep()
    {
        
            //UP VALUES
            object CurrentBrightnessLvl1 = 0;
            CurrentBrightnessLvl1 = GetBrightness();
            byte CurrentBrightnessLvl = (byte)CurrentBrightnessLvl1;


            if (CurrentBrightnessLvl == 20)
            {
                SetBrightness(25);
            }
            if (CurrentBrightnessLvl == 25)
            {
                SetBrightness(30);
            }
            if (CurrentBrightnessLvl == 30)
            {
                SetBrightness(35);
            }
            if (CurrentBrightnessLvl == 35)
            {
                SetBrightness(40);
            }
            if (CurrentBrightnessLvl == 40)
            {
                SetBrightness(45);
            }
            if (CurrentBrightnessLvl == 45)
            {
                SetBrightness(50);
            }
            if (CurrentBrightnessLvl == 50)
            {
                SetBrightness(55);
            }
            if (CurrentBrightnessLvl == 55)
            {
                SetBrightness(65);
            }
            if (CurrentBrightnessLvl == 65)
            {
                SetBrightness(80);
            }
            if (CurrentBrightnessLvl == 80)
            {
                SetBrightness(100);
            }
            if (CurrentBrightnessLvl == 100)
            {
                SetBrightness(100);
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

   

   

   

    

    

    

   
    

    

   
}
    
}
