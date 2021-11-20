namespace DatabaseAccess
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.PctLogout = new System.Windows.Forms.PictureBox();
            this.PctJabatan = new System.Windows.Forms.PictureBox();
            this.PKaryawan = new System.Windows.Forms.Panel();
            this.PDataKaryawan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.PctView = new System.Windows.Forms.PictureBox();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new DatabaseAccess.AppData();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.TxtFullName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvView = new System.Windows.Forms.DataGridView();
            this.karyawanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PBtnKaryawan = new System.Windows.Forms.Panel();
            this.BtnCancelK = new System.Windows.Forms.Button();
            this.BtnEditK = new System.Windows.Forms.Button();
            this.BtnSaveK = new System.Windows.Forms.Button();
            this.BtnNewK = new System.Windows.Forms.Button();
            this.karyawanTableAdapter = new DatabaseAccess.AppDataTableAdapters.KaryawanTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctJabatan)).BeginInit();
            this.PKaryawan.SuspendLayout();
            this.PDataKaryawan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).BeginInit();
            this.PBtnKaryawan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LawnGreen;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PctLogout);
            this.panel1.Controls.Add(this.PctJabatan);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 471);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "JABATAN";
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
            // 
            // PctJabatan
            // 
            this.PctJabatan.Image = global::DatabaseAccess.Properties.Resources.new_database_512;
            this.PctJabatan.Location = new System.Drawing.Point(10, 8);
            this.PctJabatan.Name = "PctJabatan";
            this.PctJabatan.Size = new System.Drawing.Size(92, 89);
            this.PctJabatan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctJabatan.TabIndex = 15;
            this.PctJabatan.TabStop = false;
            this.PctJabatan.Click += new System.EventHandler(this.PctJabatan_Click);
            // 
            // PKaryawan
            // 
            this.PKaryawan.BackColor = System.Drawing.Color.Gray;
            this.PKaryawan.Controls.Add(this.PDataKaryawan);
            this.PKaryawan.Location = new System.Drawing.Point(105, 0);
            this.PKaryawan.Name = "PKaryawan";
            this.PKaryawan.Size = new System.Drawing.Size(712, 254);
            this.PKaryawan.TabIndex = 1;
            // 
            // PDataKaryawan
            // 
            this.PDataKaryawan.BackColor = System.Drawing.Color.White;
            this.PDataKaryawan.Controls.Add(this.pictureBox1);
            this.PDataKaryawan.Controls.Add(this.BtnBrowse);
            this.PDataKaryawan.Controls.Add(this.PctView);
            this.PDataKaryawan.Controls.Add(this.TxtAddress);
            this.PDataKaryawan.Controls.Add(this.TxtEmail);
            this.PDataKaryawan.Controls.Add(this.TxtPhoneNumber);
            this.PDataKaryawan.Controls.Add(this.TxtFullName);
            this.PDataKaryawan.Controls.Add(this.label5);
            this.PDataKaryawan.Controls.Add(this.label4);
            this.PDataKaryawan.Controls.Add(this.label3);
            this.PDataKaryawan.Controls.Add(this.label2);
            this.PDataKaryawan.Enabled = false;
            this.PDataKaryawan.Location = new System.Drawing.Point(0, 0);
            this.PDataKaryawan.Name = "PDataKaryawan";
            this.PDataKaryawan.Size = new System.Drawing.Size(712, 245);
            this.PDataKaryawan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DatabaseAccess.Properties.Resources.administrator_icon_5154;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrowse.Location = new System.Drawing.Point(594, 186);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(78, 25);
            this.BtnBrowse.TabIndex = 4;
            this.BtnBrowse.Text = "BROWSE";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // PctView
            // 
            this.PctView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PctView.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.karyawanBindingSource, "Image", true));
            this.PctView.Location = new System.Drawing.Point(568, 12);
            this.PctView.Name = "PctView";
            this.PctView.Size = new System.Drawing.Size(128, 168);
            this.PctView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctView.TabIndex = 12;
            this.PctView.TabStop = false;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtAddress
            // 
            this.TxtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Address", true));
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(159, 157);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(388, 56);
            this.TxtAddress.TabIndex = 11;
            // 
            // TxtEmail
            // 
            this.TxtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "Email", true));
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(159, 124);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(241, 24);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "PhoneNumber", true));
            this.TxtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNumber.Location = new System.Drawing.Point(159, 90);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(241, 24);
            this.TxtPhoneNumber.TabIndex = 9;
            // 
            // TxtFullName
            // 
            this.TxtFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.karyawanBindingSource, "FullName", true));
            this.TxtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFullName.Location = new System.Drawing.Point(159, 55);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(241, 24);
            this.TxtFullName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full Name";
            // 
            // DgvView
            // 
            this.DgvView.AutoGenerateColumns = false;
            this.DgvView.BackgroundColor = System.Drawing.Color.White;
            this.DgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.karyawanIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.DgvView.DataSource = this.karyawanBindingSource;
            this.DgvView.Location = new System.Drawing.Point(109, 256);
            this.DgvView.Name = "DgvView";
            this.DgvView.Size = new System.Drawing.Size(702, 213);
            this.DgvView.TabIndex = 2;
            this.DgvView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvView_KeyDown);
            // 
            // karyawanIDDataGridViewTextBoxColumn
            // 
            this.karyawanIDDataGridViewTextBoxColumn.DataPropertyName = "KaryawanID";
            this.karyawanIDDataGridViewTextBoxColumn.HeaderText = "KaryawanID";
            this.karyawanIDDataGridViewTextBoxColumn.Name = "karyawanIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // PBtnKaryawan
            // 
            this.PBtnKaryawan.BackColor = System.Drawing.Color.Gray;
            this.PBtnKaryawan.Controls.Add(this.BtnCancelK);
            this.PBtnKaryawan.Controls.Add(this.BtnEditK);
            this.PBtnKaryawan.Controls.Add(this.BtnSaveK);
            this.PBtnKaryawan.Controls.Add(this.BtnNewK);
            this.PBtnKaryawan.Location = new System.Drawing.Point(0, 471);
            this.PBtnKaryawan.Name = "PBtnKaryawan";
            this.PBtnKaryawan.Size = new System.Drawing.Size(817, 33);
            this.PBtnKaryawan.TabIndex = 2;
            // 
            // BtnCancelK
            // 
            this.BtnCancelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelK.Location = new System.Drawing.Point(737, 1);
            this.BtnCancelK.Name = "BtnCancelK";
            this.BtnCancelK.Size = new System.Drawing.Size(78, 29);
            this.BtnCancelK.TabIndex = 3;
            this.BtnCancelK.Text = "CANCEL";
            this.BtnCancelK.UseVisualStyleBackColor = true;
            this.BtnCancelK.Click += new System.EventHandler(this.BtnCancelK_Click);
            // 
            // BtnEditK
            // 
            this.BtnEditK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditK.Location = new System.Drawing.Point(660, 1);
            this.BtnEditK.Name = "BtnEditK";
            this.BtnEditK.Size = new System.Drawing.Size(78, 29);
            this.BtnEditK.TabIndex = 2;
            this.BtnEditK.Text = "EDIT";
            this.BtnEditK.UseVisualStyleBackColor = true;
            this.BtnEditK.Click += new System.EventHandler(this.BtnEditK_Click);
            // 
            // BtnSaveK
            // 
            this.BtnSaveK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveK.Location = new System.Drawing.Point(583, 1);
            this.BtnSaveK.Name = "BtnSaveK";
            this.BtnSaveK.Size = new System.Drawing.Size(78, 29);
            this.BtnSaveK.TabIndex = 1;
            this.BtnSaveK.Text = "SAVE";
            this.BtnSaveK.UseVisualStyleBackColor = true;
            this.BtnSaveK.Click += new System.EventHandler(this.BtnSaveK_Click);
            // 
            // BtnNewK
            // 
            this.BtnNewK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewK.Location = new System.Drawing.Point(506, 1);
            this.BtnNewK.Name = "BtnNewK";
            this.BtnNewK.Size = new System.Drawing.Size(78, 29);
            this.BtnNewK.TabIndex = 0;
            this.BtnNewK.Text = "NEW";
            this.BtnNewK.UseVisualStyleBackColor = true;
            this.BtnNewK.Click += new System.EventHandler(this.BtnNewK_Click);
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PBtnKaryawan);
            this.Controls.Add(this.DgvView);
            this.Controls.Add(this.PKaryawan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctJabatan)).EndInit();
            this.PKaryawan.ResumeLayout(false);
            this.PDataKaryawan.ResumeLayout(false);
            this.PDataKaryawan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvView)).EndInit();
            this.PBtnKaryawan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PKaryawan;
        private System.Windows.Forms.DataGridView DgvView;
        private System.Windows.Forms.Panel PDataKaryawan;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.TextBox TxtFullName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PBtnKaryawan;
        private System.Windows.Forms.Button BtnCancelK;
        private System.Windows.Forms.Button BtnEditK;
        private System.Windows.Forms.Button BtnSaveK;
        private System.Windows.Forms.Button BtnNewK;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.PictureBox PctView;
        private System.Windows.Forms.PictureBox PctLogout;
        private System.Windows.Forms.PictureBox PctJabatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AppData appData;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private AppDataTableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn karyawanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}

