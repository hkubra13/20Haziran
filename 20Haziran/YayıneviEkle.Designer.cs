namespace _20Haziran
{
    partial class YayıneviEkle
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
            YayıneviEkle2 = new Button();
            YayıneviEkle_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // YayıneviEkle2
            // 
            YayıneviEkle2.Location = new Point(274, 147);
            YayıneviEkle2.Name = "YayıneviEkle2";
            YayıneviEkle2.Size = new Size(94, 29);
            YayıneviEkle2.TabIndex = 0;
            YayıneviEkle2.Text = "Ekle";
            YayıneviEkle2.UseVisualStyleBackColor = true;
            YayıneviEkle2.Click += YayıneviEkle2_Click;
            // 
            // YayıneviEkle_txt
            // 
            YayıneviEkle_txt.Location = new Point(243, 114);
            YayıneviEkle_txt.Name = "YayıneviEkle_txt";
            YayıneviEkle_txt.Size = new Size(125, 27);
            YayıneviEkle_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 114);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 2;
            label1.Text = "Yayınevi Adı :";
            // 
            // YayıneviEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(YayıneviEkle_txt);
            Controls.Add(YayıneviEkle2);
            Name = "YayıneviEkle";
            Text = "YayıneviEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YayıneviEkle2;
        private TextBox YayıneviEkle_txt;
        private Label label1;
    }
}