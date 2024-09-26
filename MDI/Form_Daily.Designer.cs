namespace MDI
{
    partial class Form_Daily
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMA_DL = new System.Windows.Forms.TextBox();
            this.txt_DL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bntThem = new System.Windows.Forms.Button();
            this.bntfix = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bntclear = new System.Windows.Forms.Button();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.bntclose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(68, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thông Tin Đại Lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // txtMA_DL
            // 
            this.txtMA_DL.Location = new System.Drawing.Point(146, 70);
            this.txtMA_DL.Name = "txtMA_DL";
            this.txtMA_DL.Size = new System.Drawing.Size(228, 23);
            this.txtMA_DL.TabIndex = 1;
            // 
            // txt_DL
            // 
            this.txt_DL.Location = new System.Drawing.Point(146, 109);
            this.txt_DL.Name = "txt_DL";
            this.txt_DL.Size = new System.Drawing.Size(228, 23);
            this.txt_DL.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại ";
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(146, 144);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(228, 23);
            this.txtDC.TabIndex = 3;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(146, 183);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(228, 23);
            this.txtSDT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đại lý";
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(5, 241);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(93, 43);
            this.bntThem.TabIndex = 5;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntfix
            // 
            this.bntfix.Location = new System.Drawing.Point(104, 241);
            this.bntfix.Name = "bntfix";
            this.bntfix.Size = new System.Drawing.Size(93, 43);
            this.bntfix.TabIndex = 6;
            this.bntfix.Text = "sửa";
            this.bntfix.UseVisualStyleBackColor = true;
            this.bntfix.Click += new System.EventHandler(this.bntfix_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 43);
            this.button3.TabIndex = 9;
            this.button3.Text = "tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntclear
            // 
            this.bntclear.Location = new System.Drawing.Point(203, 241);
            this.bntclear.Name = "bntclear";
            this.bntclear.Size = new System.Drawing.Size(93, 43);
            this.bntclear.TabIndex = 7;
            this.bntclear.Text = "xoá";
            this.bntclear.UseVisualStyleBackColor = true;
            this.bntclear.Click += new System.EventHandler(this.bntclear_Click_1);
            // 
            // dgvDaily
            // 
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.Location = new System.Drawing.Point(428, 12);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.RowTemplate.Height = 25;
            this.dgvDaily.Size = new System.Drawing.Size(596, 307);
            this.dgvDaily.TabIndex = 12;
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(302, 241);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(93, 43);
            this.bntclose.TabIndex = 10;
            this.bntclose.Text = "thoát";
            this.bntclose.UseVisualStyleBackColor = true;
            this.bntclose.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 23);
            this.textBox1.TabIndex = 4;
            // 
            // Form_Daily
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 450);
            this.Controls.Add(this.dgvDaily);
            this.Controls.Add(this.bntclose);
            this.Controls.Add(this.bntclear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntfix);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txt_DL);
            this.Controls.Add(this.txtMA_DL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form_Daily";
            this.Text = "Thoát";
            this.Load += new System.EventHandler(this.Form_Daily_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtMA_DL;
        private TextBox txt_DL;
        private Label label5;
        private TextBox txtDC;
        private TextBox txtSDT;
        private Label label2;
        private Button bntThem;
        private Button bntfix;
        private Button button3;
        private Button bntclear;
        private DataGridView dgvDaily;
        private Button bntclose;
        private TextBox textBox1;
    }
}