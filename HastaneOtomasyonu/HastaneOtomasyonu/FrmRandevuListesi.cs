using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HastaneOtomasyonu
{
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevu",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
