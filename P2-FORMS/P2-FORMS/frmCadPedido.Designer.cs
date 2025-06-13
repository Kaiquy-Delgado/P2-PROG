namespace P2_FORMS
{
    partial class frmCadPedido
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            listView1 = new ListView();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(591, 87);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "PEDIDO:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(591, 376);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "TOTAL:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 257);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(65, 147);
            button1.Name = "button1";
            button1.Size = new Size(233, 30);
            button1.TabIndex = 5;
            button1.Text = "Buscar Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(689, 432);
            button2.Name = "button2";
            button2.Size = new Size(213, 31);
            button2.TabIndex = 6;
            button2.Text = "Excluir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(689, 485);
            button3.Name = "button3";
            button3.Size = new Size(213, 31);
            button3.TabIndex = 7;
            button3.Text = "Salvar Pedido";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(65, 522);
            button4.Name = "button4";
            button4.Size = new Size(233, 29);
            button4.TabIndex = 8;
            button4.Text = "Adicionar Pedido";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 358);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 28);
            comboBox1.TabIndex = 9;
            // 
            // listView1
            // 
            listView1.Location = new Point(591, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(391, 256);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 87);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 11;
            label1.Text = "CPF do Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 234);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 12;
            label4.Text = "Codigo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 335);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 13;
            label5.Text = "Selecione o Produto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 417);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 14;
            label6.Text = "Quantidade";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 440);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 27);
            textBox3.TabIndex = 15;
            // 
            // frmCadPedido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 605);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmCadPedido";
            Text = "Form2";
            Load += frmCadPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
        private ListView listView1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
    }
}