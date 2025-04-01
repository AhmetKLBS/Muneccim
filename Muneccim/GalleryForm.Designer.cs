namespace DeepShakeUI
{
    partial class GalleryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(37, 37, 38);
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 600);
            this.dataGridView1.TabIndex = 0;

            // GalleryForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GalleryForm";
            this.Text = "Deprem Veri Galerisi";
            this.ResumeLayout(false);
        }
        #endregion
    }
}