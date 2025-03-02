using SkiaSharp;
using System;
using System.Windows.Forms;

namespace Estimate_PI
{
    public partial class Form1 : Form
    {
        bool paint = false;
        private SKPoint circleCenter = new SKPoint(0, 0);
        private float circleRadius = 225;

        public Form1()
        {
            InitializeComponent();
        }

        private void skglCanvas_PaintSurface(
            object sender,
            SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e
        )
        {
            if (paint)
            {
                int randomPoints = Convert.ToInt32(numPoints.Value);

                SKSurface surface = e.Surface;
                SKCanvas canvas = surface.Canvas;
                canvas.Clear(SKColor.Parse("#003366"));

                int canvasWidthCenter = skglCanvas.Size.Width / 2;
                int canvasHeightCenter = skglCanvas.Size.Height / 2;
                circleCenter.X = canvasWidthCenter;
                circleCenter.Y = canvasHeightCenter;

                // Draw the square
                using (SKPaint squarePaint = new SKPaint())
                {
                    squarePaint.Color = SKColors.White;
                    squarePaint.StrokeWidth = 1;
                    squarePaint.IsAntialias = true;
                    squarePaint.Style = SKPaintStyle.Stroke;
                    float squareSize = circleRadius * 2;
                    float left = circleCenter.X - circleRadius;
                    float top = circleCenter.Y - circleRadius;
                    float right = circleCenter.X + circleRadius;
                    float bottom = circleCenter.Y + circleRadius;
                    canvas.DrawRect(
                        left,
                        top,
                        squareSize,
                        squareSize,
                        squarePaint
                    );
                }

                // Draw the circle
                using (SKPaint circlePaint = new SKPaint())
                {
                    circlePaint.Color = SKColors.White;
                    circlePaint.StrokeWidth = 1;
                    circlePaint.IsAntialias = true;
                    circlePaint.Style = SKPaintStyle.Stroke;
                    canvas.DrawCircle(
                        circleCenter.X,
                        circleCenter.Y,
                        circleRadius,
                        circlePaint
                    );
                }

                // Draw horizontal line
                using (SKPaint linePaint = new SKPaint())
                {
                    linePaint.Color = SKColors.White;
                    linePaint.StrokeWidth = 1;
                    linePaint.IsAntialias = true;
                    canvas.DrawLine(
                        0,
                        circleCenter.Y,
                        skglCanvas.Size.Width,
                        circleCenter.Y,
                        linePaint
                    );
                }

                // Draw vertical line
                using (SKPaint linePaint = new SKPaint())
                {
                    linePaint.Color = SKColors.White;
                    linePaint.StrokeWidth = 1;
                    linePaint.IsAntialias = true;
                    canvas.DrawLine(
                        circleCenter.X,
                        0,
                        circleCenter.X,
                        skglCanvas.Size.Height,
                        linePaint
                    );
                }

                //Draw and track random pixels.
                int circleCount = 0;

                using (SKPaint insideCirclePaint = new SKPaint { Color = SKColors.Red })
                using (SKPaint outsideCirclePaint = new SKPaint { Color = SKColors.Green })
                {
                    Random random = new Random();

                    for (int i = 0; i < randomPoints; i++)
                    {
                        int randX = random.Next(
                            canvasWidthCenter,
                            Convert.ToInt32(canvasWidthCenter + circleRadius)
                        );
                        int randY = random.Next(
                            Convert.ToInt32(canvasHeightCenter - circleRadius),
                            canvasHeightCenter
                        );
                        double distanceSquared =
                            (randX - circleCenter.X) * (randX - circleCenter.X) +
                            (randY - circleCenter.Y) * (randY - circleCenter.Y);
                        double radiusSquared = circleRadius * circleRadius;

                        if (distanceSquared < radiusSquared)
                        {
                            circleCount++;
                            canvas.DrawPoint(randX, randY, insideCirclePaint);
                        } else {
                            canvas.DrawPoint(randX, randY, outsideCirclePaint);
                        }
                    }
                }
                double pi = (4 * (double)circleCount) / (double)randomPoints;
                txtPi.Text = pi.ToString();

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
