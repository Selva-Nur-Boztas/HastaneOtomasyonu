using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            //Bilgileri Getirme
            msk_TC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hasta where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_TC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                msk_telefon.Text = dr[4].ToString();
                txt_sifre.Text = dr[5].ToString();
                cmb_cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_kayıtyapguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hasta set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", msk_telefon.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmb_cinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msk_TC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
