namespace P3_4_1204007
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
            this.Lname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teksNama = new System.Windows.Forms.TextBox();
            this.cbJenisKelamin = new System.Windows.Forms.ComboBox();
            this.dtTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal6 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal5 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.BackColor = System.Drawing.Color.Indigo;
            this.Lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Lname.Location = new System.Drawing.Point(162, 83);
            this.Lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(42, 13);
            this.Lname.TabIndex = 0;
            this.Lname.Text = "NAMA";
            this.Lname.Click += new System.EventHandler(this.Lname_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(162, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "JENIS KELAMIN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(162, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TANGGAL LAHIR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // teksNama
            // 
            this.teksNama.Location = new System.Drawing.Point(332, 83);
            this.teksNama.Margin = new System.Windows.Forms.Padding(2);
            this.teksNama.Name = "teksNama";
            this.teksNama.Size = new System.Drawing.Size(199, 20);
            this.teksNama.TabIndex = 3;
            this.teksNama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbJenisKelamin
            // 
            this.cbJenisKelamin.FormattingEnabled = true;
            this.cbJenisKelamin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cbJenisKelamin.Items.AddRange(new object[] {
            "perempuan ",
            "laki laki"});
            this.cbJenisKelamin.Location = new System.Drawing.Point(332, 115);
            this.cbJenisKelamin.Margin = new System.Windows.Forms.Padding(2);
            this.cbJenisKelamin.Name = "cbJenisKelamin";
            this.cbJenisKelamin.Size = new System.Drawing.Size(120, 21);
            this.cbJenisKelamin.TabIndex = 4;
            this.cbJenisKelamin.Text = "--pilih jenis kelamin--";
            this.cbJenisKelamin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtTanggalLahir
            // 
            this.dtTanggalLahir.Location = new System.Drawing.Point(332, 151);
            this.dtTanggalLahir.Margin = new System.Windows.Forms.Padding(2);
            this.dtTanggalLahir.Name = "dtTanggalLahir";
            this.dtTanggalLahir.Size = new System.Drawing.Size(199, 20);
            this.dtTanggalLahir.TabIndex = 5;
            this.dtTanggalLahir.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Location = new System.Drawing.Point(72, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(208, 146);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PILIHAN KELAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(4, 24);
            this.cbBiola.Margin = new System.Windows.Forms.Padding(2);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(54, 17);
            this.cbBiola.TabIndex = 14;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            this.cbBiola.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(4, 66);
            this.cbGitar.Margin = new System.Windows.Forms.Padding(2);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(53, 17);
            this.cbGitar.TabIndex = 15;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            this.cbGitar.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(4, 106);
            this.cbSaxophone.Margin = new System.Windows.Forms.Padding(2);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(89, 17);
            this.cbSaxophone.TabIndex = 16;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            this.cbSaxophone.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(123, 106);
            this.cbVokal.Margin = new System.Windows.Forms.Padding(2);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(58, 17);
            this.cbVokal.TabIndex = 19;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            this.cbVokal.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(123, 24);
            this.cbPiano.Margin = new System.Windows.Forms.Padding(2);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(58, 17);
            this.cbPiano.TabIndex = 17;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            this.cbPiano.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(123, 66);
            this.cbDrum.Margin = new System.Windows.Forms.Padding(2);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(55, 17);
            this.cbDrum.TabIndex = 18;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            this.cbDrum.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Indigo;
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal6);
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(301, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(330, 146);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PILIHAN JADWAL";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(4, 24);
            this.rbJadwal1.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(133, 17);
            this.rbJadwal1.TabIndex = 8;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin, 14.00-16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            this.rbJadwal1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(4, 66);
            this.rbJadwal2.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(139, 17);
            this.rbJadwal2.TabIndex = 9;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa, 14.00-16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            this.rbJadwal2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(4, 106);
            this.rbJadwal3.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(131, 17);
            this.rbJadwal3.TabIndex = 10;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Rabu, 09.00-11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            this.rbJadwal3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbJadwal6
            // 
            this.rbJadwal6.AutoSize = true;
            this.rbJadwal6.Location = new System.Drawing.Point(145, 105);
            this.rbJadwal6.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal6.Name = "rbJadwal6";
            this.rbJadwal6.Size = new System.Drawing.Size(179, 17);
            this.rbJadwal6.TabIndex = 13;
            this.rbJadwal6.TabStop = true;
            this.rbJadwal6.Text = "Sabtu & Minggu 13.00-17.00";
            this.rbJadwal6.UseVisualStyleBackColor = true;
            this.rbJadwal6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(145, 24);
            this.rbJadwal4.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(134, 17);
            this.rbJadwal4.TabIndex = 11;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Kamis, 09.00-11.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            this.rbJadwal4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // rbJadwal5
            // 
            this.rbJadwal5.AutoSize = true;
            this.rbJadwal5.Location = new System.Drawing.Point(145, 66);
            this.rbJadwal5.Margin = new System.Windows.Forms.Padding(2);
            this.rbJadwal5.Name = "rbJadwal5";
            this.rbJadwal5.Size = new System.Drawing.Size(134, 17);
            this.rbJadwal5.TabIndex = 12;
            this.rbJadwal5.TabStop = true;
            this.rbJadwal5.Text = "Jumat, 09.00-11.00";
            this.rbJadwal5.UseVisualStyleBackColor = true;
            this.rbJadwal5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 19);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Tampilkan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 21;
            this.button2.Text = "&Selesai";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Indigo;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(262, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "FORM PENDAFTARAN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTanggalLahir);
            this.Controls.Add(this.cbJenisKelamin);
            this.Controls.Add(this.teksNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lname);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Astra Music School";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksNama;
        private System.Windows.Forms.ComboBox cbJenisKelamin;
        private System.Windows.Forms.DateTimePicker dtTanggalLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal5;
        private System.Windows.Forms.RadioButton rbJadwal6;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}

