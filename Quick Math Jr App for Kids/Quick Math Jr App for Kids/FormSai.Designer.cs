namespace Quick_Math_Jr_App_for_Kids
{
    partial class btnformsai
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnchoitiep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(149, 12);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(123, 34);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnchoitiep
            // 
            this.btnchoitiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnchoitiep.Location = new System.Drawing.Point(12, 12);
            this.btnchoitiep.Name = "btnchoitiep";
            this.btnchoitiep.Size = new System.Drawing.Size(123, 34);
            this.btnchoitiep.TabIndex = 2;
            this.btnchoitiep.Text = "Chơi tiếp";
            this.btnchoitiep.UseVisualStyleBackColor = true;
            this.btnchoitiep.Click += new System.EventHandler(this.btnchoitiep_Click);
            // 
            // btnformsai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(289, 59);
            this.Controls.Add(this.btnchoitiep);
            this.Controls.Add(this.btnthoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "btnformsai";
            this.Text = "FormSai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnchoitiep;
    }
}