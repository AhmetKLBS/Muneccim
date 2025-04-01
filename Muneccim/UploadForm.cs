using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DeepShakeUI
{
    public partial class UploadForm : MaterialForm
    {
        public UploadForm()
        {
            InitializeComponent();

            // Sürükle-Bırak Event'leri
            panelDragDrop.AllowDrop = true;
            panelDragDrop.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    e.Effect = DragDropEffects.Copy;
            };
            panelDragDrop.DragDrop += (s, e) =>
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                    listBoxFiles.Items.Add(file);
            };
        }

        // HATA ÇÖZÜMÜ: Load event'i kaldırıldı veya eklendi
        private void UploadForm_Load(object sender, EventArgs e)
        {
            // Gerekirse buraya kod ekleyin
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Multiselect = true };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                listBoxFiles.Items.AddRange(openFileDialog.FileNames);
        }
    }
}