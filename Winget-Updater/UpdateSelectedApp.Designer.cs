﻿namespace Winget_Updater
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
            // UpdateSelectedApp
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(listBoxApps);
            Name = "UpdateSelectedApp";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxApps;
        private Button btnUpdate;
    }
}