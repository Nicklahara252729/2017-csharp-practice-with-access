namespace DatabaseAccess
{
    partial class jabatan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.PctLogout = new System.Windows.Forms.PictureBox();
            this.PctKaryawan = new System.Windows.Forms.PictureBox();
            this.PDataJabatan = new System.Windows.Forms.Panel();
            this.txtgajipokok = new System.Windows.Forms.TextBox();
            this.jabatanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DatabaseAccess.AppData();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txttunjangan = new System.Windows.Forms.TextBox();
            this.txtjabatan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.viewjabatan = new System.Windows.Forms.DataGridView();
            this.iDJabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jabatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gajiPokokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tunjTransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PBtnKaryawan = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.jabatanTableAdapter = new DatabaseAccess.AppDataTableAdapters.JabatanTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctKaryawan)).BeginInit();
            this.PDataJabatan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewjabatan)).BeginInit();
            this.PBtnKaryawan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.DgvView);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PctLogout);
            this.panel1.Controls.Add(this.PctKaryawan);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 471);
            this.panel1.TabIndex = 1;
            // 
            // DgvView
            // 
            this.DgvView.BackgroundColor = System.Drawing.Color.White;
            this.DgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvView.Location = new System.Drawing.Point(108, 248);
            this.DgvView.Name = "DgvView";
            this.DgvView.Size = new System.Drawing.Size(702, 213);
            this.DgvView.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(2, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "KARYAWAN";
            // 
            // PctLogout
            // 
            this.PctLogout.Image = global::DatabaseAccess.Properties.Resources.logout;
            this.PctLogout.Location = new System.Drawing.Point(7, 379);
            this.PctLogout.Name = "PctLogout";
            this.PctLogout.Size = new System.Drawing.Size(92, 89);
            this.PctLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogout.TabIndex = 16;
            this.PctLogout.TabStop = false;
            this.PctLogout.Click += new System.EventHandler(this.PctLogout_Click);
            // 
            // PctKaryawan
            // 
            this.PctKaryawan.Image = global::DatabaseAccess.Properties.Resources.administrator_icon_5154;
            this.PctKaryawan.Location = new System.Drawing.Point(3, 3);
            this.PctKaryawan.Name = "PctKaryawan";
            this.PctKaryawan.Size = new System.Drawing.Size(92, 89);
            this.PctKaryawan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctKaryawan.TabIndex = 14;
            this.PctKaryawan.TabStop = false;
            this.PctKaryawan.Click += new System.EventHandler(this.PctKaryawan_Click);
            // 
            // PDataJabatan
            // 
            this.PDataJabatan.BackColor = System.Drawing.Color.White;
            this.PDataJabatan.Controls.Add(this.txtgajipokok);
            this.PDataJabatan.Controls.Add(this.label7);
            this.PDataJabatan.Controls.Add(this.pictureBox1);
            this.PDataJabatan.Controls.Add(this.txttunjangan);
            this.PDataJabatan.Controls.Add(this.txtjabatan);
            this.PDataJabatan.Controls.Add(this.label4);
            this.PDataJabatan.Controls.Add(this.label3);
            this.PDataJabatan.Controls.Add(this.label2);
            this.PDataJabatan.Enabled = false;
            this.PDataJabatan.Location = new System.Drawing.Point(107, 1);
            this.PDataJabatan.Name = "PDataJabatan";
            this.PDataJabatan.Size = new System.Drawing.Size(709, 245);
            this.PDataJabatan.TabIndex = 2;
            // 
            // txtgajipokok
            // 
            this.txtgajipokok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jabatanBindingSource, "GajiPokok", true));
            this.txtgajipokok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgajipokok.Location = new System.Drawing.Point(193, 89);
            this.txtgajipokok.Name = "txtgajipokok";
            this.txtgajipokok.Size = new System.Drawing.Size(241, 24);
            this.txtgajipokok.TabIndex = 20;
            // 
            // jabatanBindingSource
            // 
            this.jabatanBindingSource.DataMember = "Jabatan";
            this.jabatanBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(62, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "JABATAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseAccess.Properties.Resources.new_database_512;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txttunjangan
            // 
            this.txttunjangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jabatanBindingSource, "TunjTransport", true));
            this.txttunjangan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttunjangan.Location = new System.Drawing.Point(192, 124);
            this.txttunjangan.Name = "txttunjangan";
            this.txttunjangan.Size = new System.Drawing.Size(241, 24);
            this.txttunjangan.TabIndex = 10;
            // 
            // txtjabatan
            // 
            this.txtjabatan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jabatanBindingSource, "Jabatan", true));
            this.txtjabatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjabatan.Location = new System.Drawing.Point(193, 55);
            this.txtjabatan.Name = "txtjabatan";
            this.txtjabatan.Size = new System.Drawing.Size(241, 24);
            this.txtjabatan.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tunjangan Transport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gaji Pokok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jabatan";
            // 
            // viewjabatan
            // 
            this.viewjabatan.AutoGenerateColumns = false;
            this.viewjabatan.BackgroundColor = System.Drawing.Color.White;
            this.viewjabatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewjabatan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDJabatanDataGridViewTextBoxColumn,
            this.jabatanDataGridViewTextBoxColumn,
            this.gajiPokokDataGridViewTextBoxColumn,
            this.tunjTransportDataGridViewTextBoxColumn});
            this.viewjabatan.DataSource = this.jabatanBindingSource;
            this.viewjabatan.Location = new System.Drawing.Point(106, 254);
            this.viewjabatan.Name = "viewjabatan";
            this.viewjabatan.Size = new System.Drawing.Size(710, 216);
            this.viewjabatan.TabIndex = 3;
            this.viewjabatan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewjabatan_KeyDown);
            // 
            // iDJabatanDataGridViewTextBoxColumn
            // 
            this.iDJabatanDataGridViewTextBoxColumn.DataPropertyName = "IDJabatan";
            this.iDJabatanDataGridViewTextBoxColumn.HeaderText = "IDJabatan";
            this.iDJabatanDataGridViewTextBoxColumn.Name = "iDJabatanDataGridViewTextBoxColumn";
            // 
            // jabatanDataGridViewTextBoxColumn
            // 
            this.jabatanDataGridViewTextBoxColumn.DataPropertyName = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.HeaderText = "Jabatan";
            this.jabatanDataGridViewTextBoxColumn.Name = "jabatanDataGridViewTextBoxColumn";
            // 
            // gajiPokokDataGridViewTextBoxColumn
            // 
            this.gajiPokokDataGridViewTextBoxColumn.DataPropertyName = "GajiPokok";
            this.gajiPokokDataGridViewTextBoxColumn.HeaderText = "GajiPokok";
            this.gajiPokokDataGridViewTextBoxColumn.Name = "gajiPokokDataGridViewTextBoxColumn";
            // 
            // tunjTransportDataGridViewTextBoxColumn
            // 
            this.tunjTransportDataGridViewTextBoxColumn.DataPropertyName = "TunjTransport";
            this.tunjTransportDataGridViewTextBoxColumn.HeaderText = "TunjTransport";
            this.tunjTransportDataGridViewTextBoxColumn.Name = "tunjTransportDataGridViewTextBoxColumn";
            // 
            // PBtnKaryawan
            // 
            this.PBtnKaryawan.BackColor = System.Drawing.Color.Gray;
            this.PBtnKaryawan.Controls.Add(this.btncancel);
            this.PBtnKaryawan.Controls.Add(this.btnedit);
            this.PBtnKaryawan.Controls.Add(this.btnsave);
            this.PBtnKaryawan.Controls.Add(this.btnnew);
            this.PBtnKaryawan.Location = new System.Drawing.Point(-1, 473);
            this.PBtnKaryawan.Name = "PBtnKaryawan";
            this.PBtnKaryawan.Size = new System.Drawing.Size(817, 33);
            this.PBtnKaryawan.TabIndex = 4;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(737, 1);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(78, 29);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(660, 1);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(78, 29);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(583, 1);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(78, 29);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(506, 1);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(78, 29);
            this.btnnew.TabIndex = 0;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // jabatanTableAdapter
            // 
            this.jabatanTableAdapter.ClearBeforeFill = true;
            // 
            // jabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 505);
            this.Controls.Add(this.PBtnKaryawan);
            this.Controls.Add(this.viewjabatan);
            this.Controls.Add(this.PDataJabatan);
            this.Controls.Add(this.panel1);
            this.Name = "jabatan";
            this.Text = "jabatan";
            this.Load += new System.EventHandler(this.jabatan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctKaryawan)).EndInit();
            this.PDataJabatan.ResumeLayout(false);
            this.PDataJabatan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jabatanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewjabatan)).EndInit();
            this.PBtnKaryawan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox PctLogout;
        private System.Windows.Forms.PictureBox PctKaryawan;
        private System.Windows.Forms.Panel PDataJabatan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txttunjangan;
        private System.Windows.Forms.TextBox txtjabatan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvView;
        private System.Windows.Forms.DataGridView viewjabatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtgajipokok;
        private System.Windows.Forms.Panel PBtnKaryawan;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnew;
        private AppData appData;
        private System.Windows.Forms.BindingSource jabatanBindingSource;
        private AppDataTableAdapters.JabatanTableAdapter jabatanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDJabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jabatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gajiPokokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tunjTransportDataGridViewTextBoxColumn;
    }
}