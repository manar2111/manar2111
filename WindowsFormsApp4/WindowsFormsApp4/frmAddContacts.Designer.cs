namespace WindowsFormsApp4
{
    partial class frmAddContacts
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
            this.labTotel = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.labFN = new System.Windows.Forms.Label();
            this.labLN = new System.Windows.Forms.Label();
            this.labEm = new System.Windows.Forms.Label();
            this.labPh = new System.Windows.Forms.Label();
            this.labDataB = new System.Windows.Forms.Label();
            this.labCountry = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ContactIDLab = new System.Windows.Forms.Label();
            this.txtBfirstN = new System.Windows.Forms.TextBox();
            this.txtBLastN = new System.Windows.Forms.TextBox();
            this.txtBEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.llsetimage = new System.Windows.Forms.LinkLabel();
            this.llremove = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labTotel
            // 
            this.labTotel.AutoSize = true;
            this.labTotel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.labTotel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTotel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labTotel.Location = new System.Drawing.Point(219, 22);
            this.labTotel.Name = "labTotel";
            this.labTotel.Size = new System.Drawing.Size(146, 21);
            this.labTotel.TabIndex = 0;
            this.labTotel.Text = "Add New Contact";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labID.Location = new System.Drawing.Point(30, 87);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(88, 18);
            this.labID.TabIndex = 1;
            this.labID.Text = "Contact ID";
            // 
            // labFN
            // 
            this.labFN.AutoSize = true;
            this.labFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFN.Location = new System.Drawing.Point(30, 127);
            this.labFN.Name = "labFN";
            this.labFN.Size = new System.Drawing.Size(91, 18);
            this.labFN.TabIndex = 2;
            this.labFN.Text = "First Name";
            // 
            // labLN
            // 
            this.labLN.AutoSize = true;
            this.labLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLN.Location = new System.Drawing.Point(28, 168);
            this.labLN.Name = "labLN";
            this.labLN.Size = new System.Drawing.Size(89, 18);
            this.labLN.TabIndex = 3;
            this.labLN.Text = "Last Name";
            // 
            // labEm
            // 
            this.labEm.AutoSize = true;
            this.labEm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEm.Location = new System.Drawing.Point(30, 209);
            this.labEm.Name = "labEm";
            this.labEm.Size = new System.Drawing.Size(50, 18);
            this.labEm.TabIndex = 4;
            this.labEm.Text = "Email";
            // 
            // labPh
            // 
            this.labPh.AutoSize = true;
            this.labPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPh.Location = new System.Drawing.Point(28, 249);
            this.labPh.Name = "labPh";
            this.labPh.Size = new System.Drawing.Size(56, 18);
            this.labPh.TabIndex = 5;
            this.labPh.Text = "Phone";
            // 
            // labDataB
            // 
            this.labDataB.AutoSize = true;
            this.labDataB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDataB.Location = new System.Drawing.Point(28, 289);
            this.labDataB.Name = "labDataB";
            this.labDataB.Size = new System.Drawing.Size(103, 18);
            this.labDataB.TabIndex = 6;
            this.labDataB.Text = "Data of Birth";
            // 
            // labCountry
            // 
            this.labCountry.AutoSize = true;
            this.labCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountry.Location = new System.Drawing.Point(28, 341);
            this.labCountry.Name = "labCountry";
            this.labCountry.Size = new System.Drawing.Size(72, 18);
            this.labCountry.TabIndex = 7;
            this.labCountry.Text = "Country ";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAddress.Location = new System.Drawing.Point(28, 396);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(69, 18);
            this.labAddress.TabIndex = 8;
            this.labAddress.Text = "Address";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 289);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 383);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 65);
            this.textBox1.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(400, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(513, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ContactIDLab
            // 
            this.ContactIDLab.AutoSize = true;
            this.ContactIDLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactIDLab.Location = new System.Drawing.Point(148, 87);
            this.ContactIDLab.Name = "ContactIDLab";
            this.ContactIDLab.Size = new System.Drawing.Size(35, 18);
            this.ContactIDLab.TabIndex = 14;
            this.ContactIDLab.Text = "???";
            // 
            // txtBfirstN
            // 
            this.txtBfirstN.Location = new System.Drawing.Point(137, 127);
            this.txtBfirstN.Multiline = true;
            this.txtBfirstN.Name = "txtBfirstN";
            this.txtBfirstN.Size = new System.Drawing.Size(134, 21);
            this.txtBfirstN.TabIndex = 15;
            // 
            // txtBLastN
            // 
            this.txtBLastN.Location = new System.Drawing.Point(137, 168);
            this.txtBLastN.Multiline = true;
            this.txtBLastN.Name = "txtBLastN";
            this.txtBLastN.Size = new System.Drawing.Size(134, 18);
            this.txtBLastN.TabIndex = 16;
            // 
            // txtBEmail
            // 
            this.txtBEmail.Location = new System.Drawing.Point(137, 209);
            this.txtBEmail.Multiline = true;
            this.txtBEmail.Name = "txtBEmail";
            this.txtBEmail.Size = new System.Drawing.Size(134, 20);
            this.txtBEmail.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 250);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(134, 20);
            this.txtPhone.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(443, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // llsetimage
            // 
            this.llsetimage.AutoSize = true;
            this.llsetimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llsetimage.Location = new System.Drawing.Point(520, 63);
            this.llsetimage.Name = "llsetimage";
            this.llsetimage.Size = new System.Drawing.Size(68, 16);
            this.llsetimage.TabIndex = 20;
            this.llsetimage.TabStop = true;
            this.llsetimage.Text = "Set Image";
            this.llsetimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llsetimage_LinkClicked);
            // 
            // llremove
            // 
            this.llremove.AutoSize = true;
            this.llremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llremove.Location = new System.Drawing.Point(440, 63);
            this.llremove.Name = "llremove";
            this.llremove.Size = new System.Drawing.Size(59, 16);
            this.llremove.TabIndex = 21;
            this.llremove.TabStop = true;
            this.llremove.Text = "Remove";
            this.llremove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llremove_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 518);
            this.Controls.Add(this.llremove);
            this.Controls.Add(this.llsetimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBEmail);
            this.Controls.Add(this.txtBLastN);
            this.Controls.Add(this.txtBfirstN);
            this.Controls.Add(this.ContactIDLab);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labCountry);
            this.Controls.Add(this.labDataB);
            this.Controls.Add(this.labPh);
            this.Controls.Add(this.labEm);
            this.Controls.Add(this.labLN);
            this.Controls.Add(this.labFN);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labTotel);
            this.Name = "frmAddContacts";
            this.Text = "frmAddContacts";
            this.Load += new System.EventHandler(this.frmAddContacts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTotel;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labFN;
        private System.Windows.Forms.Label labLN;
        private System.Windows.Forms.Label labEm;
        private System.Windows.Forms.Label labPh;
        private System.Windows.Forms.Label labDataB;
        private System.Windows.Forms.Label labCountry;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label ContactIDLab;
        private System.Windows.Forms.TextBox txtBfirstN;
        private System.Windows.Forms.TextBox txtBLastN;
        private System.Windows.Forms.TextBox txtBEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llsetimage;
        private System.Windows.Forms.LinkLabel llremove;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}