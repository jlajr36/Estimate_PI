using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estimate_PI
{
    public partial class Form1 : Form
    {
        bool paint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void skglCanvas_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            if (paint)
            {
                SKSurface surface = e.Surface;
                SKCanvas canvas = surface.Canvas;

                // Clear the canvas to a background color
                canvas.Clear(SKColor.Parse("#003366"));

                // Create a paint object
                using (SKPaint paint = new SKPaint())
                {
                    paint.Color = SKColors.White;
                    paint.StrokeWidth = 5;

                    // Draw a circle
                    canvas.DrawCircle(200, 200, 50, paint);
                }

                paint = false;
            }
        }

        private void doDraw()
        {
            skglCanvas.Invalidate();
            Application.DoEvents();
        }

        private void btnEst_Click(object sender, EventArgs e)
        {
            paint = true;
            doDraw();
        }
    }
}
