namespace Math_Calculations_App
{
    partial class MathCalculationsApp
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
            Karebtn = new Button();
            Dikdortgenbtn = new Button();
            button3 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            Dikdortgenbutton = new Button();
            textBox1 = new TextBox();
            label4 = new Label();
            Karebutton = new Button();
            Cevredeger = new Label();
            label6 = new Label();
            Alandeger = new Label();
            label3 = new Label();
            textbox0 = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Karebtn
            // 
            Karebtn.Font = new Font("MV Boli", 10.8F, FontStyle.Bold);
            Karebtn.Location = new Point(132, 50);
            Karebtn.Name = "Karebtn";
            Karebtn.Size = new Size(188, 132);
            Karebtn.TabIndex = 0;
            Karebtn.Text = "Kare";
            Karebtn.UseVisualStyleBackColor = true;
            Karebtn.Click += button1_Click;
            // 
            // Dikdortgenbtn
            // 
            Dikdortgenbtn.Font = new Font("MV Boli", 10.8F, FontStyle.Bold);
            Dikdortgenbtn.Location = new Point(647, 50);
            Dikdortgenbtn.Name = "Dikdortgenbtn";
            Dikdortgenbtn.Size = new Size(185, 132);
            Dikdortgenbtn.TabIndex = 1;
            Dikdortgenbtn.Text = "Dikdörtgen";
            Dikdortgenbtn.UseVisualStyleBackColor = true;
            Dikdortgenbtn.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("MV Boli", 10.8F, FontStyle.Bold);
            button3.Location = new Point(1122, 50);
            button3.Name = "button3";
            button3.Size = new Size(188, 132);
            button3.TabIndex = 2;
            button3.Text = "Daire";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(635, 221);
            label1.Name = "label1";
            label1.Size = new Size(0, 31);
            label1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Dikdortgenbutton);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(Karebutton);
            groupBox1.Controls.Add(Cevredeger);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Alandeger);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textbox0);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("MV Boli", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(301, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(823, 360);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kare'nin İşlemleri";
            // 
            // Dikdortgenbutton
            // 
            Dikdortgenbutton.ForeColor = SystemColors.ActiveCaptionText;
            Dikdortgenbutton.Location = new Point(513, 274);
            Dikdortgenbutton.Name = "Dikdortgenbutton";
            Dikdortgenbutton.Size = new Size(121, 35);
            Dikdortgenbutton.TabIndex = 20;
            Dikdortgenbutton.Text = "Hesapla";
            Dikdortgenbutton.UseVisualStyleBackColor = true;
            Dikdortgenbutton.Click += Dikdortgenbutton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 37);
            textBox1.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(177, 145);
            label4.Name = "label4";
            label4.Size = new Size(226, 31);
            label4.TabIndex = 18;
            label4.Text = "Bir kenarı giriniz:";
            // 
            // Karebutton
            // 
            Karebutton.ForeColor = SystemColors.ActiveCaptionText;
            Karebutton.Location = new Point(513, 274);
            Karebutton.Name = "Karebutton";
            Karebutton.Size = new Size(121, 35);
            Karebutton.TabIndex = 17;
            Karebutton.Text = "Hesapla";
            Karebutton.UseVisualStyleBackColor = true;
            Karebutton.Click += button4_Click;
            // 
            // Cevredeger
            // 
            Cevredeger.AutoSize = true;
            Cevredeger.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            Cevredeger.ForeColor = SystemColors.ButtonHighlight;
            Cevredeger.Location = new Point(264, 235);
            Cevredeger.Name = "Cevredeger";
            Cevredeger.Size = new Size(50, 31);
            Cevredeger.TabIndex = 16;
            Cevredeger.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(186, 235);
            label6.Name = "label6";
            label6.Size = new Size(89, 31);
            label6.TabIndex = 15;
            label6.Text = "Cevre:";
            // 
            // Alandeger
            // 
            Alandeger.AutoSize = true;
            Alandeger.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            Alandeger.ForeColor = SystemColors.ButtonHighlight;
            Alandeger.Location = new Point(255, 192);
            Alandeger.Name = "Alandeger";
            Alandeger.Size = new Size(50, 31);
            Alandeger.TabIndex = 14;
            Alandeger.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(186, 192);
            label3.Name = "label3";
            label3.Size = new Size(76, 31);
            label3.TabIndex = 13;
            label3.Text = "Alan:";
            // 
            // textbox0
            // 
            textbox0.Location = new Point(421, 90);
            textbox0.Name = "textbox0";
            textbox0.Size = new Size(226, 37);
            textbox0.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(177, 90);
            label2.Name = "label2";
            label2.Size = new Size(226, 31);
            label2.TabIndex = 11;
            label2.Text = "Bir kenarı giriniz:";
            label2.Click += label2_Click;
            // 
            // MathCalculationsApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1421, 767);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(Dikdortgenbtn);
            Controls.Add(Karebtn);
            Name = "MathCalculationsApp";
            Text = "Math Calculations App";
            Load += MathCalculationsApp_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Karebtn;
        private Button Dikdortgenbtn;
        private Button button3;
        private Label label1;
        private GroupBox groupBox1;
        private Button Karebutton;
        private Label Cevredeger;
        private Label label6;
        private Label Alandeger;
        private Label label3;
        private TextBox textbox0;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Button Dikdortgenbutton;
    }
}
