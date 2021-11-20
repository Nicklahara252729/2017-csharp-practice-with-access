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
    public partial class jabatan : Form
    {
        public jabatan()
        {
            InitializeComponent();
        }

        private void jabatan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Jabatan' table. You can move, or remove it, as needed.
            this.jabatanTableAdapter.Fill(this.appData.Jabatan);
           
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            try
            {
                PDataJabatan.Enabled = true;
                txtjabatan.Focus();
                this.appData.Jabatan.AddJabatanRow
                    (this.appData.Jabatan.NewJabatanRow());
                jabatanBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                jabatanBindingSource.ResetBindings(false);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                jabatanBindingSource.EndEdit();
                jabatanTableAdapter.Update(this.appData.Jabatan);

                PDataJabatan.Enabled = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                jabatanBindingSource.ResetBindings(false);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            PDataJabatan.Enabled = true;
            txtjabatan.Focus();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            PDataJabatan.Enabled = false;
            jabatanBindingSource.ResetBindings(false);
        }

        private void viewjabatan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    jabatanBindingSource.RemoveCurrent();
            }
        }

        private void PctKaryawan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void PctLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialoresult = MessageBox.Show(" Apakah Anda Ingin Keluar ", " APP 0", MessageBoxButtons.YesNo);
            if (dialoresult == DialogResult.Yes) Application.Exit();
        }

       
    }
}
