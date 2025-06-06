﻿namespace Nova_Updater
{
    partial class UpdateSelectedApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSelectedApp));
            listBoxApps = new ListBox();
            btnUpdate = new Button();
            btnClose = new PictureBox();
            btnBack = new PictureBox();
            StripStatusZone = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            StripStatusZone.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxApps
            // 
            resources.ApplyResources(listBoxApps, "listBoxApps");
            listBoxApps.FormattingEnabled = true;
            listBoxApps.Name = "listBoxApps";
            // 
            // btnUpdate
            // 
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            resources.ApplyResources(btnClose, "btnClose");
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.close;
            btnClose.Name = "btnClose";
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnBack
            // 
            resources.ApplyResources(btnBack, "btnBack");
            btnBack.Cursor = Cursors.Hand;
            btnBack.Image = Properties.Resources.back;
            btnBack.Name = "btnBack";
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // StripStatusZone
            // 
            resources.ApplyResources(StripStatusZone, "StripStatusZone");
            StripStatusZone.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            StripStatusZone.Name = "StripStatusZone";
            // 
            // toolStripStatusLabel
            // 
            resources.ApplyResources(toolStripStatusLabel, "toolStripStatusLabel");
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            // 
            // UpdateSelectedApp
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StripStatusZone);
            Controls.Add(btnBack);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(listBoxApps);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateSelectedApp";
            Load += UpdateSelectedApp_Load;
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            StripStatusZone.ResumeLayout(false);
            StripStatusZone.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxApps;
        private Button btnUpdate;
        private PictureBox btnClose;
        private PictureBox btnBack;
        private StatusStrip StripStatusZone;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}