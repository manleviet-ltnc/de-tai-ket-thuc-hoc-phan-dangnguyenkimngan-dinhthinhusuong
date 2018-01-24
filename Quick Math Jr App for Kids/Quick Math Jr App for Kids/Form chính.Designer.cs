namespace Quick_Math_Jr_App_for_Kids
{
    partial class btnformchinh
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
            this.mnuMat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuMat.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images;
            this.mnuMat.Location = new System.Drawing.Point(73, 12);
            this.mnuMat.Name = "mnuMat";
            this.mnuMat.Size = new System.Drawing.Size(326, 305);
            this.mnuMat.TabIndex = 8;
            this.mnuMat.UseVisualStyleBackColor = false;
            this.mnuMat.Click += new System.EventHandler(this.mnuMat_Click);
            // 
            // mnuThuyen
            // 
            this.mnuThuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mnuThuyen.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__2_;
            this.mnuThuyen.Location = new System.Drawing.Point(73, 333);
            this.mnuThuyen.Name = "mnuThuyen";
            this.mnuThuyen.Size = new System.Drawing.Size(326, 305);
            this.mnuThuyen.TabIndex = 7;
            this.mnuThuyen.UseVisualStyleBackColor = false;
            this.mnuThuyen.Click += new System.EventHandler(this.mnuThuyen_Click);
            // 
            // mnuNha
            // 
            this.mnuNha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.mnuNha.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.logo;
            this.mnuNha.Location = new System.Drawing.Point(498, 12);
            this.mnuNha.Name = "mnuNha";
            this.mnuNha.Size = new System.Drawing.Size(326, 305);
            this.mnuNha.TabIndex = 6;
            this.mnuNha.UseVisualStyleBackColor = false;
            this.mnuNha.Click += new System.EventHandler(this.mnuNha_Click);
            // 
            // mnuXeBus
            // 
            this.mnuXeBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mnuXeBus.Image = global::Quick_Math_Jr_App_for_Kids.Properties.Resources.images__1_;
            this.mnuXeBus.Location = new System.Drawing.Point(498, 333);
            this.mnuXeBus.Name = "mnuXeBus";
            this.mnuXeBus.Size = new System.Drawing.Size(326, 305);
            this.mnuXeBus.TabIndex = 5;
            this.mnuXeBus.UseVisualStyleBackColor = false;
            this.mnuXeBus.Click += new System.EventHandler(this.mnuXeBus_Click);
            // 
            // btnformchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(902, 638);
            this.Controls.Add(this.mnuMat);
            this.Controls.Add(this.mnuThuyen);
            this.Controls.Add(this.mnuNha);
            this.Controls.Add(this.mnuXeBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "btnformchinh";
            this.Text = "Quick Math Jr App for Kids";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mnuXeBus;
        private System.Windows.Forms.Button mnuNha;
        private System.Windows.Forms.Button mnuThuyen;
        private System.Windows.Forms.Button mnuMat;
    }
}