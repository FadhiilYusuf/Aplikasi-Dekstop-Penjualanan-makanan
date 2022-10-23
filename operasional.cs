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
    public partial class operasional : KryptonForm
    {
        public operasional()
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
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC Voperasional", tmpls);
                    ad.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    DgOp.DataSource = dt;

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
                    SqlCommand mas = new SqlCommand("EXEC inputoperasional @tanggal,@keperluan,@jumlah,@biaya", ins);
                    mas.Parameters.AddWithValue("@tanggal", txt_tgl.Text.Trim());
                    mas.Parameters.AddWithValue("@keperluan", txt_keperluan.Text.Trim());
                    mas.Parameters.AddWithValue("@jumlah", txt_jumlah.Text.Trim());
                    mas.Parameters.AddWithValue("@biaya", txt_biaya.Text.Trim());
                  

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
                    SqlCommand deleted = new SqlCommand(" EXEC del_Operasiaonal @keperluan", del);
                    deleted.Parameters.AddWithValue("@keperluan", txt_keperluan.Text);
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
            txt_tgl.Clear();
            txt_keperluan.Clear();
            txt_jumlah.Clear();
            txt_biaya.Clear();
            

        }
        
        private void operasional_Load(object sender, EventArgs e)
        {
            tampil();

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

        private void DgOp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in DgOp.SelectedRows)
            {
                txt_id.Text = rw.Cells[0].Value.ToString();
                txt_tgl.Text = rw.Cells[1].Value.ToString();
                txt_keperluan.Text = rw.Cells[2].Value.ToString();
                txt_jumlah.Text = rw.Cells[3].Value.ToString();
                txt_biaya.Text = rw.Cells[4].Value.ToString();
               


            }
        }

        private void btn_laporan_Click(object sender, EventArgs e)
        {
            Report frmdturs = new Report();

            frmdturs.Show();
            this.Hide();
        }
    }
}
