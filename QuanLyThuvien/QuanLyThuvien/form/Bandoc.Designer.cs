namespace QuanLyThuvien.form
{
    partial class Bandoc
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
            this.dgvbandoc = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txttenbd = new System.Windows.Forms.TextBox();
            this.txtmabd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bandocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new QuanLyThuvien.QLTVDataSet();
            this.bandocTableAdapter = new QuanLyThuvien.QLTVDataSetTableAdapters.BandocTableAdapter();
            this.cmbGT = new System.Windows.Forms.ComboBox();
            this.dtpbandoc = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNHH = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbandoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvbandoc
            // 
            this.dgvbandoc.AllowUserToAddRows = false;
            this.dgvbandoc.AllowUserToDeleteRows = false;
            this.dgvbandoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbandoc.Location = new System.Drawing.Point(15, 261);
            this.dgvbandoc.Name = "dgvbandoc";
            this.dgvbandoc.ReadOnly = true;
            this.dgvbandoc.Size = new System.Drawing.Size(653, 172);
            this.dgvbandoc.TabIndex = 5;
            this.dgvbandoc.SelectionChanged += new System.EventHandler(this.dgvbandoc_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên BD";
            // 
            // txttenbd
            // 
            this.txttenbd.Location = new System.Drawing.Point(73, 47);
            this.txttenbd.Name = "txttenbd";
            this.txttenbd.ReadOnly = true;
            this.txttenbd.Size = new System.Drawing.Size(397, 20);
            this.txttenbd.TabIndex = 15;
            // 
            // txtmabd
            // 
            this.txtmabd.Location = new System.Drawing.Point(73, 12);
            this.txtmabd.Name = "txtmabd";
            this.txtmabd.ReadOnly = true;
            this.txtmabd.Size = new System.Drawing.Size(397, 20);
            this.txtmabd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "MaBD";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(11, 232);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(202, 232);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(106, 232);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(298, 232);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 21;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(379, 232);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 22;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(73, 131);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.ReadOnly = true;
            this.txtdiachi.Size = new System.Drawing.Size(397, 20);
            this.txtdiachi.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Địa chỉ";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(73, 166);
            this.txtemail.Name = "txtemail";
            this.txtemail.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(397, 20);
            this.txtemail.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email";
            // 
            // bandocBindingSource
            // 
            this.bandocBindingSource.DataMember = "Bandoc";
            this.bandocBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bandocTableAdapter
            // 
            this.bandocTableAdapter.ClearBeforeFill = true;
            // 
            // cmbGT
            // 
            this.cmbGT.FormattingEnabled = true;
            this.cmbGT.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGT.Location = new System.Drawing.Point(72, 100);
            this.cmbGT.Name = "cmbGT";
            this.cmbGT.Size = new System.Drawing.Size(221, 21);
            this.cmbGT.TabIndex = 35;
            // 
            // dtpbandoc
            // 
            this.dtpbandoc.Location = new System.Drawing.Point(72, 73);
            this.dtpbandoc.Name = "dtpbandoc";
            this.dtpbandoc.Size = new System.Drawing.Size(221, 20);
            this.dtpbandoc.TabIndex = 34;
            this.dtpbandoc.ValueChanged += new System.EventHandler(this.dtpbandoc_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giới tính";
            // 
            // dtpNHH
            // 
            this.dtpNHH.Location = new System.Drawing.Point(72, 202);
            this.dtpNHH.Name = "dtpNHH";
            this.dtpNHH.Size = new System.Drawing.Size(221, 20);
            this.dtpNHH.TabIndex = 36;
            this.dtpNHH.ValueChanged += new System.EventHandler(this.dtpNHH_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-9, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ngày Hết Hạn";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Bandoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 428);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpNHH);
            this.Controls.Add(this.cmbGT);
            this.Controls.Add(this.dtpbandoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtmabd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttenbd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvbandoc);
            this.Name = "Bandoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin bạn đọc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bandoc_FormClosed);
            this.Load += new System.EventHandler(this.Bandoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbandoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbandoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenbd;
        private System.Windows.Forms.TextBox txtmabd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource bandocBindingSource;
        private QLTVDataSetTableAdapters.BandocTableAdapter bandocTableAdapter;
        private System.Windows.Forms.ComboBox cmbGT;
        private System.Windows.Forms.DateTimePicker dtpbandoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNHH;
        private System.Windows.Forms.Label label7;
    }
}