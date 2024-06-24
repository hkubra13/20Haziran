namespace _20Haziran
{
    partial class YazarEkle
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
            YazarEkle2 = new Button();
            YazarEkle_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // YazarEkle2
            // 
            YazarEkle2.Location = new Point(264, 201);
            YazarEkle2.Name = "YazarEkle2";
            YazarEkle2.Size = new Size(94, 29);
            YazarEkle2.TabIndex = 0;
            YazarEkle2.Text = "Ekle";
            YazarEkle2.UseVisualStyleBackColor = true;
            YazarEkle2.Click += YazarEkle2_Click;
            // 
            // YazarEkle_txt
            // 
            YazarEkle_txt.Location = new Point(233, 168);
            YazarEkle_txt.Name = "YazarEkle_txt";
            YazarEkle_txt.Size = new Size(125, 27);
            YazarEkle_txt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 171);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 2;
            label1.Text = "Yazar Adı-Soyadı :";
            // 
            // YazarEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(YazarEkle_txt);
            Controls.Add(YazarEkle2);
            Name = "YazarEkle";
            Text = "YazarEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button YazarEkle2;
        private TextBox YazarEkle_txt;
        private Label label1;
    }
}