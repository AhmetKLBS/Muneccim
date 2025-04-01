namespace DeepShakeUI
{
    partial class SettingsForm
    {
        private System.ComponentModel.IContainer components = null;
        private MaterialSkin.Controls.MaterialComboBox comboTheme;
        private MaterialSkin.Controls.MaterialButton btnSave;

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
            this.comboTheme = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();

            // comboTheme
            this.comboTheme.Depth = 0;
            this.comboTheme.Location = new System.Drawing.Point(50, 80);
            this.comboTheme.Size = new System.Drawing.Size(200, 40);
            this.comboTheme.TabIndex = 0;

            // btnSave
            this.btnSave.Depth = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Location = new System.Drawing.Point(50, 150);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // SettingsForm
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboTheme);
            this.Name = "SettingsForm";
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
        }
        #endregion
    }
}