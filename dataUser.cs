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
    public partial class dataUser : KryptonForm
    {
        public dataUser()
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
                    SqlDataAdapter ad = new SqlDataAdapter("EXEC Vuser", tmpls);
                    ad.SelectCommand.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    DgUser.DataSource = dt;

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
                    SqlCommand mas = new SqlCommand("EXEC inputUser @nama ,@username ,@pass", ins);
                    mas.Parameters.AddWithValue("@nama", txt_nama.Text.Trim());
                    mas.Parameters.AddWithValue("@username", txt_username.Text.Trim());
                    mas.Parameters.AddWithValue("@pass", txt_pass.Text.Trim());

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
        void updated()
        {
            try
            {
                using (SqlConnection del = new SqlConnection(koneksi.kon))
                {
                    del.Open();
                    DialogResult dr = MessageBox.Show("Apakah anda yakin ingin mengubah data ini",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        SqlCommand uptd = new SqlCommand("exec upUser @nama ,@username ,@pass", del);
                        uptd.Parameters.AddWithValue("@nama", txt_nama.Text);
                        uptd.Parameters.AddWithValue("@username", txt_username.Text);
                        uptd.Parameters.AddWithValue("@pass", txt_pass.Text);

                        uptd.ExecuteNonQuery();

                        MessageBox.Show("data berhasil di ubah ", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tampil();
                    }
                }
            }
            catch (Exception bb)
            {

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
                    SqlCommand deleted = new SqlCommand(" EXEC del_user @nama", del);
                    deleted.Parameters.AddWithValue("@nama", txt_nama.Text);
                    deleted.ExecuteNonQuery();
                    MessageBox.Show("data telah terhapus", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bersih();
                    tampil();
                }
            }
        }
        void bersih()
        {
            txt_nama.Clear();
            txt_username.Clear();
            txt_pass.Clear();
            txt_id.Clear();

        }
        
        private void dataUser_Load(object sender, EventArgs e)
        {



            tampil();
            
            


        }

        private void DgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

            isi();
            bersih();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            updated();
            bersih();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            hapus();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void DgUser_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow rw in DgUser.SelectedRows)
            {
                txt_id.Text = rw.Cells[0].Value.ToString();
                txt_nama.Text = rw.Cells[1].Value.ToString();
                txt_username.Text = rw.Cells[2].Value.ToString();
                txt_pass.Text = rw.Cells[3].Value.ToString();
               
            }
        }

        private void btn_dtUser_Click(object sender, EventArgs e)
        {

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
