namespace PoliGest.Forms
{
    partial class formDetencao
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
            label10 = new Label();
            cb_estadoCivil = new ComboBox();
            label6 = new Label();
            tx_numBi = new TextBox();
            dt_nascimento = new DateTimePicker();
            tx_mae = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            tx_pai = new TextBox();
            label1 = new Label();
            tx_nome = new TextBox();
            tabPage2 = new TabPage();
            cb_tp_detencao = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            tx_description = new TextBox();
            dt_data = new DateTimePicker();
            label9 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            button2 = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(cb_estadoCivil);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(tx_numBi);
            tabPage1.Controls.Add(dt_nascimento);
            tabPage1.Controls.Add(tx_mae);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(tx_pai);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tx_nome);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(874, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(63, 202);
            label10.Name = "label10";
            label10.Size = new Size(89, 20);
            label10.TabIndex = 30;
            label10.Text = "Estado Civil:";
            // 
            // cb_estadoCivil
            // 
            cb_estadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_estadoCivil.Font = new Font("Segoe UI", 11F);
            cb_estadoCivil.FormattingEnabled = true;
            cb_estadoCivil.Items.AddRange(new object[] { "M", "F" });
            cb_estadoCivil.Location = new Point(158, 198);
            cb_estadoCivil.Name = "cb_estadoCivil";
            cb_estadoCivil.Size = new Size(157, 28);
            cb_estadoCivil.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(87, 284);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 26;
            label6.Text = "Num BI:";
            // 
            // tx_numBi
            // 
            tx_numBi.Font = new Font("Segoe UI", 11F);
            tx_numBi.Location = new Point(158, 281);
            tx_numBi.Name = "tx_numBi";
            tx_numBi.Size = new Size(402, 27);
            tx_numBi.TabIndex = 25;
            // 
            // dt_nascimento
            // 
            dt_nascimento.Font = new Font("Segoe UI", 11F);
            dt_nascimento.Format = DateTimePickerFormat.Short;
            dt_nascimento.Location = new Point(158, 241);
            dt_nascimento.Name = "dt_nascimento";
            dt_nascimento.Size = new Size(402, 27);
            dt_nascimento.TabIndex = 24;
            // 
            // tx_mae
            // 
            tx_mae.Font = new Font("Segoe UI", 11F);
            tx_mae.Location = new Point(158, 156);
            tx_mae.Name = "tx_mae";
            tx_mae.Size = new Size(402, 27);
            tx_mae.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(111, 159);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 22;
            label5.Text = "E de:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(59, 244);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 21;
            label4.Text = "Nascido aos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(87, 117);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 20;
            label2.Text = "Filho de:";
            // 
            // tx_pai
            // 
            tx_pai.Font = new Font("Segoe UI", 11F);
            tx_pai.Location = new Point(158, 114);
            tx_pai.Name = "tx_pai";
            tx_pai.Size = new Size(402, 27);
            tx_pai.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(99, 75);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 18;
            label1.Text = "Nome:";
            // 
            // tx_nome
            // 
            tx_nome.Font = new Font("Segoe UI", 11F);
            tx_nome.Location = new Point(158, 72);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(402, 27);
            tx_nome.TabIndex = 17;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cb_tp_detencao);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tx_description);
            tabPage2.Controls.Add(dt_data);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(874, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Geral";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_tp_detencao
            // 
            cb_tp_detencao.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_tp_detencao.Font = new Font("Segoe UI", 11F);
            cb_tp_detencao.FormattingEnabled = true;
            cb_tp_detencao.Items.AddRange(new object[] { "Perdido", "Achado" });
            cb_tp_detencao.Location = new Point(143, 84);
            cb_tp_detencao.Name = "cb_tp_detencao";
            cb_tp_detencao.Size = new Size(389, 28);
            cb_tp_detencao.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(29, 88);
            label8.Name = "label8";
            label8.Size = new Size(108, 20);
            label8.TabIndex = 39;
            label8.Text = "Tipo detenção:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(60, 129);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 36;
            label7.Text = "Descrição:";
            // 
            // tx_description
            // 
            tx_description.Font = new Font("Segoe UI", 11F);
            tx_description.Location = new Point(143, 126);
            tx_description.Multiline = true;
            tx_description.Name = "tx_description";
            tx_description.Size = new Size(389, 203);
            tx_description.TabIndex = 35;
            // 
            // dt_data
            // 
            dt_data.Font = new Font("Segoe UI", 11F);
            dt_data.Format = DateTimePickerFormat.Short;
            dt_data.Location = new Point(143, 51);
            dt_data.Name = "dt_data";
            dt_data.Size = new Size(389, 27);
            dt_data.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(93, 54);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 31;
            label9.Text = "Data:";
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
            label3.Text = "Dentenção";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(782, 6);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 8;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 518);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 43);
            panel3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(686, 6);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 9;
            button1.Text = "Canselar";
            button1.UseVisualStyleBackColor = true;
            // 
            // formDetencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "formDetencao";
            Text = "formDesaparecido";
            Load += form_Load;
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label6;
        private TextBox tx_numBi;
        private DateTimePicker dt_nascimento;
        private TextBox tx_mae;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox tx_pai;
        private Label label1;
        private TextBox tx_nome;
        private TabPage tabPage2;
        private Label label7;
        private TextBox tx_description;
        private DateTimePicker dt_data;
        private Label label9;
        private ComboBox cb_tp_detencao;
        private Label label8;
        private Label label10;
        private ComboBox cb_estadoCivil;
    }
}