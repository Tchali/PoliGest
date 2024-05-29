namespace PoliGest.Forms
{
    partial class formDesaparecido
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
            label3 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            button3 = new Button();
            pic_imgem = new PictureBox();
            label7 = new Label();
            tx_description = new TextBox();
            dt_data = new DateTimePicker();
            label9 = new Label();
            label11 = new Label();
            tx_end_foto = new TextBox();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_imgem).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1047, 88);
            label3.TabIndex = 9;
            label3.Text = "Perdidos e Achados";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 43, 61);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1049, 90);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 494);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 43);
            panel3.TabIndex = 11;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(853, 6);
            button1.Name = "button1";
            button1.Size = new Size(90, 30);
            button1.TabIndex = 11;
            button1.Text = "Canselar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(949, 6);
            button2.Name = "button2";
            button2.Size = new Size(90, 30);
            button2.TabIndex = 10;
            button2.Text = "Confirmar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(pic_imgem);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tx_description);
            tabPage2.Controls.Add(dt_data);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(tx_end_foto);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1041, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Geral";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 11F);
            button3.Location = new Point(499, 55);
            button3.Name = "button3";
            button3.Size = new Size(32, 27);
            button3.TabIndex = 38;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pic_imgem
            // 
            pic_imgem.BorderStyle = BorderStyle.FixedSingle;
            pic_imgem.Location = new Point(571, 55);
            pic_imgem.Name = "pic_imgem";
            pic_imgem.Size = new Size(178, 180);
            pic_imgem.TabIndex = 37;
            pic_imgem.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(62, 130);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 36;
            label7.Text = "Descrição:";
            // 
            // tx_description
            // 
            tx_description.Font = new Font("Segoe UI", 11F);
            tx_description.Location = new Point(142, 124);
            tx_description.Multiline = true;
            tx_description.Name = "tx_description";
            tx_description.Size = new Size(389, 203);
            tx_description.TabIndex = 35;
            // 
            // dt_data
            // 
            dt_data.Font = new Font("Segoe UI", 11F);
            dt_data.Format = DateTimePickerFormat.Short;
            dt_data.Location = new Point(142, 88);
            dt_data.Name = "dt_data";
            dt_data.Size = new Size(389, 27);
            dt_data.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(95, 91);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 31;
            label9.Text = "Data:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F);
            label11.Location = new Point(97, 58);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 28;
            label11.Text = "Foto:";
            // 
            // tx_end_foto
            // 
            tx_end_foto.Font = new Font("Segoe UI", 11F);
            tx_end_foto.Location = new Point(142, 55);
            tx_end_foto.Name = "tx_end_foto";
            tx_end_foto.ReadOnly = true;
            tx_end_foto.Size = new Size(351, 27);
            tx_end_foto.TabIndex = 27;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 537);
            panel1.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 90);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1049, 445);
            tabControl1.TabIndex = 8;
            // 
            // formDesaparecido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 537);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "formDesaparecido";
            Text = "formDetencao";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_imgem).EndInit();
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private TabPage tabPage2;
        private ComboBox comboBox1;
        private Label label8;
        private Button button3;
        private PictureBox pic_imgem;
        private Label label7;
        private TextBox tx_description;
        private DateTimePicker dt_data;
        private Label label9;
        private Label label11;
        private TextBox tx_end_foto;
        private Panel panel1;
        private TabControl tabControl1;
        private Button button1;
        private Button button2;
    }
}