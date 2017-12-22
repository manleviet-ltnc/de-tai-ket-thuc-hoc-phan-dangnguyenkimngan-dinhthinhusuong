namespace Quick_Math_Jr_App_for_Kids
{
    partial class btnMat2
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
            this.caudung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btncaudung = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caudung
            // 
            this.caudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.caudung.Location = new System.Drawing.Point(189, 302);
            this.caudung.Margin = new System.Windows.Forms.Padding(4);
            this.caudung.Name = "caudung";
            this.caudung.Size = new System.Drawing.Size(100, 86);
            this.caudung.TabIndex = 6;
            this.caudung.Text = ".";
            this.caudung.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(266, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 113);
            this.label1.TabIndex = 7;
            this.label1.Text = "3";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(67, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 86);
            this.button3.TabIndex = 8;
            this.button3.Text = "....";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btncaudung
            // 
            this.btncaudung.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btncaudung.Location = new System.Drawing.Point(311, 302);
            this.btncaudung.Margin = new System.Windows.Forms.Padding(4);
            this.btncaudung.Name = "btncaudung";
            this.btncaudung.Size = new System.Drawing.Size(100, 86);
            this.btncaudung.TabIndex = 9;
            this.btncaudung.Text = "...";
            this.btncaudung.UseVisualStyleBackColor = true;
            this.btncaudung.Click += new System.EventHandler(this.btncaudung_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(433, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 86);
            this.button1.TabIndex = 10;
            this.button1.Text = ".....";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMat2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 432);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncaudung);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caudung);
            this.Name = "btnMat2";
            this.Text = "Level2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button caudung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncaudung;
        private System.Windows.Forms.Button button1;
    }
}