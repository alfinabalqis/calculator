namespace kalkulator
{
    partial class Calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn00 = new System.Windows.Forms.Button();
            this.btnTitik = new System.Windows.Forms.Button();
            this.btnSatu = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHasil);
            this.panel1.Location = new System.Drawing.Point(13, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 75);
            this.panel1.TabIndex = 0;
            // 
            // txtHasil
            // 
            this.txtHasil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasil.Location = new System.Drawing.Point(0, 0);
            this.txtHasil.Multiline = true;
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(326, 75);
            this.txtHasil.TabIndex = 0;
            this.txtHasil.Text = "0";
            this.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnKali);
            this.panel2.Controls.Add(this.btnBagi);
            this.panel2.Controls.Add(this.btnHapus);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn00);
            this.panel2.Controls.Add(this.btnTitik);
            this.panel2.Controls.Add(this.btnSatu);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btnTambah);
            this.panel2.Controls.Add(this.btnKurang);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Location = new System.Drawing.Point(13, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 304);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(251, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_hasil);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(251, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 17;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operator_persen);
            // 
            // btnKali
            // 
            this.btnKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKali.Location = new System.Drawing.Point(251, 5);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(75, 53);
            this.btnKali.TabIndex = 16;
            this.btnKali.Text = "X";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.operator_click);
            // 
            // btnBagi
            // 
            this.btnBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBagi.Location = new System.Drawing.Point(170, 5);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(75, 53);
            this.btnBagi.TabIndex = 15;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.operator_click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(86, 5);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 53);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "DEL";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btn_delete);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(0, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 53);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "C";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btn_hapus);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(0, 245);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 53);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn_click);
            // 
            // btn00
            // 
            this.btn00.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn00.Location = new System.Drawing.Point(85, 245);
            this.btn00.Name = "btn00";
            this.btn00.Size = new System.Drawing.Size(75, 53);
            this.btn00.TabIndex = 11;
            this.btn00.Text = ".";
            this.btn00.UseVisualStyleBackColor = true;
            this.btn00.Click += new System.EventHandler(this.btn_click);
            // 
            // btnTitik
            // 
            this.btnTitik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitik.Location = new System.Drawing.Point(169, 245);
            this.btnTitik.Name = "btnTitik";
            this.btnTitik.Size = new System.Drawing.Size(75, 53);
            this.btnTitik.TabIndex = 12;
            this.btnTitik.Text = "√";
            this.btnTitik.UseVisualStyleBackColor = true;
            this.btnTitik.Click += new System.EventHandler(this.operator_akar);
            // 
            // btnSatu
            // 
            this.btnSatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatu.Location = new System.Drawing.Point(0, 185);
            this.btnSatu.Name = "btnSatu";
            this.btnSatu.Size = new System.Drawing.Size(75, 53);
            this.btnSatu.TabIndex = 6;
            this.btnSatu.Text = "1";
            this.btnSatu.UseVisualStyleBackColor = true;
            this.btnSatu.Click += new System.EventHandler(this.btn_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(85, 185);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 53);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(169, 185);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 53);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(0, 125);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 53);
            this.btn4.TabIndex = 2;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(86, 125);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 53);
            this.btn5.TabIndex = 3;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(170, 125);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 53);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn_click);
            // 
            // btnTambah
            // 
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(251, 126);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 53);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.operator_click);
            // 
            // btnKurang
            // 
            this.btnKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurang.Location = new System.Drawing.Point(251, 66);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(75, 53);
            this.btnKurang.TabIndex = 3;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.operator_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(170, 66);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 53);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(86, 66);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 53);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn_click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(0, 65);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 53);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn_click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(13, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 23);
            this.panel3.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btn_exit);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 443);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn00;
        private System.Windows.Forms.Button btnTitik;
        private System.Windows.Forms.Button btnSatu;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

