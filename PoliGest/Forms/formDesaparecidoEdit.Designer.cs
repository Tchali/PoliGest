namespace PoliGest.Forms
{
    partial class formDesaparecidoEdit
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel_pessoal = new Panel();
            label6 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            panel_geral = new Panel();
            comboBox1 = new ComboBox();
            label8 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            textBox5 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label9 = new Label();
            label11 = new Label();
            textBox8 = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            bt_atualizar = new Button();
            panel3 = new Panel();
            bt_editar = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel_pessoal.SuspendLayout();
            tabPage2.SuspendLayout();
            panel_geral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 518);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(882, 426);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel_pessoal);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel_pessoal
            // 
            panel_pessoal.Controls.Add(label6);
            panel_pessoal.Controls.Add(textBox3);
            panel_pessoal.Controls.Add(dateTimePicker1);
            panel_pessoal.Controls.Add(textBox4);
            panel_pessoal.Controls.Add(label5);
            panel_pessoal.Controls.Add(label4);
            panel_pessoal.Controls.Add(label2);
            panel_pessoal.Controls.Add(textBox2);
            panel_pessoal.Controls.Add(label1);
            panel_pessoal.Controls.Add(textBox1);
            panel_pessoal.Dock = DockStyle.Fill;
            panel_pessoal.Enabled = false;
            panel_pessoal.Location = new Point(3, 3);
            panel_pessoal.Name = "panel_pessoal";
            panel_pessoal.Size = new Size(868, 392);
            panel_pessoal.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(69, 244);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 36;
            label6.Text = "Num BI:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(140, 241);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(402, 27);
            textBox3.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(140, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(402, 27);
            dateTimePicker1.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(140, 157);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(402, 27);
            textBox4.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(93, 160);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 32;
            label5.Text = "E de:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(41, 201);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 31;
            label4.Text = "Nascido aos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(69, 118);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 30;
            label2.Text = "Filho de:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(140, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 27);
            textBox2.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(81, 76);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 28;
            label1.Text = "Nome:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(140, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 27);
            textBox1.TabIndex = 27;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel_geral);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Geral";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel_geral
            // 
            panel_geral.Controls.Add(comboBox1);
            panel_geral.Controls.Add(label8);
            panel_geral.Controls.Add(button3);
            panel_geral.Controls.Add(pictureBox1);
            panel_geral.Controls.Add(label7);
            panel_geral.Controls.Add(textBox5);
            panel_geral.Controls.Add(dateTimePicker2);
            panel_geral.Controls.Add(label9);
            panel_geral.Controls.Add(label11);
            panel_geral.Controls.Add(textBox8);
            panel_geral.Dock = DockStyle.Fill;
            panel_geral.Enabled = false;
            panel_geral.Location = new Point(3, 3);
            panel_geral.Name = "panel_geral";
            panel_geral.Size = new Size(868, 392);
            panel_geral.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Perdido", "Achado" });
            comboBox1.Location = new Point(160, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(389, 28);
            comboBox1.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(63, 121);
            label8.Name = "label8";
            label8.Size = new Size(91, 20);
            label8.TabIndex = 49;
            label8.Text = "Processo de:";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(517, 51);
            button3.Name = "button3";
            button3.Size = new Size(32, 27);
            button3.TabIndex = 48;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(589, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 180);
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(77, 162);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 46;
            label7.Text = "Descrição:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 11F);
            textBox5.Location = new Point(160, 159);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(389, 203);
            textBox5.TabIndex = 45;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(160, 84);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(389, 27);
            dateTimePicker2.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(110, 87);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 43;
            label9.Text = "Data:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(112, 54);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 42;
            label11.Text = "Foto:";
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 11F);
            textBox8.Location = new Point(160, 51);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(351, 27);
            textBox8.TabIndex = 41;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 43, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(882, 90);
            panel2.TabIndex = 7;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(880, 88);
            label3.TabIndex = 9;
            label3.Text = "Visualizar Perdidos e Achados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_atualizar
            // 
            bt_atualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_atualizar.Enabled = false;
            bt_atualizar.Location = new Point(782, 6);
            bt_atualizar.Name = "bt_atualizar";
            bt_atualizar.Size = new Size(90, 30);
            bt_atualizar.TabIndex = 8;
            bt_atualizar.Text = "Atualizar";
            bt_atualizar.UseVisualStyleBackColor = true;
            bt_atualizar.Click += bt_atualizar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(bt_editar);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(bt_atualizar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 518);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 43);
            panel3.TabIndex = 9;
            // 
            // bt_editar
            // 
            bt_editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bt_editar.Location = new Point(686, 6);
            bt_editar.Name = "bt_editar";
            bt_editar.Size = new Size(90, 30);
            bt_editar.TabIndex = 10;
            bt_editar.Text = "Editar";
            bt_editar.UseVisualStyleBackColor = true;
            bt_editar.Click += button4_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(590, 6);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 9;
            button1.Text = "Canselar";
            button1.UseVisualStyleBackColor = true;
            // 
            // formDesaparecidoEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "formDesaparecidoEdit";
            Text = "formDesaparecido";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel_pessoal.ResumeLayout(false);
            panel_pessoal.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel_geral.ResumeLayout(false);
            panel_geral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt_atualizar;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel_pessoal;
        private Label label6;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private Panel panel_geral;
        private ComboBox comboBox1;
        private Label label8;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label7;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker2;
        private Label label9;
        private Label label11;
        private TextBox textBox8;
        private Button bt_editar;
    }
}