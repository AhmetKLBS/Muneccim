using MaterialSkin.Controls;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DeepShakeUI
{
    public partial class GalleryForm : MaterialForm
    {
        public GalleryForm()
        {
            InitializeComponent();

            // DataGridView Stili ve Veri Yükleme
            dataGridView1.DataSource = GetSampleData();
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
        }

        private DataTable GetSampleData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Büyüklük");
            dt.Columns.Add("Konum");

            dt.Rows.Add("2023-10-01", "5.2", "İstanbul");
            dt.Rows.Add("2023-10-02", "4.8", "İzmir");
            return dt;
        }
    }
}