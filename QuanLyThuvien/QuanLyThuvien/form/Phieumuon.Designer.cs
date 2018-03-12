namespace QuanLyThuvien.form
{
    partial class Phieumuon
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
            this.dgvphieumuon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvphieumuon
            // 
            this.dgvphieumuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieumuon.Location = new System.Drawing.Point(-2, 191);
            this.dgvphieumuon.Name = "dgvphieumuon";
            this.dgvphieumuon.Size = new System.Drawing.Size(291, 236);
            this.dgvphieumuon.TabIndex = 0;
            this.dgvphieumuon.SelectionChanged += new System.EventHandler(this.dgvphieumuon_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã BD";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(69, 15);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(220, 20);
            this.txtma.TabIndex = 5;
            this.txtma.TextChanged += new System.EventHandler(this.txtsophieu_TextChanged);
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(69, 61);
            this.txtsp.Name = "txtsp";
            this.txtsp.ReadOnly = true;
            this.txtsp.Size = new System.Drawing.Size(220, 20);
            this.txtsp.TabIndex = 6;
            this.txtsp.TextChanged += new System.EventHandler(this.txtmabd_TextChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(12, 98);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(111, 98);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(214, 98);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(51, 127);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 49);
            this.btnluu.TabIndex = 22;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(155, 127);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(100, 49);
            this.btnhuy.TabIndex = 23;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // Phieumuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 429);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtsp);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvphieumuon);
            this.Name = "Phieumuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu mượn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Phieumuon_FormClosed);
            this.Load += new System.EventHandler(this.Phieumuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieumuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvphieumuon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
    }
}