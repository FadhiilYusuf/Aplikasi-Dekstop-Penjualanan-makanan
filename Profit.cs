using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;


namespace TokoSinarTasik
{
    public partial class Profit : KryptonForm
    {
        public Profit()
        {
            InitializeComponent();
        }
        void tampil()
        {
            try
            {
                using (SqlConnection tmpls = new SqlConnection(koneksi.kon))
                {
                    tmpls.Open();
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC Vprofit", tmpls);
                    ad.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    DgProfit.DataSource = dt;

                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }

        }
        void isi()
        {
            using (SqlConnection ins = new SqlConnection(koneksi.kon))
            {
                DialogResult dr = MessageBox.Show("Apakah anda yakin akan menyimpan data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ins.Open();
                    SqlCommand mas = new SqlCommand("EXEC inputProfit @bulan ,@total ,@biaya ,@totalBelanja", ins);
                    mas.Parameters.AddWithValue("@bulan", txt_bulan.Text.Trim());
                    mas.Parameters.AddWithValue("@total", Cb_idjual.Text.Trim());
                    mas.Parameters.AddWithValue("@biaya", Cb_idOp.Text.Trim());

                    mas.Parameters.AddWithValue("@totalBelanja", Cb_idbelanja.Text.Trim());

                    mas.ExecuteNonQuery();
                    MessageBox.Show("data telah tersimpan", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tampil();
                }
                else if (dr == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        void hapus()
        {
            using (SqlConnection del = new SqlConnection(koneksi.kon))
            {
                del.Open();
                DialogResult dr = MessageBox.Show("Apakah anda yakin ingin menghapus data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand deleted = new SqlCommand(" EXEC del_profit @bulan", del);
                    deleted.Parameters.AddWithValue("@bulan", txt_bulan.Text);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    tampil();
                }
            }
        }
        void bersih()
        {
            txt_id.Clear();
            txt_bulan.Clear();
     
            

        }
        
        void tampjual()
        {
            using (SqlConnection del = new SqlConnection(koneksi.kon))
            {
                del.Open();
                SqlCommand dad = new SqlCommand(" EXEC Vpenjualan", del);
                SqlDataReader rd;
                rd = dad.ExecuteReader();
                while (rd.Read())
                {
                    Cb_idjual.Items.Add(rd[7]);
                }
            }
        }
        void tampOP()
        {
            using (SqlConnection del = new SqlConnection(koneksi.kon))
            {
                del.Open();
                SqlCommand dad = new SqlCommand(" EXEC Voperasional", del);
                SqlDataReader rd;
                rd = dad.ExecuteReader();
                while (rd.Read())
                {
                    Cb_idOp.Items.Add(rd[5]);
                }
            }
        }
        void tampblanja()
        {
            using (SqlConnection del = new SqlConnection(koneksi.kon))
            {
                del.Open();
                SqlCommand dad = new SqlCommand(" EXEC Vbelanja", del);
                SqlDataReader rd;
                rd = dad.ExecuteReader();
                while (rd.Read())
                {
                    Cb_idbelanja.Items.Add(rd[7]);
                }
            }
        }
        private void Profit_Load(object sender, EventArgs e)
        {
            tampil();
            tampjual();
            tampOP();
            tampblanja();

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            isi();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bersih();
        }

        

        private void DgProfit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in DgProfit.SelectedRows)
            {
                txt_id.Text = rw.Cells[0].Value.ToString();
                txt_bulan.Text = rw.Cells[1].Value.ToString();
                Cb_idjual.Text = rw.Cells[2].Value.ToString();
                Cb_idOp.Text = rw.Cells[3].Value.ToString();
                Cb_idbelanja.Text = rw.Cells[4].Value.ToString();
            }
        }

        private void DgProfit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_dtUser_Click(object sender, EventArgs e)
        {
            dataUser frmdturs = new dataUser();

            frmdturs.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            DataPenjualan frmdturs = new DataPenjualan();

            frmdturs.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            operasional frmdturs = new operasional();

            frmdturs.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            DataBelanja frmdturs = new DataBelanja();

            frmdturs.Show();
            this.Hide();
        }

        private void tbl_xilang_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            Report frmdturs = new Report();

            frmdturs.Show();
            this.Hide();
        }
    }
}
