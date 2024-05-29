namespace PoliGest.Forms
{
    partial class formPrinc
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
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            dataGridView1 = new DataGridView();
            dgId = new DataGridViewTextBoxColumn();
            dgName = new DataGridViewTextBoxColumn();
            dgNrBi = new DataGridViewTextBoxColumn();
            dgDataNascimento = new DataGridViewTextBoxColumn();
            dgEstadoCivil = new DataGridViewTextBoxColumn();
            dg_processo = new DataGridViewTextBoxColumn();
            panel6 = new Panel();
            groupBox1 = new GroupBox();
            panel8 = new Panel();
            button5 = new Button();
            groupBox4 = new GroupBox();
            comboBox2 = new ComboBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            groupBox1.SuspendLayout();
            panel8.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 43, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 514);
            panel2.TabIndex = 8;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.FromArgb(231, 62, 96);
            button4.Image = Properties.Resources.icons8_porta_de_cela_de_prisão_48;
            button4.ImageAlign = ContentAlignment.MiddleRight;
            button4.Location = new Point(2, 266);
            button4.Name = "button4";
            button4.Size = new Size(195, 59);
            button4.TabIndex = 17;
            button4.Text = "APREENSÃO";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.FromArgb(231, 62, 96);
            button3.Image = Properties.Resources.icons8_conta_48;
            button3.ImageAlign = ContentAlignment.MiddleRight;
            button3.Location = new Point(2, 201);
            button3.Name = "button3";
            button3.Size = new Size(195, 59);
            button3.TabIndex = 16;
            button3.Text = "MULTAS";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.FromArgb(231, 62, 96);
            button2.Image = Properties.Resources.icons8_arrest_48;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(2, 136);
            button2.Name = "button2";
            button2.Size = new Size(195, 59);
            button2.TabIndex = 15;
            button2.Text = "DETENÇÃO";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.FromArgb(231, 62, 96);
            button1.Image = Properties.Resources.icons8_perdido_48;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(2, 71);
            button1.Name = "button1";
            button1.Size = new Size(195, 59);
            button1.TabIndex = 14;
            button1.Text = "DESAPARECIDOS";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 440);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 72);
            panel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(231, 62, 96);
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 59);
            label3.TabIndex = 9;
            label3.Text = "GESTÃO PRISIONAL";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Transparent;
            statusStrip1.Location = new Point(200, 492);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1123, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1123, 492);
            panel1.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(1123, 432);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(dataGridView1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 135);
            panel7.Name = "panel7";
            panel7.Size = new Size(1121, 295);
            panel7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgId, dgName, dgNrBi, dgDataNascimento, dgEstadoCivil, dg_processo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1121, 295);
            dataGridView1.TabIndex = 0;
            // 
            // dgId
            // 
            dgId.DataPropertyName = "id";
            dgId.HeaderText = "ID";
            dgId.Name = "dgId";
            dgId.ReadOnly = true;
            dgId.Visible = false;
            // 
            // dgName
            // 
            dgName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgName.DataPropertyName = "nome";
            dgName.HeaderText = "Nome";
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            // 
            // dgNrBi
            // 
            dgNrBi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgNrBi.DataPropertyName = "nr_bi";
            dgNrBi.HeaderText = "Número do BI";
            dgNrBi.Name = "dgNrBi";
            dgNrBi.ReadOnly = true;
            // 
            // dgDataNascimento
            // 
            dgDataNascimento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgDataNascimento.DataPropertyName = "dt_nasc";
            dgDataNascimento.HeaderText = "Data Nascimento";
            dgDataNascimento.Name = "dgDataNascimento";
            dgDataNascimento.ReadOnly = true;
            // 
            // dgEstadoCivil
            // 
            dgEstadoCivil.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgEstadoCivil.DataPropertyName = "estado_civil";
            dgEstadoCivil.HeaderText = "Estado Civil";
            dgEstadoCivil.Name = "dgEstadoCivil";
            dgEstadoCivil.ReadOnly = true;
            // 
            // dg_processo
            // 
            dg_processo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dg_processo.DataPropertyName = "processo";
            dg_processo.HeaderText = "Processo";
            dg_processo.Name = "dg_processo";
            dg_processo.ReadOnly = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(groupBox1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1121, 135);
            panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel8);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(5, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1113, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.Controls.Add(button5);
            panel8.Controls.Add(groupBox4);
            panel8.Controls.Add(groupBox3);
            panel8.Controls.Add(groupBox2);
            panel8.Location = new Point(14, 15);
            panel8.Name = "panel8";
            panel8.Size = new Size(1089, 109);
            panel8.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(937, 27);
            button5.Name = "button5";
            button5.Size = new Size(124, 44);
            button5.TabIndex = 7;
            button5.Text = "Buscar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(comboBox2);
            groupBox4.Font = new Font("Segoe UI", 9F);
            groupBox4.Location = new Point(622, 6);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(284, 98);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tipo de operação";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 11F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(27, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 28);
            comboBox2.TabIndex = 2;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Font = new Font("Segoe UI", 9F);
            groupBox3.Location = new Point(314, 6);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(293, 98);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filtrar por data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 66);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Fim:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(59, 60);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(185, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 36);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Início:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(59, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(185, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 98);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Termo de busca";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 34);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 2;
            label7.Text = "Termo:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1123, 60);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(231, 62, 96);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 43, 61);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1121, 58);
            label1.TabIndex = 0;
            label1.Text = "Informações do sistema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // formPrinc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 215, 225);
            ClientSize = new Size(1323, 514);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(panel2);
            Name = "formPrinc";
            Text = "Gestão Prisional";
            WindowState = FormWindowState.Maximized;
            Load += formPrinc_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private Panel panel3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Panel panel8;
        private Button button5;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private GroupBox groupBox3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox2;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn dgId;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgNrBi;
        private DataGridViewTextBoxColumn dgDataNascimento;
        private DataGridViewTextBoxColumn dgEstadoCivil;
        private DataGridViewTextBoxColumn dg_processo;
    }
}