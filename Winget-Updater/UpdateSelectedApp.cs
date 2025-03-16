﻿using System;
using System.Windows.Forms;

namespace Winget_Updater
{
    public partial class UpdateSelectedApp : Form
    {
        public UpdateSelectedApp()
        {
            InitializeComponent();
            LoadInstalledApps();
        }

        private void LoadInstalledApps()
        {
            listBoxApps.Items.Clear(); // Önce listeyi temizle
            var apps = WingetHelper.GetInstalledApps(); // Yeni sınıftan çağır

            foreach (var app in apps)
            {
                listBoxApps.Items.Add(app);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxApps.SelectedItem != null)
            {
                string? selectedApp = listBoxApps.SelectedItem.ToString();
                WingetUpdater.UpdateApp(selectedApp); // Yeni metodu çağır
            }
            else
            {
                MessageBox.Show("Lütfen bir uygulama seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
