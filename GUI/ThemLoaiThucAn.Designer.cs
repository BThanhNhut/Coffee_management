namespace GUI
{
    partial class frm_ThemLoaiThucAn
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_themloaithucan = new System.Windows.Forms.Button();
            this.txt_tenloaithucan = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.Label();
            this.btn_thoat_themloaithucan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(175, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm loại thức ăn";
            // 
            // btn_themloaithucan
            // 
            this.btn_themloaithucan.Location = new System.Drawing.Point(180, 152);
            this.btn_themloaithucan.Name = "btn_themloaithucan";
            this.btn_themloaithucan.Size = new System.Drawing.Size(106, 48);
            this.btn_themloaithucan.TabIndex = 1;
            this.btn_themloaithucan.Text = "Thêm";
            this.btn_themloaithucan.UseVisualStyleBackColor = true;
            this.btn_themloaithucan.Click += new System.EventHandler(this.btn_themloaithucan_Click);
            // 
            // txt_tenloaithucan
            // 
            this.txt_tenloaithucan.Location = new System.Drawing.Point(180, 100);
            this.txt_tenloaithucan.Name = "txt_tenloaithucan";
            this.txt_tenloaithucan.Size = new System.Drawing.Size(235, 22);
            this.txt_tenloaithucan.TabIndex = 2;
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.T.Location = new System.Drawing.Point(61, 97);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(97, 25);
            this.T.TabIndex = 3;
            this.T.Text = "Tên Loại";
            // 
            // btn_thoat_themloaithucan
            // 
            this.btn_thoat_themloaithucan.Location = new System.Drawing.Point(292, 152);
            this.btn_thoat_themloaithucan.Name = "btn_thoat_themloaithucan";
            this.btn_thoat_themloaithucan.Size = new System.Drawing.Size(106, 48);
            this.btn_thoat_themloaithucan.TabIndex = 4;
            this.btn_thoat_themloaithucan.Text = "Thoát";
            this.btn_thoat_themloaithucan.UseVisualStyleBackColor = true;
            this.btn_thoat_themloaithucan.Click += new System.EventHandler(this.btn_thoat_themloaithucan_Click);
            // 
            // frm_ThemLoaiThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(557, 212);
            this.Controls.Add(this.btn_thoat_themloaithucan);
            this.Controls.Add(this.T);
            this.Controls.Add(this.txt_tenloaithucan);
            this.Controls.Add(this.btn_themloaithucan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemLoaiThucAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemLoaiThucAn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_themloaithucan;
        private System.Windows.Forms.TextBox txt_tenloaithucan;
        private System.Windows.Forms.Label T;
        private System.Windows.Forms.Button btn_thoat_themloaithucan;
    }
}