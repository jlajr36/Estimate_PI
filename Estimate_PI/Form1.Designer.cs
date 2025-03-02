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
            this.numPoints = new System.Windows.Forms.NumericUpDown();
            this.lblPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // skglCanvas
            // 
            this.skglCanvas.BackColor = System.Drawing.Color.Black;
            this.skglCanvas.Location = new System.Drawing.Point(12, 12);
            this.skglCanvas.Name = "skglCanvas";
            this.skglCanvas.Size = new System.Drawing.Size(700, 500);
            this.skglCanvas.TabIndex = 0;
            this.skglCanvas.VSync = false;
            this.skglCanvas.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs>(this.skglCanvas_PaintSurface);
            // 
            // btnEst
            // 
            this.btnEst.Location = new System.Drawing.Point(732, 58);
            this.btnEst.Name = "btnEst";
            this.btnEst.Size = new System.Drawing.Size(93, 23);
            this.btnEst.TabIndex = 1;
            this.btnEst.Text = "Estimate PI";
            this.btnEst.UseVisualStyleBackColor = true;
            this.btnEst.Click += new System.EventHandler(this.btnEst_Click);
            // 
            // numPoints
            // 
            this.numPoints.Location = new System.Drawing.Point(732, 32);
            this.numPoints.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPoints.Name = "numPoints";
            this.numPoints.Size = new System.Drawing.Size(92, 20);
            this.numPoints.TabIndex = 2;
            this.numPoints.ThousandsSeparator = true;
            this.numPoints.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(732, 13);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(58, 13);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "# of Points";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(735, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PI:";
            // 
            // txtPi
            // 
            this.txtPi.Location = new System.Drawing.Point(738, 120);
            this.txtPi.Name = "txtPi";
            this.txtPi.Size = new System.Drawing.Size(86, 20);
            this.txtPi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 528);
            this.Controls.Add(this.txtPi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.numPoints);
            this.Controls.Add(this.btnEst);
            this.Controls.Add(this.skglCanvas);
            this.Name = "Form1";
            this.Text = "Estimate PI";
            ((System.ComponentModel.ISupportInitialize)(this.numPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkiaSharp.Views.Desktop.SKGLControl skglCanvas;
        private System.Windows.Forms.Button btnEst;
        private System.Windows.Forms.NumericUpDown numPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPi;
    }
}

