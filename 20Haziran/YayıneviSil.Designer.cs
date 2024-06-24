namespace _20Haziran
{
    partial class YayıneviSil
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
            yEv_txt = new ComboBox();
            label1 = new Label();
            YayıneviSil2 = new Button();
            SuspendLayout();
            // 
            // yEv_txt
            // 
            yEv_txt.FormattingEnabled = true;
            yEv_txt.Location = new Point(285, 193);
            yEv_txt.Name = "yEv_txt";
            yEv_txt.Size = new Size(151, 28);
            yEv_txt.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 196);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 11;
            label1.Text = "Yayınevi Adı :";
            // 
            // YayıneviSil2
            // 
            YayıneviSil2.Location = new Point(342, 227);
            YayıneviSil2.Name = "YayıneviSil2";
            YayıneviSil2.Size = new Size(94, 29);
            YayıneviSil2.TabIndex = 10;
            YayıneviSil2.Text = "Yayınevi Sil";
            YayıneviSil2.UseVisualStyleBackColor = true;
            YayıneviSil2.Click += YayıneviSil2_Click;
            // 
            // YayıneviSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yEv_txt);
            Controls.Add(label1);
            Controls.Add(YayıneviSil2);
            Name = "YayıneviSil";
            Text = "YayıneviSil";
            Load += YayıneviSil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox yEv_txt;
        private Label label1;
        private Button YayıneviSil2;
    }
}