using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace SetBrightness
{
    public partial class SettingsForm : Form
    {
        string name = "SetBrightness";
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadValuesFromtxtFile();
        }
        void LoadValuesFromtxtFile()
        {
            string line;
            string path = Directory.GetCurrentDirectory();
            StreamReader file = File.OpenText(path+"\\config.txt");
            string lineToMask1 = null;
            string lineToMask2 = null;
            while ((line = file.ReadLine()) != null)
            {
                if (lineToMask1 == null)
                { lineToMask1 = line;}
                if (lineToMask1 != null)
                { lineToMask2 = line; }
            }
            maskedTextBox1.Text = lineToMask1;
            maskedTextBox2.Text = lineToMask2;
            file.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
       
            {
                SetAutorunValue(true);
            }
            if (checkBox1.Checked == false)
            { 
                SetAutorunValue(false);
            }

            int ValueOfMask1 = int.Parse(maskedTextBox1.Text);
            int ValueOfMask2 = int.Parse(maskedTextBox2.Text);
            if ((ValueOfMask1 < 1 || ValueOfMask1 > 12) || (ValueOfMask2 < 1 || ValueOfMask2 > 12))
            {
                MessageBox.Show("Some fields have incorrect values. Use only values from 1-12");
            }
            else
            {
                
                MakeConfigFileAndWriteVal();
            MessageBox.Show("Succesfully applied! Note: If you change the button, restart program");
            this.Close();
            }


            
                
        }
        void MakeConfigFileAndWriteVal()
        {
        //string path = Path.GetTempFileName();
            string path = Directory.GetCurrentDirectory();
            File.Delete(path + "\\config.txt");
        File.AppendAllText(path+"\\config.txt", maskedTextBox1.Text.ToString()+"\r\n"+maskedTextBox2.Text.ToString());
        //StreamWriter file = new StreamWriter(path +"TestFile.txt");


        }
        public bool SetAutorunValue(bool autorun)
        {
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun == true)
                {
                    reg.SetValue(name, ExePath);
                }
                if (autorun == false)
                {
                    reg.DeleteValue(name);
                }

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
