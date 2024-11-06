using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace PROJECT_FINAL_VISPRO
{
    public partial class FormDashUserManageDataDiri1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FormDashUserManageDataDiri1()
        {
            alamat = "server=localhost; database=db_booking_asrama; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void txtNamaSiswa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FormDashUserManageDataDiri1_Load(object sender, EventArgs e)
        {
            dtTanggal.Format = DateTimePickerFormat.Custom;
            dtTanggal.CustomFormat = "yyyy/MM/dd";
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            FormDashAdmin formDashAdmin = new FormDashAdmin();
            formDashAdmin.Show();
        }

        private void btnResProf_Click(object sender, EventArgs e)
        {
            FormResProf  formResProf = new FormResProf();
            formResProf.Show();
        }

        private void btnDorm_Click(object sender, EventArgs e)
        {
            FormDorm formDorm = new FormDorm();
            formDorm.Show();
        }

        private void btnFinance_Click(object sender, EventArgs e)
        {
            FormFinance formFinance = new FormFinance();
            formFinance.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormDashUserManage formDashUserManage = new FormDashUserManage();
            formDashUserManage.Show();
        }

        private void btnInputDataDiri_Click(object sender, EventArgs e)
        {
            // Mengambil data dari kontrol
            string idMahasiswa = txtIDSiswa.Text;
            string nama = txtNamaSiswa.Text;
            string noRegis = txtNoregis.Text;
            string nim = txtNIM.Text;
            string fakultas = cmbFakultas.SelectedItem?.ToString(); 
            string jurusan = cmbJurusan.SelectedItem?.ToString();
            string agama = cmbAgama.SelectedItem?.ToString();
            string jenisKelamin = cmbGender.SelectedItem?.ToString(); 
            string tempatLahir = txtTempat.Text;
            DateTime tanggalLahir = dtTanggal.Value;
            string noTelp = txtTelp.Text;
            string email = txtEmailSiswa.Text;

            // Koneksi ke database
            string connectionString = "Server=localhost;Database=db_booking_asrama;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    if (txtNamaSiswa.Text != "" && txtNoregis.Text != "" && txtNIM.Text != "" && cmbFakultas.Text != "" && cmbJurusan.Text != "" && cmbAgama.Text != "" && cmbGender.Text != "" && txtTempat.Text != "" && dtTanggal.Value != DateTime.MinValue && txtTelp.Text != "" && txtEmailSiswa.Text != "")
                    {
                        string formattedDate = dtTanggal.Value.ToString("yyyy-MM-dd");

                        query = string.Format("insert into tbl_mahasiswa values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}');", txtIDSiswa.Text, txtNamaSiswa.Text, txtNoregis.Text, txtNIM.Text, cmbFakultas.Text, cmbJurusan.Text, cmbAgama.Text, cmbGender.Text, txtTempat.Text, dtTanggal.Value, txtTelp.Text, txtEmailSiswa.Text);

                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Insert Data Suksess ...");
                            FormDashUserManage formDashUserManage = new FormDashUserManage();
                            formDashUserManage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Gagal insert Data . . . ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak lengkap !!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dtTanggal_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtTanggal.Value;
            dtTanggal.Text = selectedDate.ToString("yyyy-MM-dd");
        }

        private void txtIDSiswa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
