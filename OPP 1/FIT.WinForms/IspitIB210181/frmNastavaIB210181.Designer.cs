namespace FIT.WinForms.IspitIB210181
{
    partial class frmNastavaIB210181
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
            lblNastava = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnDodaj = new Button();
            cmbPredmet = new ComboBox();
            cmbDan = new ComboBox();
            dgvNastava = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Dan = new DataGridViewTextBoxColumn();
            Vrijeme = new DataGridViewTextBoxColumn();
            cmbVrijeme = new ComboBox();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvNastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // lblNastava
            // 
            lblNastava.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblNastava.Location = new Point(12, 22);
            lblNastava.Name = "lblNastava";
            lblNastava.Size = new Size(403, 61);
            lblNastava.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Predmet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 135);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 0;
            label3.Text = "Dan:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 135);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Vrijeme:";
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(582, 157);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(83, 23);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // cmbPredmet
            // 
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(12, 157);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(211, 23);
            cmbPredmet.TabIndex = 2;
            // 
            // cmbDan
            // 
            cmbDan.FormattingEnabled = true;
            cmbDan.Items.AddRange(new object[] { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" });
            cmbDan.Location = new Point(229, 157);
            cmbDan.Name = "cmbDan";
            cmbDan.Size = new Size(167, 23);
            cmbDan.TabIndex = 2;
            // 
            // dgvNastava
            // 
            dgvNastava.AllowUserToAddRows = false;
            dgvNastava.AllowUserToDeleteRows = false;
            dgvNastava.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNastava.Columns.AddRange(new DataGridViewColumn[] { Predmet, Dan, Vrijeme });
            dgvNastava.Location = new Point(12, 186);
            dgvNastava.Name = "dgvNastava";
            dgvNastava.ReadOnly = true;
            dgvNastava.RowTemplate.Height = 25;
            dgvNastava.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNastava.Size = new Size(652, 252);
            dgvNastava.TabIndex = 4;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Dan
            // 
            Dan.DataPropertyName = "Dan";
            Dan.HeaderText = "Dan";
            Dan.Name = "Dan";
            Dan.ReadOnly = true;
            // 
            // Vrijeme
            // 
            Vrijeme.DataPropertyName = "Vrijeme";
            Vrijeme.HeaderText = "Vrijeme";
            Vrijeme.Name = "Vrijeme";
            Vrijeme.ReadOnly = true;
            // 
            // cmbVrijeme
            // 
            cmbVrijeme.FormattingEnabled = true;
            cmbVrijeme.Items.AddRange(new object[] { "08 - 10", "10 - 12", "12 - 14" });
            cmbVrijeme.Location = new Point(400, 157);
            cmbVrijeme.Name = "cmbVrijeme";
            cmbVrijeme.Size = new Size(167, 23);
            cmbVrijeme.TabIndex = 5;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNastavaIB210181
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(cmbVrijeme);
            Controls.Add(dgvNastava);
            Controls.Add(cmbDan);
            Controls.Add(cmbPredmet);
            Controls.Add(btnDodaj);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNastava);
            Name = "frmNastavaIB210181";
            Text = "Nastava";
            FormClosed += frmNastavaIB210181_FormClosed;
            Load += frmNastavaIB210181_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNastava;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnDodaj;
        private ComboBox cmbPredmet;
        private ComboBox cmbDan;
        private DataGridView dgvNastava;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Dan;
        private DataGridViewTextBoxColumn Vrijeme;
        private ComboBox cmbVrijeme;
        private ErrorProvider err;
    }
}