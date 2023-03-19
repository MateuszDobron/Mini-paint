using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

//https://www.youtube.com/watch?v=3s3sS8tsTBM
//https://www.youtube.com/watch?v=D5cUhEXu8Jg

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        private Bitmap drawArea;
        private Pen pen,penD;
        bool moving;
        int tool_chosen = 0;
        int? initX = null;
        int? initY = null;
        int X=0,Y=0;
        public Bitmap bitmap_prev;
        Color color=Color.Black;
        int i = 0;
        PictureBox? button_prev = null;
        Bitmap image;
        Size size_prev;
        int thickness_prev;
        int toolStripButton_prev=0;

        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            InitializeComponent();
            toolStripButton_English.Checked = true;
            Canvas.Image = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            using (Graphics g = Graphics.FromImage(Canvas.Image))
            {
                g.Clear(Color.White);
            }
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            Canvas.Size = new Size((int)(((double)this.Size.Width) * 0.9), (int)(((double)this.Size.Height) * 0.9));
            //drawArea = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            Canvas.Refresh();
        }

        private void colorButton_handler(object sender, EventArgs e)
        {
            if (button_prev != null)
            {
                drawArea = new Bitmap(25, 25);
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.Clear(color);
                }
                button_prev.Image = drawArea;
            }
            PictureBox button =(PictureBox)sender;
            color = button.BackColor;
            penD = new Pen(Color.FromArgb(color.ToArgb() ^ 0xffffff), 2);
            penD.DashStyle=System.Drawing.Drawing2D.DashStyle.Dash;
            drawArea = new Bitmap(25, 25);
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(color);
                g.DrawRectangle(penD, 1, 1, 23, 23);
            }
            button.Image = drawArea;
            button_prev = button;
            drawArea = new Bitmap(28, 28);
            using (Graphics g = Graphics.FromImage(drawArea))
            {
                g.Clear(color);
            }
            toolStripButton_Chosencolor.Image = drawArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool left = true;
            for (KnownColor enumValue = 0; enumValue <= KnownColor.YellowGreen; enumValue++)
            {
                PictureBox button = new PictureBox();
                if (left)
                {
                    button.Location = new Point(3 + 25 + 3, 3 + (int)enumValue * 25);
                    left = false;
                }
                else
                {
                    button.Location = new Point(3, 3 + (int)enumValue * 25);
                    left = true;
                }
                button.Size = new Size(25, 25);
                drawArea = new Bitmap(25, 25);
                using (Graphics g = Graphics.FromImage(drawArea))
                {
                    g.Clear(Color.FromKnownColor(enumValue));
                }
                if (Color.FromKnownColor(enumValue) == color)
                {
                    penD = new Pen(Color.FromArgb(color.ToArgb() ^ 0xffffff), 2);
                    penD.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    using (Graphics g = Graphics.FromImage(drawArea))
                    {
                        g.DrawRectangle(penD, 1, 1, 23, 23);
                    }
                }
                button.Image = drawArea;
                button.BackColor = Color.FromKnownColor(enumValue);
                button.Click += new System.EventHandler(this.colorButton_handler);
                flowLayoutPanel.Controls.Add(button);

            }
            string[] items = {
                "1",
                "2",
                "3"
            };
            toolStripComboBox.Items.AddRange(items);
            toolStripComboBox.Text = "2";
            Bitmap bmp = new Bitmap(28, 28);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(color);
            }
            toolStripButton_Chosencolor.Image = bmp;
        }

        private void resized_canvas(object sender, EventArgs e)
        {
            Bitmap result = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.White);
                if(Canvas.Image!=null)
                    g.DrawImage(Canvas.Image, 0, 0);
            }
            Canvas.Image = result;
        }

        private void mouseUp_canvas(object sender, MouseEventArgs e)
        {
            moving = false;
        }

        private void mouseMove_canvas(object sender, MouseEventArgs e)
        {

            this.Cursor = System.Windows.Forms.Cursors.Cross;
            if (moving && (e.X > -1) && (e.Y > -1))
            {
                if (tool_chosen == 1) {
                    using (Graphics g = Graphics.FromImage(Canvas.Image))
                    {
                        if (e.X - initX > 50 || e.X - initX < -50 || e.Y - initY > 50 || e.Y - initY < -50)
                            g.DrawLine(pen, e.X, e.Y, e.X + 1, e.Y + 1);
                        else
                            g.DrawLine(pen, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                        initX = e.X;
                        initY = e.Y;
                        //https://www.c-sharpcorner.com/UploadFile/1e050f/mini-paint-application-using-C-Sharp/
                        //g.DrawLine(pen, e.X,e.Y, e.X+1,e.Y+1);
                        //g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    }
                }
                if (tool_chosen == 2)
                {
                    Canvas.Image.Dispose();
                    Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
                    using (Graphics g = Graphics.FromImage(Canvas.Image))
                    {
                        g.Clear(Color.White);
                        g.DrawImage(bitmap_prev, 0, 0);
                        if (e.X > X && e.Y > Y)
                            g.DrawRectangle(pen, X, Y, e.X - X, e.Y - Y);
                        if (e.X < X && e.Y > Y)
                            g.DrawRectangle(pen, e.X, Y, X - e.X, e.Y - Y);
                        if (e.X > X && e.Y < Y)
                            g.DrawRectangle(pen, X, e.Y, e.X - X, Y - e.Y);
                        if (e.X < X && e.Y < Y)
                            g.DrawRectangle(pen,e.X, e.Y, X - e.X, Y - e.Y);
                    }
                }
                if (tool_chosen == 3)
                {
                    Canvas.Image.Dispose();
                    Canvas.Image = new Bitmap(Canvas.Width, Canvas.Height);
                    using (Graphics g = Graphics.FromImage(Canvas.Image))
                    {
                        g.Clear(Color.White);
                        g.DrawImage(bitmap_prev, 0, 0);
                        g.DrawEllipse(pen, X, Y, e.X - X, e.Y - Y);
                    }
                }
            }
            Canvas.Refresh();
        }

        private void brush_Click(object sender, EventArgs e)
        {
            highlightButton(toolStripButton_brush);
            tool_chosen = 1;
        }

        private void mouseDown_canvas(object sender, MouseEventArgs e)
        {
            string length = toolStripComboBox.Text.ToString();
            pen = new Pen(color, int.Parse(toolStripComboBox.Text.ToString()));
            if (e.Button == MouseButtons.Left)
            {
                bitmap_prev = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
                using (Graphics g = Graphics.FromImage(bitmap_prev))
                {
                    g.Clear(Color.White);
                    g.DrawImage(Canvas.Image, 0, 0);
                }
                X = e.X;
                Y = e.Y;
                moving = true;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if(tool_chosen==2|| tool_chosen == 3)
                {
                    Canvas.Image = bitmap_prev;
                }
                moving = false;
            }
        }

        private void mouseMove_layout(object sender, MouseEventArgs e)
        {
            if(e.X>this.Size.Width*0.9&& e.Y > this.Size.Height * 0.9)
            {
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void mouseLeave_canvas(object sender, EventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save image Files";
            //saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "bmp";
            saveFileDialog1.Filter = "Bitmap Image (*.bmp)|*.BMP|JPEG Image (*.jpeg)|*.JPEG|PNG Image (*.png)|*.PNG";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            System.Drawing.Imaging.ImageFormat format= System.Drawing.Imaging.ImageFormat.Png;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                }

                Canvas.Image.Save(saveFileDialog1.FileName, format);
            }
            //https://stackoverflow.com/questions/11055258/how-to-use-savefiledialog-for-saving-images-in-c
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "Bitmap Image (*.bmp)|*.BMP|JPEG Image (*.jpeg)|*.JPEG|PNG Image (*.png)|*.PNG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                drawArea= new Bitmap(dialog.FileName);
            }
            this.Size=new Size((int)(drawArea.Width/0.9), (int)(drawArea.Height/0.9));
            Canvas.Image = drawArea;
        //https://stackoverflow.com/questions/6122984/load-a-bitmap-image-into-windows-forms-using-open-file-dialog
        }

        private void highlightButton(ToolStripButton name)
        {
            toolStripButton_brush.Checked = false;
            toolStripButton_rectangle.Checked = false;
            toolStripButton_ellipse.Checked = false;
            name.Checked = true;
            if (name == toolStripButton_brush)
                toolStripButton_prev = 1;
            if (name == toolStripButton_rectangle)
                toolStripButton_prev = 2;
            if (name == toolStripButton_ellipse)
                toolStripButton_prev = 3;
            //foreach (object item in toolStrip.Items)
            //{
            //    ToolStripButton? menuItem = item as ToolStripButton;
            //    if (menuItem != null)
            //    {
            //        if (menuItem == name) menuItem.Checked = true;
            //        if ((menuItem != null) && (menuItem != name))
            //        {
            //            menuItem.Checked = false;
            //        }
            //    }
            //}
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            highlightButton(toolStripButton_rectangle);
            tool_chosen = 2;
        }
        private void CultureSave()
        {
            image = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            using (Graphics g = Graphics.FromImage(image))
            {
                g.Clear(Color.White);
                g.DrawImage(Canvas.Image, 0, 0);
            }
            size_prev=this.Size;
            thickness_prev = int.Parse(toolStripComboBox.Text.ToString());
        }
        private void CultureLoad()
        {
            this.Controls.Clear();
            InitializeComponent();
            this.Size = size_prev;
            Object o=new Object();
            EventArgs e=new EventArgs();
            this.Form1_Load(o,e);
            Canvas.Image = image;
            toolStripComboBox.Text = thickness_prev.ToString();
            if(toolStripButton_prev==1)
                this.highlightButton(toolStripButton_brush);
            if (toolStripButton_prev == 2)
                this.highlightButton(toolStripButton_rectangle);
            if (toolStripButton_prev == 3)
                this.highlightButton(toolStripButton_ellipse);
        }
        private void polishButton_Click(object sender, EventArgs e)
        {
            this.CultureSave();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl");
            this.CultureLoad();
            toolStripButton_Polish.Checked = true;
            toolStripButton_English.Checked = false;
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            this.CultureSave();
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.CultureLoad();
            toolStripButton_English.Checked = true;
            toolStripButton_Polish.Checked = false;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            highlightButton(toolStripButton_ellipse);  
            tool_chosen = 3;
        }

        private void trashButton_Click(object sender, EventArgs e)
        {
            Bitmap result = new Bitmap(Canvas.Size.Width, Canvas.Size.Height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.Clear(Color.White);
            }
            Canvas.Image = result;
        }
    }
}
