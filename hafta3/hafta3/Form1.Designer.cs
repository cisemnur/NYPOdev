namespace hafta3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mesaıTxt = new TextBox();
            yasTxt = new TextBox();
            adresTxt = new TextBox();
            adTxt = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 70);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 124);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "Yas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 178);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 3;
            label4.Text = "Mesai";
            // 
            // mesaıTxt
            // 
            mesaıTxt.Location = new Point(132, 178);
            mesaıTxt.Name = "mesaıTxt";
            mesaıTxt.Size = new Size(125, 27);
            mesaıTxt.TabIndex = 4;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(132, 124);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 5;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(132, 70);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 27);
            adresTxt.TabIndex = 6;
            // 
            // adTxt
            // 
            adTxt.Location = new Point(132, 19);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(37, 294);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 8;
            button1.Text = "personel oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İşçi", "Mühendis" });
            comboBox1.Location = new Point(170, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 239);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 10;
            label5.Text = "unvan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(adTxt);
            Controls.Add(adresTxt);
            Controls.Add(yasTxt);
            Controls.Add(mesaıTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox mesaıTxt;
        private TextBox yasTxt;
        private TextBox adresTxt;
        private TextBox adTxt;
        private Button button1;
        private ComboBox comboBox1;
        private Label label5;
    }
}