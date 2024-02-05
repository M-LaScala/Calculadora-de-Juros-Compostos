namespace CalculadoraJurosCompostos
{
    partial class Calculadora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox8 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Patrimonio inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 21);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 3;
            label2.Text = "Investimento mensal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 21);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 5;
            label3.Text = "Quantos meses ira aplicar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 21);
            label4.Name = "label4";
            label4.Size = new Size(223, 15);
            label4.TabIndex = 6;
            label4.Text = "Rendimento percentual esperado ao mês";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(703, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 135);
            label5.Name = "label5";
            label5.Size = new Size(136, 15);
            label5.TabIndex = 10;
            label5.Text = "Valor ao final do período";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(191, 132);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(195, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 175);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 12;
            label6.Text = "Valor de rendimento";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(191, 172);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(195, 23);
            textBox6.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 95);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 14;
            label7.Text = "Valor investido";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(191, 92);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(195, 23);
            textBox7.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(288, 48);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(448, 48);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 23);
            textBox4.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(689, 48);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(89, 23);
            textBox8.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(689, 21);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 21;
            label8.Text = "Aumento anual";
            // 
            // button2
            // 
            button2.Location = new Point(596, 145);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 22;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 207);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculadora";
            Text = "Calculadora de Juros Compostos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;

        public TextBox textBox1;
        public TextBox textBox2;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox textBox6;
        public TextBox textBox7;
        public TextBox textBox8;

        public Button button1;
        public Button button2;
    }
}