namespace SetBrightness
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BrightnessUP_btn = new System.Windows.Forms.Button();
            this.BrightnessDown_btn = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Exit_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrightnessUP_btn
            // 
            this.BrightnessUP_btn.Location = new System.Drawing.Point(36, 48);
            this.BrightnessUP_btn.Name = "BrightnessUP_btn";
            this.BrightnessUP_btn.Size = new System.Drawing.Size(161, 23);
            this.BrightnessUP_btn.TabIndex = 4;
            this.BrightnessUP_btn.Text = "Brightness UP";
            this.BrightnessUP_btn.UseVisualStyleBackColor = true;
            this.BrightnessUP_btn.Click += new System.EventHandler(this.BrightnessUP_btn_Click);
            // 
            // BrightnessDown_btn
            // 
            this.BrightnessDown_btn.Location = new System.Drawing.Point(36, 88);
            this.BrightnessDown_btn.Name = "BrightnessDown_btn";
            this.BrightnessDown_btn.Size = new System.Drawing.Size(161, 23);
            this.BrightnessDown_btn.TabIndex = 5;
            this.BrightnessDown_btn.Text = "Brightness Down";
            this.BrightnessDown_btn.UseVisualStyleBackColor = true;
            this.BrightnessDown_btn.Click += new System.EventHandler(this.BrightnessDown_btn_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Screen brightness fix";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(36, 130);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(161, 23);
            this.Exit_btn.TabIndex = 6;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(246, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progaToolStripMenuItem
            // 
            this.progaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.progaToolStripMenuItem.Name = "progaToolStripMenuItem";
            this.progaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.progaToolStripMenuItem.Text = "Help";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.aboutProgramToolStripMenuItem.Text = "About program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 192);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.BrightnessDown_btn);
            this.Controls.Add(this.BrightnessUP_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Set Brightness";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrightnessUP_btn;
        private System.Windows.Forms.Button BrightnessDown_btn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem progaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}

