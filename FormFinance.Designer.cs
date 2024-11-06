﻿namespace PROJECT_FINAL_VISPRO
{
    partial class FormFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinance));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFinance = new System.Windows.Forms.Button();
            this.btnDorm = new System.Windows.Forms.Button();
            this.btnResProf = new System.Windows.Forms.Button();
            this.btnFee = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnFinance
            // 
            this.btnFinance.BackColor = System.Drawing.Color.Indigo;
            this.btnFinance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinance.ForeColor = System.Drawing.Color.White;
            this.btnFinance.Location = new System.Drawing.Point(55, 500);
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(150, 35);
            this.btnFinance.TabIndex = 59;
            this.btnFinance.Text = "Finance";
            this.btnFinance.UseVisualStyleBackColor = false;
            this.btnFinance.Click += new System.EventHandler(this.btnFinance_Click);
            // 
            // btnDorm
            // 
            this.btnDorm.BackColor = System.Drawing.Color.Indigo;
            this.btnDorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDorm.ForeColor = System.Drawing.Color.White;
            this.btnDorm.Location = new System.Drawing.Point(55, 402);
            this.btnDorm.Name = "btnDorm";
            this.btnDorm.Size = new System.Drawing.Size(150, 35);
            this.btnDorm.TabIndex = 58;
            this.btnDorm.Text = "Dormitories";
            this.btnDorm.UseVisualStyleBackColor = false;
            this.btnDorm.Click += new System.EventHandler(this.btnDorm_Click);
            // 
            // btnResProf
            // 
            this.btnResProf.BackColor = System.Drawing.Color.Indigo;
            this.btnResProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResProf.ForeColor = System.Drawing.Color.White;
            this.btnResProf.Location = new System.Drawing.Point(55, 301);
            this.btnResProf.Name = "btnResProf";
            this.btnResProf.Size = new System.Drawing.Size(150, 35);
            this.btnResProf.TabIndex = 57;
            this.btnResProf.Text = "Resident Profile";
            this.btnResProf.UseVisualStyleBackColor = false;
            this.btnResProf.Click += new System.EventHandler(this.btnResProf_Click);
            // 
            // btnFee
            // 
            this.btnFee.BackColor = System.Drawing.Color.Indigo;
            this.btnFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFee.ForeColor = System.Drawing.Color.White;
            this.btnFee.Location = new System.Drawing.Point(909, 656);
            this.btnFee.Name = "btnFee";
            this.btnFee.Size = new System.Drawing.Size(308, 42);
            this.btnFee.TabIndex = 60;
            this.btnFee.Text = "Tuition Fee";
            this.btnFee.UseVisualStyleBackColor = false;
            this.btnFee.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Indigo;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.White;
            this.btnDash.Location = new System.Drawing.Point(55, 201);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(150, 35);
            this.btnDash.TabIndex = 56;
            this.btnDash.Text = "Dashboard";
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // FormFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnFee);
            this.Controls.Add(this.btnFinance);
            this.Controls.Add(this.btnDorm);
            this.Controls.Add(this.btnResProf);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFinance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFinance;
        private System.Windows.Forms.Button btnDorm;
        private System.Windows.Forms.Button btnResProf;
        private System.Windows.Forms.Button btnFee;
        private System.Windows.Forms.Button btnDash;
    }
}