using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Muneccim.Properties; // Doğru ad alanı


namespace DeepShakeUI
{
    public partial class SettingsForm : MaterialForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            // Tema Seçimi
            comboTheme.Items.AddRange(new[] { "Koyu", "Açık" });
            comboTheme.SelectedItem = Settings.Default.Theme; // Ayarı yükle
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Ayarı kaydet
            Settings.Default.Theme = comboTheme.SelectedItem.ToString();
            Settings.Default.Save();
            MessageBox.Show("Ayarlar kaydedildi!");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde ayarı ata
            comboTheme.SelectedItem = Settings.Default.Theme;
        }
    }

}

