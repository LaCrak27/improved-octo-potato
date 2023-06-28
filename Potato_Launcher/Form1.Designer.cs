namespace Potato_Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.mainPanel_progressBar = new System.Windows.Forms.ProgressBar();
            this.mainPanel_mainButton = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.progress_label = new System.Windows.Forms.Label();
            this.warning_label = new System.Windows.Forms.Label();
            this.backgroundWorker_GameInstall = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_GameVerify = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker_GameUpdate = new System.ComponentModel.BackgroundWorker();
            this.fileSizeProgress_label = new System.Windows.Forms.Label();
            this.verifyInstallation_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(400, 400);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // mainPanel_progressBar
            // 
            this.mainPanel_progressBar.Location = new System.Drawing.Point(13, 477);
            this.mainPanel_progressBar.Name = "mainPanel_progressBar";
            this.mainPanel_progressBar.Size = new System.Drawing.Size(400, 23);
            this.mainPanel_progressBar.TabIndex = 2;
            // 
            // mainPanel_mainButton
            // 
            this.mainPanel_mainButton.Location = new System.Drawing.Point(767, 460);
            this.mainPanel_mainButton.Name = "mainPanel_mainButton";
            this.mainPanel_mainButton.Size = new System.Drawing.Size(105, 40);
            this.mainPanel_mainButton.TabIndex = 3;
            this.mainPanel_mainButton.Text = "Default";
            this.mainPanel_mainButton.UseVisualStyleBackColor = true;
            this.mainPanel_mainButton.Click += new System.EventHandler(this.mainPanel_mainButton_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(817, 12);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(55, 23);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(12, 460);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(41, 13);
            this.progress_label.TabIndex = 5;
            this.progress_label.Text = "Default";
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Location = new System.Drawing.Point(12, 435);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(0, 13);
            this.warning_label.TabIndex = 6;
            // 
            // backgroundWorker_GameInstall
            // 
            this.backgroundWorker_GameInstall.WorkerReportsProgress = true;
            this.backgroundWorker_GameInstall.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_GameInstall_DoWork);
            this.backgroundWorker_GameInstall.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_GameInstall_ProgressChanged);
            this.backgroundWorker_GameInstall.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_GameInstall_RunWorkerCompleted);
            // 
            // backgroundWorker_GameUpdate
            // 
            this.backgroundWorker_GameUpdate.WorkerReportsProgress = true;
            this.backgroundWorker_GameUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_GameUpdate_DoWork);
            this.backgroundWorker_GameUpdate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_GameUpdate_ProgressChanged);
            this.backgroundWorker_GameUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_GameUpdate_RunWorkerCompleted);
            // 
            // fileSizeProgress_label
            // 
            this.fileSizeProgress_label.AutoSize = true;
            this.fileSizeProgress_label.Location = new System.Drawing.Point(12, 448);
            this.fileSizeProgress_label.Name = "fileSizeProgress_label";
            this.fileSizeProgress_label.Size = new System.Drawing.Size(0, 13);
            this.fileSizeProgress_label.TabIndex = 7;
            // 
            // verifyInstallation_button
            // 
            this.verifyInstallation_button.Location = new System.Drawing.Point(767, 425);
            this.verifyInstallation_button.Name = "verifyInstallation_button";
            this.verifyInstallation_button.Size = new System.Drawing.Size(105, 23);
            this.verifyInstallation_button.TabIndex = 9;
            this.verifyInstallation_button.Text = "Verify Installation";
            this.verifyInstallation_button.UseVisualStyleBackColor = true;
            this.verifyInstallation_button.Click += new System.EventHandler(this.verifyInstallation_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 512);
            this.Controls.Add(this.verifyInstallation_button);
            this.Controls.Add(this.fileSizeProgress_label);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.mainPanel_mainButton);
            this.Controls.Add(this.mainPanel_progressBar);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ProgressBar mainPanel_progressBar;
        private System.Windows.Forms.Button mainPanel_mainButton;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Label warning_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker_GameInstall;
        private System.ComponentModel.BackgroundWorker backgroundWorker_GameVerify;
        private System.ComponentModel.BackgroundWorker backgroundWorker_GameUpdate;
        private System.Windows.Forms.Label fileSizeProgress_label;
        private System.Windows.Forms.Button verifyInstallation_button;
    }
}

