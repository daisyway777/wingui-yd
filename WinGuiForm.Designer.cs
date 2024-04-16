namespace WinGui
{
    partial class WinGuiForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinGuiForm));
            this.labelLink = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonConf = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonNA = new System.Windows.Forms.RadioButton();
            this.radioButtonVN = new System.Windows.Forms.RadioButton();
            this.radioButtonAV = new System.Windows.Forms.RadioButton();
            this.buttonOpenPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLink
            // 
            resources.ApplyResources(this.labelLink, "labelLink");
            this.labelLink.Name = "labelLink";
            // 
            // labelPath
            // 
            resources.ApplyResources(this.labelPath, "labelPath");
            this.labelPath.Name = "labelPath";
            // 
            // textBoxLink
            // 
            resources.ApplyResources(this.textBoxLink, "textBoxLink");
            this.textBoxLink.Name = "textBoxLink";
            // 
            // textBoxPath
            // 
            resources.ApplyResources(this.textBoxPath, "textBoxPath");
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            // 
            // buttonSelectPath
            // 
            resources.ApplyResources(this.buttonSelectPath, "buttonSelectPath");
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStart
            // 
            resources.ApplyResources(this.buttonStart, "buttonStart");
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonConf
            // 
            resources.ApplyResources(this.buttonConf, "buttonConf");
            this.buttonConf.Name = "buttonConf";
            this.buttonConf.UseVisualStyleBackColor = true;
            this.buttonConf.Click += new System.EventHandler(this.button3_Click);
            // 
            // folderBrowserDialog1
            // 
            resources.ApplyResources(this.folderBrowserDialog1, "folderBrowserDialog1");
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.radioButtonNA);
            this.groupBox1.Controls.Add(this.radioButtonVN);
            this.groupBox1.Controls.Add(this.radioButtonAV);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radioButtonNA
            // 
            resources.ApplyResources(this.radioButtonNA, "radioButtonNA");
            this.radioButtonNA.Name = "radioButtonNA";
            this.radioButtonNA.UseVisualStyleBackColor = true;
            this.radioButtonNA.CheckedChanged += new System.EventHandler(this.mediaTypeChanged);
            // 
            // radioButtonVN
            // 
            resources.ApplyResources(this.radioButtonVN, "radioButtonVN");
            this.radioButtonVN.Name = "radioButtonVN";
            this.radioButtonVN.UseVisualStyleBackColor = true;
            this.radioButtonVN.CheckedChanged += new System.EventHandler(this.mediaTypeChanged);
            // 
            // radioButtonAV
            // 
            resources.ApplyResources(this.radioButtonAV, "radioButtonAV");
            this.radioButtonAV.Name = "radioButtonAV";
            this.radioButtonAV.UseVisualStyleBackColor = true;
            this.radioButtonAV.CheckedChanged += new System.EventHandler(this.mediaTypeChanged);
            // 
            // buttonOpenPath
            // 
            resources.ApplyResources(this.buttonOpenPath, "buttonOpenPath");
            this.buttonOpenPath.Name = "buttonOpenPath";
            this.buttonOpenPath.UseVisualStyleBackColor = true;
            this.buttonOpenPath.Click += new System.EventHandler(this.button4_Click);
            // 
            // WinGuiForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOpenPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConf);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonSelectPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinGuiForm";
            this.ShowIcon = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonConf;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonNA;
        private System.Windows.Forms.RadioButton radioButtonVN;
        private System.Windows.Forms.RadioButton radioButtonAV;
        private System.Windows.Forms.Button buttonOpenPath;
    }
}

