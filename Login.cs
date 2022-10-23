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
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Length == 0 || txt_pass.Text.Length == 0)
                {
                    MessageBox.Show("anda belum input", "error", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection log = new SqlConnection(koneksi.kon))
                    {
                        log.Open();
                        SqlCommand i = new SqlCommand("Select Username,passwords from users where username = @username and passwords = @password", log);
                        i.Parameters.AddWithValue("@username", txt_username.Text);
                        i.Parameters.AddWithValue("@password", txt_pass.Text);
                        SqlDataReader rd;
                        rd = i.ExecuteReader();
                        if (rd.Read())
                        {
                            if (txt_username.Text != "ican" && txt_pass.Text != "123")
                            {
                                MessageBox.Show("Anda telah berhasil Log in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataUser us = new dataUser();
                                us.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Anda telah berhasil Log in", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dataUser das = new dataUser();
                                das.Show();
                                this.Hide();


                            }




                        }
                        else
                        {
                            MessageBox.Show("login gagal");
                        }
                    }

                }


            }
            catch (Exception log)
            {
                MessageBox.Show(log.Message);

            }
        }
    }
}
