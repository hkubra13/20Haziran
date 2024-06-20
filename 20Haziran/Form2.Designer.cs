namespace _20Haziran
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            bTarih_txt = new TextBox();
            yEv_txt = new TextBox();
            sayfaS_txt = new TextBox();
            yAd_txt = new TextBox();
            kAd_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(bTarih_txt);
            groupBox1.Controls.Add(yEv_txt);
            groupBox1.Controls.Add(sayfaS_txt);
            groupBox1.Controls.Add(yAd_txt);
            groupBox1.Controls.Add(kAd_txt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(259, 293);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Ekle";
            // 
            // button3
            // 
            button3.Location = new Point(135, 250);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 5;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bTarih_txt
            // 
            bTarih_txt.Location = new Point(113, 217);
            bTarih_txt.Name = "bTarih_txt";
            bTarih_txt.Size = new Size(125, 27);
            bTarih_txt.TabIndex = 9;
            // 
            // yEv_txt
            // 
            yEv_txt.Location = new Point(113, 174);
            yEv_txt.Name = "yEv_txt";
            yEv_txt.Size = new Size(125, 27);
            yEv_txt.TabIndex = 8;
            // 
            // sayfaS_txt
            // 
            sayfaS_txt.Location = new Point(113, 129);
            sayfaS_txt.Name = "sayfaS_txt";
            sayfaS_txt.Size = new Size(125, 27);
            sayfaS_txt.TabIndex = 7;
            // 
            // yAd_txt
            // 
            yAd_txt.Location = new Point(113, 76);
            yAd_txt.Name = "yAd_txt";
            yAd_txt.Size = new Size(125, 27);
            yAd_txt.TabIndex = 6;
            // 
            // kAd_txt
            // 
            kAd_txt.Location = new Point(113, 29);
            kAd_txt.Name = "kAd_txt";
            kAd_txt.Size = new Size(125, 27);
            kAd_txt.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 217);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 4;
            label5.Text = "Basım Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 174);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 3;
            label4.Text = "Yayın Evi :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 129);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 2;
            label3.Text = "Sayfa Sayısı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Yazar Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı :";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private TextBox bTarih_txt;
        private TextBox yEv_txt;
        private TextBox sayfaS_txt;
        private TextBox yAd_txt;
        private TextBox kAd_txt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}