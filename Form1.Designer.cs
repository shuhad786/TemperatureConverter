
namespace TemperatureConverter
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FTxtBox = new System.Windows.Forms.TextBox();
            this.CTxtBox = new System.Windows.Forms.TextBox();
            this.KTxtBox = new System.Windows.Forms.TextBox();
            this.FBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.KBtn = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.MPH_txtBox = new System.Windows.Forms.TextBox();
            this.KPH_txtBox = new System.Windows.Forms.TextBox();
            this.BTU_txtBox = new System.Windows.Forms.TextBox();
            this.KWH_txtBox = new System.Windows.Forms.TextBox();
            this.KPA_txtBox = new System.Windows.Forms.TextBox();
            this.BAR_txtBox = new System.Windows.Forms.TextBox();
            this.MPH_Btn = new System.Windows.Forms.Button();
            this.KPH_Btn = new System.Windows.Forms.Button();
            this.BTU_Btn = new System.Windows.Forms.Button();
            this.KWH_Btn = new System.Windows.Forms.Button();
            this.KPA_Btn = new System.Windows.Forms.Button();
            this.BAR_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl1.Location = new System.Drawing.Point(9, 105);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(43, 15);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Celcius";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Location = new System.Drawing.Point(9, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(71, 15);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Farhenheight";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl3.Location = new System.Drawing.Point(9, 139);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(38, 15);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Kelvin";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FTxtBox
            // 
            this.FTxtBox.Location = new System.Drawing.Point(161, 68);
            this.FTxtBox.Name = "FTxtBox";
            this.FTxtBox.Size = new System.Drawing.Size(100, 20);
            this.FTxtBox.TabIndex = 3;
            // 
            // CTxtBox
            // 
            this.CTxtBox.Location = new System.Drawing.Point(161, 102);
            this.CTxtBox.Name = "CTxtBox";
            this.CTxtBox.Size = new System.Drawing.Size(100, 20);
            this.CTxtBox.TabIndex = 4;
            // 
            // KTxtBox
            // 
            this.KTxtBox.Location = new System.Drawing.Point(161, 136);
            this.KTxtBox.Name = "KTxtBox";
            this.KTxtBox.Size = new System.Drawing.Size(100, 20);
            this.KTxtBox.TabIndex = 5;
            // 
            // FBtn
            // 
            this.FBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FBtn.Location = new System.Drawing.Point(312, 67);
            this.FBtn.Name = "FBtn";
            this.FBtn.Size = new System.Drawing.Size(75, 23);
            this.FBtn.TabIndex = 6;
            this.FBtn.Text = "Convert";
            this.FBtn.UseVisualStyleBackColor = false;
            this.FBtn.Click += new System.EventHandler(this.FBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.CBtn.Location = new System.Drawing.Point(312, 101);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(75, 23);
            this.CBtn.TabIndex = 7;
            this.CBtn.Text = "Convert";
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // KBtn
            // 
            this.KBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KBtn.Location = new System.Drawing.Point(312, 135);
            this.KBtn.Name = "KBtn";
            this.KBtn.Size = new System.Drawing.Size(75, 23);
            this.KBtn.TabIndex = 8;
            this.KBtn.Text = "Convert";
            this.KBtn.UseVisualStyleBackColor = false;
            this.KBtn.Click += new System.EventHandler(this.KBtn_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl4.Location = new System.Drawing.Point(9, 241);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 15);
            this.lbl4.TabIndex = 9;
            this.lbl4.Text = "British Thermal Unit";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl5.Location = new System.Drawing.Point(9, 173);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(75, 15);
            this.lbl5.TabIndex = 10;
            this.lbl5.Text = "Miles per hour";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl6.Location = new System.Drawing.Point(9, 207);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(99, 15);
            this.lbl6.TabIndex = 11;
            this.lbl6.Text = "Kilometers per hour";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl7.Location = new System.Drawing.Point(9, 275);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(93, 15);
            this.lbl7.TabIndex = 12;
            this.lbl7.Text = "Kilowatts per hour";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl8.Location = new System.Drawing.Point(9, 309);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(61, 15);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Kilo Pascal";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl9.Location = new System.Drawing.Point(9, 343);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(25, 15);
            this.lbl9.TabIndex = 14;
            this.lbl9.Text = "Bar";
            // 
            // MPH_txtBox
            // 
            this.MPH_txtBox.Location = new System.Drawing.Point(161, 170);
            this.MPH_txtBox.Name = "MPH_txtBox";
            this.MPH_txtBox.Size = new System.Drawing.Size(100, 20);
            this.MPH_txtBox.TabIndex = 15;
            // 
            // KPH_txtBox
            // 
            this.KPH_txtBox.Location = new System.Drawing.Point(161, 204);
            this.KPH_txtBox.Name = "KPH_txtBox";
            this.KPH_txtBox.Size = new System.Drawing.Size(100, 20);
            this.KPH_txtBox.TabIndex = 16;
            // 
            // BTU_txtBox
            // 
            this.BTU_txtBox.Location = new System.Drawing.Point(161, 238);
            this.BTU_txtBox.Name = "BTU_txtBox";
            this.BTU_txtBox.Size = new System.Drawing.Size(100, 20);
            this.BTU_txtBox.TabIndex = 17;
            // 
            // KWH_txtBox
            // 
            this.KWH_txtBox.Location = new System.Drawing.Point(161, 272);
            this.KWH_txtBox.Name = "KWH_txtBox";
            this.KWH_txtBox.Size = new System.Drawing.Size(100, 20);
            this.KWH_txtBox.TabIndex = 18;
            // 
            // KPA_txtBox
            // 
            this.KPA_txtBox.Location = new System.Drawing.Point(161, 306);
            this.KPA_txtBox.Name = "KPA_txtBox";
            this.KPA_txtBox.Size = new System.Drawing.Size(100, 20);
            this.KPA_txtBox.TabIndex = 19;
            // 
            // BAR_txtBox
            // 
            this.BAR_txtBox.Location = new System.Drawing.Point(161, 340);
            this.BAR_txtBox.Name = "BAR_txtBox";
            this.BAR_txtBox.Size = new System.Drawing.Size(100, 20);
            this.BAR_txtBox.TabIndex = 20;
            // 
            // MPH_Btn
            // 
            this.MPH_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MPH_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MPH_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MPH_Btn.Location = new System.Drawing.Point(312, 169);
            this.MPH_Btn.Name = "MPH_Btn";
            this.MPH_Btn.Size = new System.Drawing.Size(75, 23);
            this.MPH_Btn.TabIndex = 21;
            this.MPH_Btn.Text = "Convert";
            this.MPH_Btn.UseVisualStyleBackColor = false;
            this.MPH_Btn.Click += new System.EventHandler(this.MPH_Btn_Click);
            // 
            // KPH_Btn
            // 
            this.KPH_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KPH_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KPH_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KPH_Btn.Location = new System.Drawing.Point(312, 203);
            this.KPH_Btn.Name = "KPH_Btn";
            this.KPH_Btn.Size = new System.Drawing.Size(75, 23);
            this.KPH_Btn.TabIndex = 22;
            this.KPH_Btn.Text = "Convert";
            this.KPH_Btn.UseVisualStyleBackColor = false;
            this.KPH_Btn.Click += new System.EventHandler(this.KPH_Btn_Click);
            // 
            // BTU_Btn
            // 
            this.BTU_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BTU_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTU_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BTU_Btn.Location = new System.Drawing.Point(312, 237);
            this.BTU_Btn.Name = "BTU_Btn";
            this.BTU_Btn.Size = new System.Drawing.Size(75, 23);
            this.BTU_Btn.TabIndex = 23;
            this.BTU_Btn.Text = "Convert";
            this.BTU_Btn.UseVisualStyleBackColor = false;
            this.BTU_Btn.Click += new System.EventHandler(this.BTU_Btn_Click);
            // 
            // KWH_Btn
            // 
            this.KWH_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KWH_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KWH_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KWH_Btn.Location = new System.Drawing.Point(312, 271);
            this.KWH_Btn.Name = "KWH_Btn";
            this.KWH_Btn.Size = new System.Drawing.Size(75, 23);
            this.KWH_Btn.TabIndex = 24;
            this.KWH_Btn.Text = "Convert";
            this.KWH_Btn.UseVisualStyleBackColor = false;
            this.KWH_Btn.Click += new System.EventHandler(this.KWH_Btn_Click);
            // 
            // KPA_Btn
            // 
            this.KPA_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KPA_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KPA_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.KPA_Btn.Location = new System.Drawing.Point(312, 305);
            this.KPA_Btn.Name = "KPA_Btn";
            this.KPA_Btn.Size = new System.Drawing.Size(75, 23);
            this.KPA_Btn.TabIndex = 25;
            this.KPA_Btn.Text = "Convert";
            this.KPA_Btn.UseVisualStyleBackColor = false;
            this.KPA_Btn.Click += new System.EventHandler(this.KPA_Btn_Click);
            // 
            // BAR_Btn
            // 
            this.BAR_Btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BAR_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAR_Btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BAR_Btn.Location = new System.Drawing.Point(312, 339);
            this.BAR_Btn.Name = "BAR_Btn";
            this.BAR_Btn.Size = new System.Drawing.Size(75, 23);
            this.BAR_Btn.TabIndex = 26;
            this.BAR_Btn.Text = "Convert";
            this.BAR_Btn.UseVisualStyleBackColor = false;
            this.BAR_Btn.Click += new System.EventHandler(this.BAR_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(438, 417);
            this.Controls.Add(this.BAR_Btn);
            this.Controls.Add(this.KPA_Btn);
            this.Controls.Add(this.KWH_Btn);
            this.Controls.Add(this.BTU_Btn);
            this.Controls.Add(this.KPH_Btn);
            this.Controls.Add(this.MPH_Btn);
            this.Controls.Add(this.BAR_txtBox);
            this.Controls.Add(this.KPA_txtBox);
            this.Controls.Add(this.KWH_txtBox);
            this.Controls.Add(this.BTU_txtBox);
            this.Controls.Add(this.KPH_txtBox);
            this.Controls.Add(this.MPH_txtBox);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.KBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.FBtn);
            this.Controls.Add(this.KTxtBox);
            this.Controls.Add(this.CTxtBox);
            this.Controls.Add(this.FTxtBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox KTxtBox;
        private System.Windows.Forms.TextBox CTxtBox;
        private System.Windows.Forms.TextBox FTxtBox;
        private System.Windows.Forms.Button KBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button FBtn;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox BAR_txtBox;
        private System.Windows.Forms.TextBox KPA_txtBox;
        private System.Windows.Forms.TextBox KWH_txtBox;
        private System.Windows.Forms.TextBox BTU_txtBox;
        private System.Windows.Forms.TextBox KPH_txtBox;
        private System.Windows.Forms.TextBox MPH_txtBox;
        private System.Windows.Forms.Button BAR_Btn;
        private System.Windows.Forms.Button KPA_Btn;
        private System.Windows.Forms.Button KWH_Btn;
        private System.Windows.Forms.Button BTU_Btn;
        private System.Windows.Forms.Button KPH_Btn;
        private System.Windows.Forms.Button MPH_Btn;
    }
}

