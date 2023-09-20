using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public partial class LineChart : Control
    {
        #region Values
        private float[] values;
        public float[] Values
        {
            get { return values; }
            set
            {
                values = value;
                if (values != null)
                {
                    points = new PointF[Values.Length];
                    if (MaxValue < (int)Values.Max())
                    {
                        MaxValue = (int)Values.Max();
                    }
                }
                Invalidate();
            }
        }
        #endregion

        #region XLabels
        private string[] xLabels;
        public string[] XLabels
        {
            get { return xLabels; }
            set
            {
                xLabels = value;
                Invalidate();
            }
        }
        #endregion

        #region LineColor
        private Color lineColor;
        public Color LineColor
        {
            get { return lineColor; }
            set
            {
                lineColor = value;
                Invalidate();
            }
        }
        #endregion

        #region XLabel
        private string xLabel;
        public string XLabel
        {
            get { return xLabel; }
            set
            {
                xLabel = value;
                Invalidate();
            }
        }
        #endregion

        #region YLabel
        private string yLabel;
        public string YLabel
        {
            get { return yLabel; }
            set
            {
                yLabel = value;
                Invalidate();
            }
        }
        #endregion

        #region MaxValue
        private int maxValue;
        public int MaxValue
        {
            get { return maxValue; }
            set
            {
                maxValue = value;
                Invalidate();
            }
        }
        #endregion

        #region Title
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                Invalidate();
            }
        }
        #endregion

        private PointF[] points;
        public LineChart()
        {
            InitializeComponent();
            Values = new float[] { 1 };
            XLabels = new string[1];
            MaxValue = 1;
            LineColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (MaxValue == 0)
                return;
            int paddingY = pe.ClipRectangle.Height / 7;
            int paddingX = pe.ClipRectangle.Width / 12;
            Graphics graphics = pe.Graphics;
            Rectangle clipRectangle = new Rectangle(pe.ClipRectangle.X + paddingX, pe.ClipRectangle.Y + paddingY, pe.ClipRectangle.Width - 2 * paddingX, pe.ClipRectangle.Height - 2 * paddingY);
            float YScalingFactor = (clipRectangle.Height - paddingY) / MaxValue;
            float XScalingFactor = clipRectangle.Width / Values.Length;
            float minX = paddingX;
            float maxX = points.Length * XScalingFactor;
            float minY = clipRectangle.Height + paddingY;
            float maxY = paddingY;
            graphics.DrawLine(Pens.Black, minX, minY, maxX + 30, minY);
            graphics.DrawString(XLabel, new Font(SystemFonts.DefaultFont, FontStyle.Italic), Brushes.Black, clipRectangle.Right - 20, minY);
            graphics.DrawLine(Pens.Black, minX, minY, minX, maxY);
            graphics.DrawString(YLabel, new Font(SystemFonts.DefaultFont, FontStyle.Italic), Brushes.Black, minX - 20, pe.ClipRectangle.Y);
            graphics.DrawString(Title, new Font(SystemFonts.DefaultFont.Name, SystemFonts.DefaultFont.Size + 4, FontStyle.Bold), Brushes.Black, (clipRectangle.Width - (Title != null ? Title.Length * 5 : 0)) / 2, pe.ClipRectangle.Y);
            if (Values.Length < 2)
                return;
            if (XLabels.Length < 2)
            {
                XLabels = new string[Values.Length];
                for (int i = 0; i < Values.Length; i++)
                {
                    XLabels[i] = i.ToString();
                }
            }
            for (int i = 0; i < Values.Length; i++)
            {
                float pointHeight = Values[i] * YScalingFactor - paddingY;
                points[i].X = i * XScalingFactor + paddingX + 30;
                points[i].Y = clipRectangle.Height - pointHeight;
                graphics.DrawString(XLabels[i], SystemFonts.DefaultFont, Brushes.Black, points[i].X - 3, minY + 10);
                graphics.DrawString(Values[i].ToString(), SystemFonts.DefaultFont, Brushes.Black, points[i].X - 5, points[i].Y - 20);
                graphics.FillRectangle(new SolidBrush(lineColor), new RectangleF(points[i].X - 4, points[i].Y - 4, 8, 8));
            }
            for (int i = MaxValue; i > 0; i -= Math.Max(1, MaxValue / 5))
            {
                graphics.DrawString(i.ToString(), SystemFonts.DefaultFont, Brushes.Black, minX - 20, clipRectangle.Height - i * YScalingFactor + paddingY - 5);
                graphics.DrawLine(Pens.Black, minX, clipRectangle.Height - i * YScalingFactor + paddingY, maxX + 30, clipRectangle.Height - i * YScalingFactor + paddingY);
            }
            graphics.DrawLines(new Pen(lineColor, 2), points);
        }
    }
}
