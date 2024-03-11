namespace OOP1lb
{
    partial class Form3
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
            electricity = new Label();
            water = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 0;
            label1.Text = "Стоимость электричества";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 200);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 1;
            label2.Text = "Стоимость водоснабжения";
            // 
            // electricity
            // 
            electricity.AutoSize = true;
            electricity.Location = new Point(269, 143);
            electricity.Name = "electricity";
            electricity.Size = new Size(50, 20);
            electricity.TabIndex = 2;
            electricity.Text = "label3";
            // 
            // water
            // 
            water.AutoSize = true;
            water.Location = new Point(269, 200);
            water.Name = "water";
            water.Size = new Size(50, 20);
            water.TabIndex = 3;
            water.Text = "label4";
            water.Click += water_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 22);
            label5.Name = "label5";
            label5.Size = new Size(172, 20);
            label5.TabIndex = 4;
            label5.Text = "Общая стоимость услуг";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 308);
            Controls.Add(label5);
            Controls.Add(water);
            Controls.Add(electricity);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label electricity;
        private Label water;
        private Label label5;
    }
}