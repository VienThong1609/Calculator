namespace Calculator
{
    partial class TinhToan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbKq = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKq
            // 
            this.lbKq.AutoSize = true;
            this.lbKq.Location = new System.Drawing.Point(153, 283);
            this.lbKq.Name = "lbKq";
            this.lbKq.Size = new System.Drawing.Size(76, 25);
            this.lbKq.TabIndex = 1;
            this.lbKq.Text = "Kết quả:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(153, 213);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(52, 25);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Số B:";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(153, 138);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(54, 25);
            this.lbA.TabIndex = 3;
            this.lbA.Text = "Số A:";
            this.lbA.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(283, 138);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(339, 31);
            this.txtA.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(283, 213);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(339, 31);
            this.txtB.TabIndex = 5;
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(283, 277);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(339, 31);
            this.txtKq.TabIndex = 6;
            // 
            // btCong
            // 
            this.btCong.Location = new System.Drawing.Point(352, 352);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(112, 61);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // TinhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbKq);
            this.Controls.Add(this.label1);
            this.Name = "TinhToan";
            this.Text = "Tính Toán";
            this.Load += new System.EventHandler(this.TinhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbKq;
        private Label lbB;
        private Label lbA;
        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtKq;
        private Button btCong;
    }
}