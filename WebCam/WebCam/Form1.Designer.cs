
namespace WebCam
{
    partial class webCamForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btnCameraStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.Reload = new System.Windows.Forms.Button();
            this.btnMirror = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCamera
            // 
            this.cmbCamera.FormattingEnabled = true;
            this.cmbCamera.Location = new System.Drawing.Point(204, 12);
            this.cmbCamera.Name = "cmbCamera";
            this.cmbCamera.Size = new System.Drawing.Size(298, 28);
            this.cmbCamera.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // pbCamera
            // 
            this.pbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCamera.Location = new System.Drawing.Point(12, 68);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(863, 392);
            this.pbCamera.TabIndex = 2;
            this.pbCamera.TabStop = false;
            // 
            // btnCameraStart
            // 
            this.btnCameraStart.Location = new System.Drawing.Point(437, 466);
            this.btnCameraStart.Name = "btnCameraStart";
            this.btnCameraStart.Size = new System.Drawing.Size(94, 29);
            this.btnCameraStart.TabIndex = 3;
            this.btnCameraStart.Text = "Start";
            this.btnCameraStart.UseVisualStyleBackColor = true;
            this.btnCameraStart.Click += new System.EventHandler(this.btnCameraStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(273, 466);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Reload
            // 
            this.Reload.Location = new System.Drawing.Point(580, 12);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(94, 29);
            this.Reload.TabIndex = 5;
            this.Reload.Text = "btnReload";
            this.Reload.UseVisualStyleBackColor = true;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // btnMirror
            // 
            this.btnMirror.Location = new System.Drawing.Point(146, 466);
            this.btnMirror.Name = "btnMirror";
            this.btnMirror.Size = new System.Drawing.Size(94, 29);
            this.btnMirror.TabIndex = 6;
            this.btnMirror.Text = "Mirror";
            this.btnMirror.UseVisualStyleBackColor = true;
            this.btnMirror.Click += new System.EventHandler(this.btnMirror_Click);
            // 
            // webCamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 615);
            this.Controls.Add(this.btnMirror);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCameraStart);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCamera);
            this.Name = "webCamForm";
            this.Text = "Web Cam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MaximumSizeChanged += new System.EventHandler(this.webCamForm_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.webCamForm_FormClosing);
            this.Load += new System.EventHandler(this.webCamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button btnCameraStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Button btnMirror;
    }
}

