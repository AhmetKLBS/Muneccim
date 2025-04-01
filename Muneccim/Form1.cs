using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DeepShakeUI
{
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeMaterialTheme();
            ConfigureSidebar();
        }

        private void InitializeMaterialTheme()
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void ConfigureSidebar()
        {
            // Hover efekti
            btnGallery.MouseEnter += (s, e) => btnGallery.BackColor = Color.FromArgb(50, 50, 50);
            btnGallery.MouseLeave += (s, e) => btnGallery.BackColor = Color.Transparent;
            btnUpload.MouseEnter += (s, e) => btnUpload.BackColor = Color.FromArgb(50, 50, 50);
            btnUpload.MouseLeave += (s, e) => btnUpload.BackColor = Color.Transparent;
            btnSettings.MouseEnter += (s, e) => btnSettings.BackColor = Color.FromArgb(50, 50, 50);
            btnSettings.MouseLeave += (s, e) => btnSettings.BackColor = Color.Transparent;
        }

        // Buton Click Event'leri
        private void btnGallery_Click(object sender, EventArgs e)
        {
            var gallery = new GalleryForm();
            gallery.Show();
            this.Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var upload = new UploadForm();
            upload.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settings = new SettingsForm();
            settings.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e) { }
    }
}