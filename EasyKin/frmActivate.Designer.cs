﻿namespace morrisonm48.EasyKin
{
    partial class frmActivate
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
            this.ibxVideo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ibxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // ibxVideo
            // 
            this.ibxVideo.Location = new System.Drawing.Point(13, 13);
            this.ibxVideo.Name = "ibxVideo";
            this.ibxVideo.Size = new System.Drawing.Size(640, 480);
            this.ibxVideo.TabIndex = 0;
            this.ibxVideo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmActivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ibxVideo);
            this.Name = "frmActivate";
            this.Text = "EasyKin";
            ((System.ComponentModel.ISupportInitialize)(this.ibxVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ibxVideo;
        private System.Windows.Forms.Button button1;
    }
}