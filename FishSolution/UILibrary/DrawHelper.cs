﻿namespace UILibrary
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public class DrawHelper
    {
        public static GraphicsPath CreateRoundPath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180f, 90f);
            path.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - (cornerRadius * 2), rect.Y);
            path.AddArc((rect.X + rect.Width) - (cornerRadius * 2), rect.Y, cornerRadius * 2, cornerRadius * 2, 270f, 90f);
            path.AddLine(rect.Right, rect.Y + (cornerRadius * 2), rect.Right, (rect.Y + rect.Height) - (cornerRadius * 2));
            path.AddArc((int) ((rect.X + rect.Width) - (cornerRadius * 2)), (int) ((rect.Y + rect.Height) - (cornerRadius * 2)), (int) (cornerRadius * 2), (int) (cornerRadius * 2), 0f, 90f);
            path.AddLine(rect.Right - (cornerRadius * 2), rect.Bottom, rect.X + (cornerRadius * 2), rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - (cornerRadius * 2), cornerRadius * 2, cornerRadius * 2, 90f, 90f);
            path.AddLine(rect.X, rect.Bottom - (cornerRadius * 2), rect.X, rect.Y + (cornerRadius * 2));
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath CreateRoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float width = r.Width;
            float height = r.Height;
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            path.AddLine(x + r1, y, (x + width) - r2, y);
            path.AddBezier((x + width) - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
            path.AddLine((float) (x + width), (float) (y + r2), (float) (x + width), (float) ((y + height) - r3));
            path.AddBezier((float) (x + width), (float) ((y + height) - r3), (float) (x + width), (float) (y + height), (float) ((x + width) - r3), (float) (y + height), (float) ((x + width) - r3), (float) (y + height));
            path.AddLine((float) ((x + width) - r3), (float) (y + height), (float) (x + r4), (float) (y + height));
            path.AddBezier(x + r4, y + height, x, y + height, x, (y + height) - r4, x, (y + height) - r4);
            path.AddLine(x, (y + height) - r4, x, y + r1);
            return path;
        }

        public static void DrawImage(Graphics g, Image image, int x1, int y1, int width1, int height1, int x2, int y2, int width2, int height2)
        {
            g.DrawImage(image, new Rectangle(x1, y1, width1, height1), x2, y2, width2, height2, GraphicsUnit.Pixel);
        }

        public static void RendererBackground(Graphics g, Rectangle rect, Image backgroundImage, bool method)
        {
            if (!method)
            {
                g.DrawImage(backgroundImage, new Rectangle(rect.X, rect.Y, 5, rect.Height), 0, 0, 5, backgroundImage.Height, GraphicsUnit.Pixel);
                g.DrawImage(backgroundImage, new Rectangle(rect.X + 5, rect.Y, rect.Width - 10, rect.Height), 5, 0, backgroundImage.Width - 10, backgroundImage.Height, GraphicsUnit.Pixel);
                g.DrawImage(backgroundImage, new Rectangle((rect.X + rect.Width) - 5, rect.Y, 5, rect.Height), backgroundImage.Width - 5, 0, 5, backgroundImage.Height, GraphicsUnit.Pixel);
            }
            else
            {
                RendererBackground(g, rect, 5, backgroundImage);
            }
        }

        public static void RendererBackground(Graphics g, Rectangle rect, int cut, Image backgroundImage)
        {
            g.DrawImage(backgroundImage, new Rectangle(rect.X, rect.Y, cut, cut), 0, 0, cut, cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(rect.X + cut, rect.Y, rect.Width - (cut * 2), cut), cut, 0, backgroundImage.Width - (cut * 2), cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle((rect.X + rect.Width) - cut, rect.Y, cut, cut), backgroundImage.Width - cut, 0, cut, cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(rect.X, rect.Y + cut, cut, rect.Height - (cut * 2)), 0, cut, cut, backgroundImage.Height - (cut * 2), GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(rect.X, (rect.Y + rect.Height) - cut, cut, cut), 0, backgroundImage.Height - cut, cut, cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle((rect.X + rect.Width) - cut, rect.Y + cut, cut, rect.Height - (cut * 2)), backgroundImage.Width - cut, cut, cut, backgroundImage.Height - (cut * 2), GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle((rect.X + rect.Width) - cut, (rect.Y + rect.Height) - cut, cut, cut), backgroundImage.Width - cut, backgroundImage.Height - cut, cut, cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(rect.X + cut, (rect.Y + rect.Height) - cut, rect.Width - (cut * 2), cut), cut, backgroundImage.Height - cut, backgroundImage.Width - (cut * 2), cut, GraphicsUnit.Pixel);
            g.DrawImage(backgroundImage, new Rectangle(rect.X + cut, rect.Y + cut, rect.Width - (cut * 2), rect.Height - (cut * 2)), cut, cut, backgroundImage.Width - (cut * 2), backgroundImage.Height - (cut * 2), GraphicsUnit.Pixel);
        }
    }
}

