namespace Abtrix
{
    partial class Calculadora_Juros_Compostos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora_Juros_Compostos));
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            radioButton3 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Location = new Point(175, 22);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(136, 42);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 16;
            radioButton1.Text = "Mensal";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(75, 16);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Anual";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Square721 BT", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(403, 84);
            label1.TabIndex = 0;
            label1.Text = "Calculadora de Juros \r\nCompostos";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 155);
            label3.Name = "label3";
            label3.Size = new Size(106, 22);
            label3.TabIndex = 2;
            label3.Text = "Valor Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 13);
            label4.Name = "label4";
            label4.Size = new Size(56, 22);
            label4.TabIndex = 3;
            label4.Text = "Taxa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 229);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 4;
            label5.Text = "Período";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(15, 90);
            label6.Name = "label6";
            label6.Size = new Size(130, 22);
            label6.TabIndex = 5;
            label6.Text = "Aporte Mensal";
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Swis721 BlkCn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(571, 299);
            button2.Name = "button2";
            button2.Size = new Size(217, 49);
            button2.TabIndex = 9;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button_Calcular;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 23);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(15, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(15, 254);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(158, 23);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(78, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(58, 19);
            radioButton3.TabIndex = 19;
            radioButton3.Text = "Meses";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(175, 237);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(142, 48);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(16, 22);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(52, 19);
            radioButton5.TabIndex = 20;
            radioButton5.TabStop = true;
            radioButton5.Text = "Anos";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 344);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 23;
            label2.Text = "Total Investido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 344);
            label8.Name = "label8";
            label8.Size = new Size(99, 22);
            label8.TabIndex = 22;
            label8.Text = "Valor Total";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Swis721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(380, 344);
            label9.Name = "label9";
            label9.Size = new Size(129, 22);
            label9.TabIndex = 26;
            label9.Text = "Total de Juros";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 381);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(164, 35);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(193, 381);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(164, 35);
            richTextBox2.TabIndex = 28;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(380, 381);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(164, 35);
            richTextBox3.TabIndex = 29;
            richTextBox3.Text = "";
            richTextBox3.TextChanged += richTextBox3_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(754, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 30;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(571, 367);
            button1.Name = "button1";
            button1.Size = new Size(217, 49);
            button1.TabIndex = 31;
            button1.Text = "Importar Planilha";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_ImpotarPlanilha;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Calculadora_Juros_Compostos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Calculadora_Juros_Compostos";
            Text = "Calculadora de Juros Compostos                                                                                                                             TiagosCompanny";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private Label label2;
        private Label label8;
        private Label label9;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox1;
    }
}