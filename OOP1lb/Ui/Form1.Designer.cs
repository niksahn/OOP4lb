namespace OOP1lb
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label9 = new Label();
            panel1 = new Panel();
            search = new TextBox();
            check = new Button();
            count = new Label();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            textReg = new TextBox();
            textEmail = new TextBox();
            textSquare = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            textInn = new NumericUpDown();
            textServ = new NumericUpDown();
            textHab = new NumericUpDown();
            label8 = new Label();
            textNam = new TextBox();
            panel3 = new Panel();
            button7 = new Button();
            button6 = new Button();
            changingHous = new NumericUpDown();
            changingHab = new NumericUpDown();
            changingServ = new NumericUpDown();
            label20 = new Label();
            button4 = new Button();
            changing_number_hex = new Label();
            label18 = new Label();
            changing_number = new Label();
            label17 = new Label();
            changing_name = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            changingSquare = new TextBox();
            changingEmail = new TextBox();
            changingReg = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textInn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textServ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textHab).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)changingHous).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changingHab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)changingServ).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 4);
            label9.Name = "label9";
            label9.Size = new Size(194, 20);
            label9.TabIndex = 1;
            label9.Text = "Поиск по номеру в списке";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(search);
            panel1.Controls.Add(check);
            panel1.Controls.Add(count);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 753);
            panel1.TabIndex = 0;
            // 
            // search
            // 
            search.Location = new Point(12, 36);
            search.Margin = new Padding(3, 4, 3, 4);
            search.Name = "search";
            search.Size = new Size(114, 27);
            search.TabIndex = 16;
            // 
            // check
            // 
            check.Location = new Point(12, 683);
            check.Name = "check";
            check.Size = new Size(186, 55);
            check.TabIndex = 6;
            check.Text = "Замерить производительность";
            check.UseVisualStyleBackColor = true;
            check.Click += check_Click;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(240, 704);
            count.Name = "count";
            count.Size = new Size(17, 20);
            count.TabIndex = 5;
            count.Text = "0";
            // 
            // button2
            // 
            button2.Location = new Point(152, 36);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 3;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Info;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 71);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 604);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Ivory;
            button1.Location = new Point(7, 536);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(242, 35);
            button1.TabIndex = 0;
            button1.Text = "Зарегистрировать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Linen;
            label1.Location = new Point(44, 48);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 1;
            label1.Text = "Зарегистрировать ЖЭК";
            // 
            // textReg
            // 
            textReg.Location = new Point(139, 132);
            textReg.Margin = new Padding(3, 4, 3, 4);
            textReg.Name = "textReg";
            textReg.Size = new Size(114, 27);
            textReg.TabIndex = 2;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(139, 369);
            textEmail.Margin = new Padding(3, 4, 3, 4);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(114, 27);
            textEmail.TabIndex = 6;
            // 
            // textSquare
            // 
            textSquare.Location = new Point(139, 432);
            textSquare.Margin = new Padding(3, 4, 3, 4);
            textSquare.Name = "textSquare";
            textSquare.Size = new Size(114, 27);
            textSquare.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 139);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 9;
            label2.Text = "Регион";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 185);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 10;
            label3.Text = "Число жителей";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 252);
            label4.Name = "label4";
            label4.Size = new Size(141, 40);
            label4.TabIndex = 11;
            label4.Text = "Число оплативших\r\n услуги";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 313);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 12;
            label5.Text = "Число домов";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 369);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 13;
            label6.Text = "email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 417);
            label7.Name = "label7";
            label7.Size = new Size(122, 60);
            label7.TabIndex = 14;
            label7.Text = "Площадь \r\nобслуживаемой\r\nтерритории";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.Info;
            panel2.Controls.Add(button5);
            panel2.Controls.Add(textInn);
            panel2.Controls.Add(textServ);
            panel2.Controls.Add(textHab);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textNam);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textSquare);
            panel2.Controls.Add(textEmail);
            panel2.Controls.Add(textReg);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(972, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 753);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.MistyRose;
            button5.Location = new Point(3, 599);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(243, 31);
            button5.TabIndex = 38;
            button5.Text = "Зарегистрироавть случайный ЖЭК";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textInn
            // 
            textInn.Location = new Point(139, 303);
            textInn.Margin = new Padding(3, 4, 3, 4);
            textInn.Name = "textInn";
            textInn.Size = new Size(114, 27);
            textInn.TabIndex = 19;
            // 
            // textServ
            // 
            textServ.Location = new Point(139, 249);
            textServ.Margin = new Padding(3, 4, 3, 4);
            textServ.Name = "textServ";
            textServ.Size = new Size(114, 27);
            textServ.TabIndex = 18;
            // 
            // textHab
            // 
            textHab.Location = new Point(139, 185);
            textHab.Margin = new Padding(3, 4, 3, 4);
            textHab.Name = "textHab";
            textHab.Size = new Size(114, 27);
            textHab.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 87);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 16;
            label8.Text = "Название";
            // 
            // textNam
            // 
            textNam.Location = new Point(139, 80);
            textNam.Margin = new Padding(3, 4, 3, 4);
            textNam.Name = "textNam";
            textNam.Size = new Size(114, 27);
            textNam.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(changingHous);
            panel3.Controls.Add(changingHab);
            panel3.Controls.Add(changingServ);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(changing_number_hex);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(changing_number);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(changing_name);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(changingSquare);
            panel3.Controls.Add(changingEmail);
            panel3.Controls.Add(changingReg);
            panel3.Controls.Add(label10);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(269, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 753);
            panel3.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(113, 664);
            button7.Name = "button7";
            button7.Size = new Size(311, 60);
            button7.TabIndex = 39;
            button7.Text = "Информация";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 192, 192);
            button6.Location = new Point(338, 593);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 38;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // changingHous
            // 
            changingHous.Location = new Point(177, 360);
            changingHous.Margin = new Padding(3, 4, 3, 4);
            changingHous.Name = "changingHous";
            changingHous.Size = new Size(114, 27);
            changingHous.TabIndex = 37;
            // 
            // changingHab
            // 
            changingHab.Location = new Point(177, 224);
            changingHab.Margin = new Padding(3, 4, 3, 4);
            changingHab.Name = "changingHab";
            changingHab.Size = new Size(114, 27);
            changingHab.TabIndex = 36;
            // 
            // changingServ
            // 
            changingServ.Location = new Point(182, 288);
            changingServ.Margin = new Padding(3, 4, 3, 4);
            changingServ.Name = "changingServ";
            changingServ.Size = new Size(114, 27);
            changingServ.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(45, 363);
            label20.Name = "label20";
            label20.Size = new Size(101, 20);
            label20.TabIndex = 34;
            label20.Text = "Число домов";
            // 
            // button4
            // 
            button4.Location = new Point(113, 593);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(86, 31);
            button4.TabIndex = 33;
            button4.Text = "Изменить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // changing_number_hex
            // 
            changing_number_hex.AutoSize = true;
            changing_number_hex.Location = new Point(263, 120);
            changing_number_hex.Name = "changing_number_hex";
            changing_number_hex.Size = new Size(17, 20);
            changing_number_hex.TabIndex = 31;
            changing_number_hex.Text = "0";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(45, 120);
            label18.Name = "label18";
            label18.Size = new Size(173, 20);
            label18.TabIndex = 30;
            label18.Text = "id в 16-ричной системе";
            // 
            // changing_number
            // 
            changing_number.AutoSize = true;
            changing_number.Location = new Point(182, 79);
            changing_number.Name = "changing_number";
            changing_number.Size = new Size(17, 20);
            changing_number.TabIndex = 29;
            changing_number.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(47, 79);
            label17.Name = "label17";
            label17.Size = new Size(22, 20);
            label17.TabIndex = 28;
            label17.Text = "id";
            // 
            // changing_name
            // 
            changing_name.AutoSize = true;
            changing_name.Location = new Point(182, 47);
            changing_name.Name = "changing_name";
            changing_name.Size = new Size(17, 20);
            changing_name.TabIndex = 27;
            changing_name.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(47, 224);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 22;
            label11.Text = "Число жителей";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 456);
            label12.Name = "label12";
            label12.Size = new Size(122, 60);
            label12.TabIndex = 26;
            label12.Text = "Площадь \r\nобслуживаемой\r\nтерритории";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 408);
            label13.Name = "label13";
            label13.Size = new Size(46, 20);
            label13.TabIndex = 25;
            label13.Text = "email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(39, 291);
            label15.Name = "label15";
            label15.Size = new Size(141, 40);
            label15.TabIndex = 23;
            label15.Text = "Число оплативших\r\n услуги";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(47, 173);
            label16.Name = "label16";
            label16.Size = new Size(58, 20);
            label16.TabIndex = 21;
            label16.Text = "Регион";
            // 
            // changingSquare
            // 
            changingSquare.Location = new Point(177, 471);
            changingSquare.Margin = new Padding(3, 4, 3, 4);
            changingSquare.Name = "changingSquare";
            changingSquare.Size = new Size(114, 27);
            changingSquare.TabIndex = 20;
            // 
            // changingEmail
            // 
            changingEmail.Location = new Point(177, 408);
            changingEmail.Margin = new Padding(3, 4, 3, 4);
            changingEmail.Name = "changingEmail";
            changingEmail.Size = new Size(114, 27);
            changingEmail.TabIndex = 19;
            // 
            // changingReg
            // 
            changingReg.Location = new Point(177, 171);
            changingReg.Margin = new Padding(3, 4, 3, 4);
            changingReg.Name = "changingReg";
            changingReg.Size = new Size(114, 27);
            changingReg.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 43);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 2;
            label10.Text = "Информация о ";
            // 
            // Form1
            // 
            BackColor = Color.LightGray;
            ClientSize = new Size(1228, 753);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 800);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Лабораторная работа 1 Сахно Никитов";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textInn).EndInit();
            ((System.ComponentModel.ISupportInitialize)textServ).EndInit();
            ((System.ComponentModel.ISupportInitialize)textHab).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)changingHous).EndInit();
            ((System.ComponentModel.ISupportInitialize)changingHab).EndInit();
            ((System.ComponentModel.ISupportInitialize)changingServ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private Panel panel1;
        private ListBox listBox1;
        private Button button1;
        private Label label1;
        private TextBox textReg;
        private TextBox textEmail;
        private TextBox textSquare;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Button button2;
        private Panel panel3;
        private Label label10;
        private Label changing_name;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label16;
        private TextBox changingEmail;
        private TextBox changingReg;
        private Label changing_number_hex;
        private Label label18;
        private Label changing_number;
        private Label label17;
        private Panel panel4;
        private Label label19;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label22;
        private Label label21;
        private NumericUpDown textInn;
        private NumericUpDown textServ;
        private NumericUpDown textHab;
        private Label label8;
        private TextBox textNam;
        private Button button4;
        private NumericUpDown changingHous;
        private NumericUpDown changingHab;
        private NumericUpDown changingServ;
        private Label label20;
        private TextBox changingSquare;
        private Button button5;
        private Label count;
        private Button check;
        private Button button6;
        private TextBox textBox3;
        private TextBox search;
        private Button button7;
    }
}