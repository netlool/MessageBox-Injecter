using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheapMetro
{
    enum Theme
    {
        DefaultRed,
        MightyBlue,
        SweetGreen,
        StubbornPurple,
        ModernDark,
        PrettyOrange
    }

    class ThemeConverter
    {
        public static Color GetColor(Theme theme)
        {
            switch (theme)
            {
                case Theme.DefaultRed:
                    return rgb(231, 76, 60);
                case Theme.PrettyOrange:
                    return rgb(230, 126, 34);
                case Theme.ModernDark:
                    return rgb(52, 73, 94);
                case Theme.StubbornPurple:
                    return rgb(155, 89, 182);
                case Theme.SweetGreen:
                    return Color.FromArgb(46, 204, 113);
                case Theme.MightyBlue:
                    return Color.FromArgb(52, 152, 219);
                default:
                    return Color.FromArgb(231, 76, 60);
            }
        }

        public static Color GetBackColor(Theme theme)
        {
            switch (theme)
            {
                case Theme.SweetGreen:
                    return rgb(39, 174, 96);
                case Theme.PrettyOrange:
                    return rgb(211, 84, 0);
                case Theme.MightyBlue:
                    return rgb(41, 128, 185);
                case Theme.StubbornPurple:
                    return rgb(142, 68, 173);
                case Theme.ModernDark:
                    return rgb(44, 62, 80);
                default:
                    return Color.FromArgb(192, 57, 43);
            }
        }

        public static Color GetForeColor(Theme theme)
        {
            switch (theme)
            {
                default:
                    return rgb(236, 240, 241);
            }
        }

        private static Color rgb(int x, int y, int z)
        {
            return Color.FromArgb(x, y, z);
        }
    }

    class MetroButton : Button
    {
        private Theme _theme = Theme.DefaultRed;
        public Theme Theme
        {
            get
            {
                return _theme;
            }
            set
            {
                _theme = value;
                UpdateTheme();
            }
        }
        private bool Down_click { get; set; }

        public MetroButton() : base()
        {
            Text = "□→";
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;

            ForeColor = ThemeConverter.GetForeColor(Theme);
            BackColor = ThemeConverter.GetColor(Theme);
            FlatAppearance.MouseDownBackColor = ThemeConverter.GetBackColor(Theme);
            FlatAppearance.MouseOverBackColor = ThemeConverter.GetColor(Theme);

            Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            Size = new Size(145, 145);

            DoubleBuffered = true;

            MouseDown += delegate (object sender, MouseEventArgs mevent)
            {
                Down_click = true;
            };

            MouseUp += delegate (object sender, MouseEventArgs mevent)
            {
                Down_click = false;
                Invalidate();
            };
        }

        private void UpdateTheme()
        {
            ForeColor = ThemeConverter.GetForeColor(Theme);
            BackColor = ThemeConverter.GetColor(Theme);
            FlatAppearance.MouseDownBackColor = ThemeConverter.GetBackColor(Theme);
            FlatAppearance.MouseOverBackColor = ThemeConverter.GetColor(Theme);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (!Down_click)
                pevent.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(20, 255, 255, 255)), new Rectangle(-(Width / 2), -(Height / 2), Width * 3, Height));
        }
    }

    class LogBox : TextBox
    {
        public LogBox() : base()
        {
            BorderStyle = BorderStyle.None;
            //ForeColor = Color.FromArgb(236, 240, 241);
            ForeColor = Color.FromArgb(255, 100, 100);
            BackColor = Color.FromArgb(192, 57, 43);
            Font = new Font("Segoe UI Light", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            Size = new Size(145, 145);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0, 0)), new Rectangle(-(Width / 2), -(Height / 2), Width * 3, Height));
        }
    }

    class DropDownButton : MetroButton
    {
        public DropDownButton() : base()
        {
            //todo: draw \         / shape
            //            ''''''''' for dropdown button
        }
    }

}
