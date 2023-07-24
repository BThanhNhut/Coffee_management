namespace GUI
{
    partial class frm_ThemBan
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
            this.txt_tenban = new System.Windows.Forms.TextBox();
            this.btn_themban = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm bàn";
            // 
            // txt_tenban
            // 
            this.txt_tenban.Location = new System.Drawing.Point(116, 73);
            this.txt_tenban.Multiline = true;
            this.txt_tenban.Name = "txt_tenban";
            this.txt_tenban.Size = new System.Drawing.Size(188, 25);
            this.txt_tenban.TabIndex = 1;
            // 
            // btn_themban
            // 
            this.btn_themban.Location = new System.Drawing.Point(116, 129);
            this.btn_themban.Name = "btn_themban";
            this.btn_themban.Size = new System.Drawing.Size(91, 29);
            this.btn_themban.TabIndex = 2;
            this.btn_themban.Text = "Thêm";
            this.btn_themban.UseVisualStyleBackColor = true;
            this.btn_themban.Click += new System.EventHandler(this.btn_themban_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bàn";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(213, 129);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(91, 29);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_ThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 173);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_themban);
            this.Controls.Add(this.txt_tenban);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ThemBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm bàn ăn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenban;
        private System.Windows.Forms.Button btn_themban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thoat;
    }
}