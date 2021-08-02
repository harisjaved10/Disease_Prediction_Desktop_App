namespace ProjectX
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cure = new System.Windows.Forms.Label();
            this.disease_combo = new System.Windows.Forms.ComboBox();
            this.disease = new System.Windows.Forms.Label();
            this.cure_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(373, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 62);
            this.label2.TabIndex = 7;
            this.label2.Text = "++";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 62);
            this.label1.TabIndex = 6;
            this.label1.Text = "Health Care";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Send Reports To Your doctor";
            // 
            // Cure
            // 
            this.Cure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cure.Location = new System.Drawing.Point(158, 227);
            this.Cure.Name = "Cure";
            this.Cure.Size = new System.Drawing.Size(310, 132);
            this.Cure.TabIndex = 10;
            this.Cure.Text = "CURE WILL BE DISPLAYED HERE";
            this.Cure.Click += new System.EventHandler(this.Cure_Click);
            // 
            // disease_combo
            // 
            this.disease_combo.FormattingEnabled = true;
            this.disease_combo.Items.AddRange(new object[] {
            "Corona Virus",
            "Viral Infection",
            "Heart Problem",
            "Spinal Issues",
            "Dehydration",
            "Fever",
            "Diarrhea",
            "Food Poisoning"});
            this.disease_combo.Location = new System.Drawing.Point(319, 107);
            this.disease_combo.Name = "disease_combo";
            this.disease_combo.Size = new System.Drawing.Size(121, 21);
            this.disease_combo.TabIndex = 11;
            // 
            // disease
            // 
            this.disease.AutoSize = true;
            this.disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disease.Location = new System.Drawing.Point(142, 108);
            this.disease.Name = "disease";
            this.disease.Size = new System.Drawing.Size(154, 20);
            this.disease.TabIndex = 12;
            this.disease.Text = "Select Your Disease";
            // 
            // cure_btn
            // 
            this.cure_btn.Location = new System.Drawing.Point(212, 159);
            this.cure_btn.Name = "cure_btn";
            this.cure_btn.Size = new System.Drawing.Size(182, 37);
            this.cure_btn.TabIndex = 13;
            this.cure_btn.Text = "CLICK HERE TO GET THE CURE";
            this.cure_btn.UseVisualStyleBackColor = true;
            this.cure_btn.Click += new System.EventHandler(this.cure_btn_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 457);
            this.Controls.Add(this.cure_btn);
            this.Controls.Add(this.disease);
            this.Controls.Add(this.disease_combo);
            this.Controls.Add(this.Cure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cure;
        private System.Windows.Forms.ComboBox disease_combo;
        private System.Windows.Forms.Label disease;
        private System.Windows.Forms.Button cure_btn;
    }
}