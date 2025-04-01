namespace DeepShakeUI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private FontAwesome.Sharp.IconButton btnGallery;
        private FontAwesome.Sharp.IconButton btnUpload;
        private FontAwesome.Sharp.IconButton btnSettings;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnGallery = new FontAwesome.Sharp.IconButton();
            this.btnUpload = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();

            // btnGallery
            this.btnGallery.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btnGallery.Text = "Galeri";
            this.btnGallery.Location = new System.Drawing.Point(50, 50);
            this.btnGallery.Size = new System.Drawing.Size(200, 50);
            this.btnGallery.Click += new System.EventHandler(this.btnGallery_Click);

            // btnUpload
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUpload.Text = "Yükle";
            this.btnUpload.Location = new System.Drawing.Point(50, 120);
            this.btnUpload.Size = new System.Drawing.Size(200, 50);
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);

            // btnSettings
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.Location = new System.Drawing.Point(50, 190);
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGallery);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnSettings);
            this.Name = "MainForm";
            this.Text = "DeepShake";
            this.ResumeLayout(false);
        }
    }
}