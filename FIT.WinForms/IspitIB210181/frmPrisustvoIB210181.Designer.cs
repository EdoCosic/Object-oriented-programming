namespace FIT.WinForms.IspitIB210181
{
    partial class frmPrisustvoIB210181
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
            components = new System.ComponentModel.Container();
            lblProstorija = new Label();
            lblOd = new Label();
            label2 = new Label();
            lblDo = new Label();
            label1 = new Label();
            label3 = new Label();
            cmbNastava = new ComboBox();
            cmbStudent = new ComboBox();
            btnDodaj = new Button();
            dgvPrisustva = new DataGridView();
            Nastava = new DataGridViewTextBoxColumn();
            Student = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtBroj = new TextBox();
            button1 = new Button();
            label5 = new Label();
            txtInfo = new TextBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblProstorija
            // 
            lblProstorija.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblProstorija.Location = new Point(12, 9);
            lblProstorija.Name = "lblProstorija";
            lblProstorija.Size = new Size(403, 61);
            lblProstorija.TabIndex = 1;
            // 
            // lblOd
            // 
            lblOd.Location = new Point(491, 33);
            lblOd.Name = "lblOd";
            lblOd.Size = new Size(100, 23);
            lblOd.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 33);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 2;
            label2.Text = "/";
            // 
            // lblDo
            // 
            lblDo.Location = new Point(553, 33);
            lblDo.Name = "lblDo";
            lblDo.Size = new Size(38, 15);
            lblDo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 99);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 3;
            label1.Text = "Nastava:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 99);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Student:";
            // 
            // cmbNastava
            // 
            cmbNastava.FormattingEnabled = true;
            cmbNastava.Location = new Point(12, 117);
            cmbNastava.Name = "cmbNastava";
            cmbNastava.Size = new Size(238, 23);
            cmbNastava.TabIndex = 4;
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(256, 117);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(238, 23);
            cmbStudent.TabIndex = 4;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(500, 116);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(91, 23);
            btnDodaj.TabIndex = 5;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvPrisustva
            // 
            dgvPrisustva.AllowUserToAddRows = false;
            dgvPrisustva.AllowUserToDeleteRows = false;
            dgvPrisustva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrisustva.Columns.AddRange(new DataGridViewColumn[] { Nastava, Student });
            dgvPrisustva.Location = new Point(12, 146);
            dgvPrisustva.Name = "dgvPrisustva";
            dgvPrisustva.ReadOnly = true;
            dgvPrisustva.RowTemplate.Height = 25;
            dgvPrisustva.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPrisustva.Size = new Size(579, 180);
            dgvPrisustva.TabIndex = 6;
            // 
            // Nastava
            // 
            Nastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nastava.DataPropertyName = "Nastava";
            Nastava.HeaderText = "Predmet, prostorija, vrijeme";
            Nastava.Name = "Nastava";
            Nastava.ReadOnly = true;
            // 
            // Student
            // 
            Student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Student.DataPropertyName = "Student";
            Student.HeaderText = "Student";
            Student.Name = "Student";
            Student.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtInfo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtBroj);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 239);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 29);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Broj zapisa:";
            // 
            // txtBroj
            // 
            txtBroj.Location = new Point(86, 26);
            txtBroj.Name = "txtBroj";
            txtBroj.Size = new Size(100, 23);
            txtBroj.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(202, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Generisi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 60);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 3;
            label5.Text = "Info:";
            // 
            // txtInfo
            // 
            txtInfo.Location = new Point(14, 78);
            txtInfo.Multiline = true;
            txtInfo.Name = "txtInfo";
            txtInfo.Size = new Size(559, 155);
            txtInfo.TabIndex = 4;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrisustvoIB210181
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 617);
            Controls.Add(groupBox1);
            Controls.Add(dgvPrisustva);
            Controls.Add(btnDodaj);
            Controls.Add(cmbStudent);
            Controls.Add(cmbNastava);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lblDo);
            Controls.Add(label2);
            Controls.Add(lblOd);
            Controls.Add(lblProstorija);
            Name = "frmPrisustvoIB210181";
            Text = "Evidencija nastave";
            Load += frmPrisustvoIB210181_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrisustva).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProstorija;
        private Label lblOd;
        private Label label2;
        private Label lblDo;
        private Label label1;
        private Label label3;
        private ComboBox cmbNastava;
        private ComboBox cmbStudent;
        private Button btnDodaj;
        private DataGridView dgvPrisustva;
        private DataGridViewTextBoxColumn Nastava;
        private DataGridViewTextBoxColumn Student;
        private GroupBox groupBox1;
        private TextBox txtInfo;
        private Label label5;
        private Button button1;
        private TextBox txtBroj;
        private Label label4;
        private ErrorProvider err;
    }
}