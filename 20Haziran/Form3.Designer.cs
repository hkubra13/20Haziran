namespace _20Haziran
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
            groupBox1 = new GroupBox();
            button3 = new Button();
            sayfaS_txt = new TextBox();
            kAd_txt = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            yAd_txt = new ComboBox();
            yEv_txt = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(yEv_txt);
            groupBox1.Controls.Add(yAd_txt);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(sayfaS_txt);
            groupBox1.Controls.Add(kAd_txt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(269, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 293);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Güncelle";
            // 
            // button3
            // 
            button3.Location = new Point(135, 250);
            button3.Name = "button3";
            button3.Size = new Size(80, 34);
            button3.TabIndex = 5;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // sayfaS_txt
            // 
            sayfaS_txt.Location = new Point(113, 129);
            sayfaS_txt.Name = "sayfaS_txt";
            sayfaS_txt.Size = new Size(125, 27);
            sayfaS_txt.TabIndex = 7;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(382, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // yAd_txt
            // 
            yAd_txt.FormattingEnabled = true;
            yAd_txt.Location = new Point(113, 80);
            yAd_txt.Name = "yAd_txt";
            yAd_txt.Size = new Size(151, 28);
            yAd_txt.TabIndex = 8;
            // 
            // yEv_txt
            // 
            yEv_txt.FormattingEnabled = true;
            yEv_txt.Location = new Point(113, 174);
            yEv_txt.Name = "yEv_txt";
            yEv_txt.Size = new Size(151, 28);
            yEv_txt.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private TextBox sayfaS_txt;
        private TextBox kAd_txt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private ComboBox yAd_txt;
        private ComboBox yEv_txt;
    }
}