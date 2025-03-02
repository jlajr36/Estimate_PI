namespace Estimate_PI
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
            this.skglCanvas = new SkiaSharp.Views.Desktop.SKGLControl();
            this.btnEst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skglCanvas
            // 
            this.skglCanvas.BackColor = System.Drawing.Color.Black;
            this.skglCanvas.Location = new System.Drawing.Point(12, 12);
            this.skglCanvas.Name = "skglCanvas";
            this.skglCanvas.Size = new System.Drawing.Size(677, 426);
            this.skglCanvas.TabIndex = 0;
            this.skglCanvas.VSync = false;
            this.skglCanvas.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs>(this.skglCanvas_PaintSurface);
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(698, 12);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(93, 23);
            this.btnEst.TabIndex = 1;
            this.btnEst.Text = "Estimate PI";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEst);
            this.Controls.Add(this.skglCanvas);
            this.Name = "Form1";
            this.Text = "Estimate PI";
            this.ResumeLayout(false);

        }

        #endregion

        private SkiaSharp.Views.Desktop.SKGLControl skglCanvas;
        private System.Windows.Forms.Button btnEst;
    }
}

