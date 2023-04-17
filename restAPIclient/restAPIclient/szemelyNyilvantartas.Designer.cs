namespace restAPIclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb1ID = new System.Windows.Forms.TextBox();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnBelep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFnev = new System.Windows.Forms.TextBox();
            this.tb4Eletkor = new System.Windows.Forms.TextBox();
            this.tb3Keresztnev = new System.Windows.Forms.TextBox();
            this.tb2Vezeteknev = new System.Windows.Forms.TextBox();
            this.btnModosit = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnLekerdez = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb5Lakhely = new System.Windows.Forms.TextBox();
            this.btnUrites = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Keresztnév";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Életkor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Vezetéknév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "ID";
            // 
            // tb1ID
            // 
            this.tb1ID.BackColor = System.Drawing.SystemColors.Control;
            this.tb1ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb1ID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tb1ID.Location = new System.Drawing.Point(393, 255);
            this.tb1ID.Name = "tb1ID";
            this.tb1ID.ReadOnly = true;
            this.tb1ID.Size = new System.Drawing.Size(57, 31);
            this.tb1ID.TabIndex = 42;
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKivalaszt.Location = new System.Drawing.Point(281, 365);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(106, 40);
            this.btnKivalaszt.TabIndex = 41;
            this.btnKivalaszt.Text = "Kiválaszt >>";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.btnKivalaszt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Jelszó";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Felhasználónév";
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(309, 105);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '*';
            this.tbJelszo.Size = new System.Drawing.Size(100, 20);
            this.tbJelszo.TabIndex = 38;
            // 
            // btnBelep
            // 
            this.btnBelep.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBelep.Location = new System.Drawing.Point(309, 131);
            this.btnBelep.Name = "btnBelep";
            this.btnBelep.Size = new System.Drawing.Size(100, 35);
            this.btnBelep.TabIndex = 37;
            this.btnBelep.Text = "Belépés";
            this.btnBelep.UseVisualStyleBackColor = true;
            this.btnBelep.Click += new System.EventHandler(this.btnBelep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Belépés:";
            // 
            // tbFnev
            // 
            this.tbFnev.Location = new System.Drawing.Point(309, 79);
            this.tbFnev.Name = "tbFnev";
            this.tbFnev.Size = new System.Drawing.Size(100, 20);
            this.tbFnev.TabIndex = 35;
            // 
            // tb4Eletkor
            // 
            this.tb4Eletkor.Location = new System.Drawing.Point(393, 437);
            this.tb4Eletkor.Name = "tb4Eletkor";
            this.tb4Eletkor.Size = new System.Drawing.Size(100, 20);
            this.tb4Eletkor.TabIndex = 34;
            // 
            // tb3Keresztnev
            // 
            this.tb3Keresztnev.Location = new System.Drawing.Point(393, 381);
            this.tb3Keresztnev.Name = "tb3Keresztnev";
            this.tb3Keresztnev.Size = new System.Drawing.Size(100, 20);
            this.tb3Keresztnev.TabIndex = 33;
            // 
            // tb2Vezeteknev
            // 
            this.tb2Vezeteknev.Location = new System.Drawing.Point(393, 316);
            this.tb2Vezeteknev.Name = "tb2Vezeteknev";
            this.tb2Vezeteknev.Size = new System.Drawing.Size(100, 20);
            this.tb2Vezeteknev.TabIndex = 32;
            // 
            // btnModosit
            // 
            this.btnModosit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModosit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnModosit.Location = new System.Drawing.Point(534, 369);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(100, 40);
            this.btnModosit.TabIndex = 30;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTorol.ForeColor = System.Drawing.Color.Red;
            this.btnTorol.Location = new System.Drawing.Point(534, 425);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(100, 40);
            this.btnTorol.TabIndex = 29;
            this.btnTorol.Text = "Törlés";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozzaad.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHozzaad.Location = new System.Drawing.Point(534, 316);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(100, 40);
            this.btnHozzaad.TabIndex = 28;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(67, 255);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 264);
            this.listBox1.TabIndex = 27;
            // 
            // btnLekerdez
            // 
            this.btnLekerdez.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLekerdez.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnLekerdez.Location = new System.Drawing.Point(119, 209);
            this.btnLekerdez.Name = "btnLekerdez";
            this.btnLekerdez.Size = new System.Drawing.Size(100, 40);
            this.btnLekerdez.TabIndex = 24;
            this.btnLekerdez.Text = "Lekérdezés";
            this.btnLekerdez.UseVisualStyleBackColor = true;
            this.btnLekerdez.Click += new System.EventHandler(this.btnLekerdez_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Néhány funkció csak bejelelentkezés után érhető el";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(390, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Lakhely";
            // 
            // tb5Lakhely
            // 
            this.tb5Lakhely.Location = new System.Drawing.Point(393, 491);
            this.tb5Lakhely.Name = "tb5Lakhely";
            this.tb5Lakhely.Size = new System.Drawing.Size(100, 20);
            this.tb5Lakhely.TabIndex = 48;
            // 
            // btnUrites
            // 
            this.btnUrites.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUrites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUrites.Location = new System.Drawing.Point(534, 479);
            this.btnUrites.Name = "btnUrites";
            this.btnUrites.Size = new System.Drawing.Size(100, 50);
            this.btnUrites.TabIndex = 50;
            this.btnUrites.Text = "Mezők ürítése";
            this.btnUrites.UseVisualStyleBackColor = true;
            this.btnUrites.Click += new System.EventHandler(this.btnUrites_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 572);
            this.Controls.Add(this.btnUrites);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb5Lakhely);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb1ID);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.btnBelep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFnev);
            this.Controls.Add(this.tb4Eletkor);
            this.Controls.Add(this.tb3Keresztnev);
            this.Controls.Add(this.tb2Vezeteknev);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLekerdez);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Személy nyilvántartás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb1ID;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnBelep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFnev;
        private System.Windows.Forms.TextBox tb4Eletkor;
        private System.Windows.Forms.TextBox tb3Keresztnev;
        private System.Windows.Forms.TextBox tb2Vezeteknev;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnLekerdez;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb5Lakhely;
        private System.Windows.Forms.Button btnUrites;
    }
}

