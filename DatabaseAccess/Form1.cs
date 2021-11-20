using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Karyawan' table. You can move, or remove it, as needed.
            this.karyawanTableAdapter.Fill(this.appData.Karyawan);
            karyawanBindingSource.DataSource = this.appData.Karyawan;
        }

        private void BtnNewK_Click(object sender, EventArgs e)
        {
            try
            {
                PDataKaryawan.Enabled = true;
                TxtFullName.Focus();
                this.appData.Karyawan.AddKaryawanRow
                    (this.appData.Karyawan.NewKaryawanRow());
                karyawanBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                karyawanBindingSource.ResetBindings(false);
            }
        }

        private void BtnSaveK_Click(object sender, EventArgs e)
        {
            try
            {
                karyawanBindingSource.EndEdit();
                karyawanTableAdapter.Update(this.appData.Karyawan);

                PDataKaryawan.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                karyawanBindingSource.ResetBindings(false);
            }
        }

        private void BtnEditK_Click(object sender, EventArgs e)
        {
            PDataKaryawan.Enabled = true;
            TxtFullName.Focus();
        }

        private void BtnCancelK_Click(object sender, EventArgs e)
        {
            PDataKaryawan.Enabled = false;
            karyawanBindingSource.ResetBindings(false);
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        PctView.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DgvView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    karyawanBindingSource.RemoveCurrent();
            }
        }

        private void PctJabatan_Click(object sender, EventArgs e)
        {
            this.Hide();
            jabatan jab = new jabatan();
            jab.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
