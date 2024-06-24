namespace _20Haziran
{
    partial class YazarSil
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
            YazarSil2 = new Button();
            label1 = new Label();
            yAd_txt = new ComboBox();
            SuspendLayout();
            // 
            // YazarSil2
            // 
            YazarSil2.Location = new Point(282, 194);
            YazarSil2.Name = "YazarSil2";
            YazarSil2.Size = new Size(94, 29);
            YazarSil2.TabIndex = 0;
            YazarSil2.Text = "Yazar Sil";
            YazarSil2.UseVisualStyleBackColor = true;
            YazarSil2.Click += YazarSil2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 163);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 2;
            label1.Text = "Yazar Adı-Soyadı:";
            // 
            // yAd_txt
            // 
            yAd_txt.FormattingEnabled = true;
            yAd_txt.Location = new Point(225, 160);
            yAd_txt.Name = "yAd_txt";
            yAd_txt.Size = new Size(151, 28);
            yAd_txt.TabIndex = 9;
            // 
            // YazarSil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(yAd_txt);
            Controls.Add(label1);
            Controls.Add(YazarSil2);
            Name = "YazarSil";
            Text = "YazarSil";
            Load += YazarSil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YazarSil2;
        private Label label1;
        private ComboBox yAd_txt;
    }
}