namespace AccordCameraDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.PictureBox picPortrait;
        private System.Windows.Forms.Button btnCapture;

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
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.picPortrait = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortrait)).BeginInit();
            this.SuspendLayout();
            // 
            // picCamera
            // 
            this.picCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCamera.Location = new System.Drawing.Point(20, 12);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(400, 300);
            this.picCamera.TabIndex = 0;
            this.picCamera.TabStop = false;
            // 
            // picPortrait
            // 
            this.picPortrait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortrait.Location = new System.Drawing.Point(440, 12);
            this.picPortrait.Name = "picPortrait";
            this.picPortrait.Size = new System.Drawing.Size(240, 300);
            this.picPortrait.TabIndex = 1;
            this.picPortrait.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(159, 323);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 2;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(520, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 369);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picPortrait);
            this.Controls.Add(this.picCamera);
            this.Name = "MainForm";
            this.Text = "Demo: Capture Image from Camera";
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPortrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
    }
}

