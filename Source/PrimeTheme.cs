using System.Drawing;
using System.Windows.Forms;

namespace ICARUS
{
    public class PrimeTheme : ThemeContainer152
    {
        private Color C1;

        private Color C2;

        private Color C3;

        private SolidBrush B1;

        private SolidBrush B2;

        private SolidBrush B3;

        private Pen P1;

        private Pen P2;

        private Pen P3;

        private Pen P4;

        private Rectangle RT1;

        public PrimeTheme()
        {
            MoveHeight = 32;
            BackColor = Color.White;
            TransparencyKey = Color.Fuchsia;
            SetColor("Sides", 232, 232, 232);
            SetColor("Gradient1", 252, 252, 252);
            SetColor("Gradient2", 242, 242, 242);
            SetColor("TextShade", Color.White);
            SetColor("Text", 80, 80, 80);
            SetColor("Back", Color.White);
            SetColor("Border1", 180, 180, 180);
            SetColor("Border2", Color.White);
            SetColor("Border3", Color.White);
            SetColor("Border4", 150, 150, 150);
        }

        protected override void ColorHook()
        {
            C1 = GetColor("Sides");
            C2 = GetColor("Gradient1");
            C3 = GetColor("Gradient2");
            B1 = new SolidBrush(GetColor("TextShade"));
            B2 = new SolidBrush(GetColor("Text"));
            B3 = new SolidBrush(GetColor("Back"));
            P1 = new Pen(GetColor("Border1"));
            P2 = new Pen(GetColor("Border2"));
            P3 = new Pen(GetColor("Border3"));
            P4 = new Pen(GetColor("Border4"));
            BackColor = B3.Color;
        }

        protected override void PaintHook()
        {
            graphics_0.Clear(C1);
            DrawGradient(C2, C3, 0, 0, Width, 15);
            DrawText(B1, HorizontalAlignment.Left, 13, 1);
            DrawText(B2, HorizontalAlignment.Left, 12, 0);
            RT1 = new Rectangle(12, 30, Width - 24, Height - 42);
            graphics_0.FillRectangle(B3, RT1);
            DrawBorders(P1, RT1, 1);
            DrawBorders(P2, RT1);
            DrawBorders(P3, 1);
            DrawBorders(P4);
            DrawCorners(TransparencyKey);
        }
    }
}