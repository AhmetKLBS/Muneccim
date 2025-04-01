namespace DeepShakeUI
{
    partial class UploadForm
    {
        private System.ComponentModel.IContainer components = null;

        // MaterialPanel YERİNE STANDART PANEL
        private System.Windows.Forms.Panel panelDragDrop;
        private System.Windows.Forms.ListBox listBoxFiles;
        private MaterialSkin.Controls.MaterialButton btnBrowse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelDragDrop = new System.Windows.Forms.Panel();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // panelDragDrop
            this.panelDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDragDrop.BackColor = System.Drawing.Color.FromArgb(62, 62, 66);
            this.panelDragDrop.Location = new System.Drawing.Point(50, 80);
            this.panelDragDrop.Size = new System.Drawing.Size(400, 200);

            // btnBrowse
            this.btnBrowse.Depth = 0;
            this.btnBrowse.Text = "Dosya Seç";
            this.btnBrowse.Location = new System.Drawing.Point(50, 480);

            // UploadForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.panelDragDrop);
            this.Name = "UploadForm";
            this.Text = "Dosya Yükle";
            this.ResumeLayout(false);
        }
        #endregion
    }
}