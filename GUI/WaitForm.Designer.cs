namespace GUI
{
    partial class frm_WaitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.processbar = new System.Windows.Forms.Panel();
            this.processbartime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(57)))));
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(155, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vui lòng chờ trong giây lát.....";
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.processbar);
            this.toppanel.Location = new System.Drawing.Point(51, 289);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(600, 22);
            this.toppanel.TabIndex = 3;
            // 
            // processbar
            // 
            this.processbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(145)))));
            this.processbar.Location = new System.Drawing.Point(1, 1);
            this.processbar.Name = "processbar";
            this.processbar.Size = new System.Drawing.Size(10, 20);
            this.processbar.TabIndex = 4;
            // 
            // processbartime
            // 
            this.processbartime.Interval = 10;
            this.processbartime.Tick += new System.EventHandler(this.processbartime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(57)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.gif2;
            this.pictureBox1.InitialImage = global::GUI.Properties.Resources.gif1;
            this.pictureBox1.Location = new System.Drawing.Point(207, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frm_WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(96)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(687, 371);
            this.ControlBox = false;
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WaitForm";
            this.Load += new System.EventHandler(this.frm_WaitForm_Load);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel processbar;
        private System.Windows.Forms.Timer processbartime;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}