namespace Quick_Math_Jr_App_for_Kids
{
    partial class Form1
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
            this.mnuMat = new System.Windows.Forms.Button();
            this.mnuThuyen = new System.Windows.Forms.Button();
            this.mnuNha = new System.Windows.Forms.Button();
            this.mnuXeBus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mnuMat
            // 
            this.mnuMat.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images;
            this.mnuMat.Location = new System.Drawing.Point(448, 338);
            this.mnuMat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mnuMat.Name = "mnuMat";
            this.mnuMat.Size = new System.Drawing.Size(347, 258);
            this.mnuMat.TabIndex = 7;
            this.mnuMat.UseVisualStyleBackColor = true;
            this.mnuMat.Click += new System.EventHandler(this.mnuMat_Click);
            // 
            // mnuThuyen
            // 
            this.mnuThuyen.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__2_;
            this.mnuThuyen.Location = new System.Drawing.Point(29, 338);
            this.mnuThuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mnuThuyen.Name = "mnuThuyen";
            this.mnuThuyen.Size = new System.Drawing.Size(347, 258);
            this.mnuThuyen.TabIndex = 6;
            this.mnuThuyen.UseVisualStyleBackColor = true;
            this.mnuThuyen.Click += new System.EventHandler(this.mnuThuyen_Click);
            // 
            // mnuNha
            // 
            this.mnuNha.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.logo;
            this.mnuNha.Location = new System.Drawing.Point(448, 47);
            this.mnuNha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mnuNha.Name = "mnuNha";
            this.mnuNha.Size = new System.Drawing.Size(347, 258);
            this.mnuNha.TabIndex = 5;
            this.mnuNha.UseVisualStyleBackColor = true;
            this.mnuNha.Click += new System.EventHandler(this.mnuNha_Click);
            // 
            // mnuXeBus
            // 
            this.mnuXeBus.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__1_;
            this.mnuXeBus.Location = new System.Drawing.Point(29, 47);
            this.mnuXeBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mnuXeBus.Name = "mnuXeBus";
            this.mnuXeBus.Size = new System.Drawing.Size(347, 258);
            this.mnuXeBus.TabIndex = 4;
            this.mnuXeBus.UseVisualStyleBackColor = true;
            this.mnuXeBus.Click += new System.EventHandler(this.mnuXeBus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 612);
            this.Controls.Add(this.mnuMat);
            this.Controls.Add(this.mnuThuyen);
            this.Controls.Add(this.mnuNha);
            this.Controls.Add(this.mnuXeBus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Giao dien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mnuXeBus;
        private System.Windows.Forms.Button mnuNha;
        private System.Windows.Forms.Button mnuThuyen;
        private System.Windows.Forms.Button mnuMat;
    }
}

