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
    public partial class DataPenjualan : KryptonForm
    {
        public DataPenjualan()
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
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC Vpenjualan", tmpls);
                    ad.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    Dgpenjualn.DataSource = dt;

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
                    SqlCommand mas = new SqlCommand("EXEC inputPenjualan @tanggal,@produk ,@rasa ,@jenis ,@harga ,@jumlah", ins);
                    mas.Parameters.AddWithValue("@tanggal", txt_tgl.Text.Trim());
                    mas.Parameters.AddWithValue("@produk", txt_produk.Text.Trim());
                    mas.Parameters.AddWithValue("@rasa", txt_rasa.Text.Trim());

                    mas.Parameters.AddWithValue("@jenis", txt_jenis.Text.Trim());
                    mas.Parameters.AddWithValue("@harga", txt_harga.Text.Trim());
                    mas.Parameters.AddWithValue("@jumlah", txt_jumlah.Text.Trim());

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
                    SqlCommand deleted = new SqlCommand(" EXEC del_penjualan @produk", del);
                    deleted.Parameters.AddWithValue("@produk", txt_produk.Text);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    tampil();
                }
            }
        }
        void bersih()
        {
            txt_tgl.Clear();
            txt_produk.Clear();
            txt_rasa.Clear();
            txt_jenis.Clear();
            txt_harga.Clear();
            txt_jumlah.Clear();

        }
        
        private void DataPenjualan_Load(object sender, EventArgs e)
        {
            tampil();

        }

        private void Dgpenjualn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in Dgpenjualn.SelectedRows)
            {
                txt_id.Text = rw.Cells[0].Value.ToString();
                txt_tgl.Text = rw.Cells[1].Value.ToString();
                txt_produk.Text = rw.Cells[2].Value.ToString();
                txt_rasa.Text = rw.Cells[3].Value.ToString();
                txt_jenis.Text = rw.Cells[4].Value.ToString();
                txt_harga.Text = rw.Cells[5].Value.ToString();
                txt_jumlah.Text = rw.Cells[6].Value.ToString();
               

            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            isi();
            bersih();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            hapus();
            bersih();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bersih();
            bersih();
        }

        private void Dgpenjualn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_dtUser_Click(object sender, EventArgs e)
        {
            dataUser frmdturs = new dataUser();

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

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            Profit frmdturs = new Profit();

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
