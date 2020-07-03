using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace poorpaint
{
    public partial class Form1 : Form
    {
        //zmienne
        Graphics g;
        Pen p;
        Shape s;
        Point m_pos;
        bool isMoving;
        bool isMax;
        int tnum = 0;
        int tnum_name = 0;
        int tabs_width = 100;
        int max_tabs = 5;
        int picked;
        List <Panel> tabs;
        List<Bitmap> bmaps;
        List<Label> labels;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        //konstruktor
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 20));
            add_button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            p = new Pen(Brushes.Black, 3.0F);
            p.StartCap = p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            isMoving = false;
            isMax = false;
            s = new FreeDraw();
            shapeOpt.SelectedItem = "FreeMode";
            tabs = new List<Panel>();
            bmaps = new List<Bitmap>();
            labels = new List<Label>();
            add_tab();
        }

        //utworzenie nowej bitmapy
        private void new_bitmap()
        {
            Bitmap bmap = new Bitmap(canvas.Width, canvas.Height);
            bmaps.Add(bmap);
        }

        //wybór koloru
        private void colorOptGreen_Click(object sender, EventArgs e)
        {
            PictureBox box  = (PictureBox)sender;
            p.Color         = box.BackColor;
        }

        //gumka do ścierania
        private void eraserOpt_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        //naciśnięcie myszy
        private void canvas_MouseDown   (object sender, MouseEventArgs e)
        {
            this.isMoving = true;
            PointsToDraw.start = PointsToDraw.prevstep = e.Location;
        }

        //puszczenie przycisku myszy
        private void canvas_MouseUp     (object sender, MouseEventArgs e)
        {
            this.isMoving = false;
            PointsToDraw.stop = e.Location;
            if (!((s.GetType()).Equals(typeof(FreeDraw))))
                canvas.Refresh();
           
        }

        //ruch myszy
        private void canvas_MouseMove   (object sender, MouseEventArgs e)
        {
            if(isMoving && ((s.GetType()).Equals(typeof(FreeDraw))))
            {
                PointsToDraw.current = e.Location;
                canvas.Refresh();
                PointsToDraw.prevstep = PointsToDraw.current;
            }
        }

        //rysowanie
        private void canvas_Paint       (object sender, PaintEventArgs e)
        {
            s.doTheDrawing(p,ref g); 
            e.Graphics.DrawImageUnscaled(bmaps[picked], 0, 0);
        }

        //zmiana trybu
        private void shapeOpt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch(shapeOpt.SelectedItem)
            {
                case "FreeMode":    this.s = new FreeDraw();    break;
                case "Line":        this.s = new Line();        break;
                case "Rectangle":   this.s = new Rectangle();   break;
            }
        }

        //zamykanie aplikacji
        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //maksymalizowanie okna 
        private void maximize_button_Click(object sender, EventArgs e)
        {
            if (isMax == false)
            {
                this.WindowState = FormWindowState.Maximized;
                canvas_Resize();
                max_tabs = 15;
                isMax = true;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 20));
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isMax = false;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 20));
            }
        }

        //minimalizowanie okna
        private void minimize_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //zmiana wielkości bitmapy względem okna
        private void canvas_Resize()
        {
            for (int i = 0; i < bmaps.Count; i++)
            {
                Bitmap temp = new Bitmap(bmaps[i]);
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, bmaps[i].Width, bmaps[i].Height);
                bmaps[i] = new Bitmap(canvas.Width, canvas.Height);
                Graphics gt = Graphics.FromImage(bmaps[i]);
                gt.DrawImage(temp, rect, rect, GraphicsUnit.Pixel);
            }
            g = Graphics.FromImage(bmaps[picked]);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        }

        //"złapanie" górnej belki
        private void bar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            m_pos = new Point(e.X, e.Y);
        }

        //poruszanie oknem
        private void bar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - m_pos.X;
                this.Top += e.Y - m_pos.Y;
            }
        }

        //dodawanie kart
        private void add_button_Click(object sender, EventArgs e)
        {
            if (tnum == max_tabs)
            {
                MessageBox.Show("Osiągnięto maksymalną ilość otwartych kart.");
                return;
            }
            add_tab();
        }

        //dodanie karty
        private void add_tab()
        {
            Panel tab_panel = new Panel();
            this.bar_panel.Controls.Add(tab_panel);
            tab_panel.Top = 3;
            tab_panel.Left = 35 + tnum * tabs_width;
            tab_panel.Width = tabs_width - 5;
            tab_panel.Height = 22;
            tab_panel.Name = "TAB " + this.tnum_name.ToString();
            tab_panel.BackColor = Color.Transparent;
            tab_panel.BackgroundImage = Properties.Resources.tab;
            tab_panel.BackgroundImageLayout = ImageLayout.Stretch;

            Button tab_exit = new Button();
            tab_panel.Controls.Add(tab_exit);
            tab_exit.Name = "TAB " + this.tnum_name.ToString();
            tab_exit.BackColor = Color.Transparent;
            tab_exit.BackgroundImage = Properties.Resources.cross;
            tab_exit.BackgroundImageLayout = ImageLayout.Stretch;
            tab_exit.Top = 0;
            tab_exit.Left = 73;
            tab_exit.Width = 22;
            tab_exit.Height = 22;
            tab_exit.Anchor = AnchorStyles.Right;
            tab_exit.Anchor = AnchorStyles.Top;
            tab_exit.FlatStyle = FlatStyle.Flat;
            tab_exit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            tab_exit.Click += new System.EventHandler(this.close_Tab);

            Label tab_label = new Label();
            tab_panel.Controls.Add(tab_label);
            tab_label.Top = 4;
            tab_label.Name = "TAB " + this.tnum_name.ToString();
            tab_label.Text = "New tab";
            tab_label.Click += new System.EventHandler(this.pick_Tab);

            labels.Add(tab_label);
            tabs.Add(tab_panel);
            new_bitmap();

            if(tnum == 0)
            {
                picked = 0;

                tabs[0].Height = 30;
                canvas.InitialImage = bmaps[0];
                g = Graphics.FromImage(bmaps[0]);
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            }
            tnum++;
            tnum_name++;
        }

        //zamknięcie karty
        private void close_Tab(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            for(int i=0; i<tabs.Count; i++)
                if(tabs[i].Name == temp.Name)
                {
                    shrink_tabs(tabs[i]);
                    this.bar_panel.Controls.Remove(tabs[i]);
                    tabs.RemoveAt(i);
                    bmaps.RemoveAt(i);
                    labels.RemoveAt(i);
                    tnum--;
                    if (tnum == 0)
                        Application.Exit();
                    if (i == picked && tnum != 0)
                    {
                        if (picked != 0)
                            picked--;
                        tabs[picked].Height = 30;
                        canvas.InitialImage = bmaps[picked];
                        g = Graphics.FromImage(bmaps[picked]);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        canvas.Refresh();
                        return;
                    }
                }
        }

        //wybranie karty
        private void pick_Tab(object sender, EventArgs e)
        {
            Label temp = sender as Label;
            for(int i=0; i<tabs.Count; i++)
            {
                if (tabs[i].Name == temp.Name)
                {
                    if (i != picked)
                    {
                        tabs[picked].Height = 22;
                        tabs[i].Height = 30;
                        picked = i;

                        canvas.InitialImage = bmaps[i];
                        g = Graphics.FromImage(bmaps[i]);
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        canvas.Refresh();
                    }
                }
            }
        }

        //przesówanie się kart po usówaniu
        private void shrink_tabs(Panel tab)
        {
            bool start = false;
            for (int i = 0; i < tabs.Count; i++)
            {
                if (start == true)
                {
                    tabs[i].Left -= 100;
                }
                if (tabs[i].Name == tab.Name)
                    start = true;
            }
        }

        //wczytywanie bitmapy z pliku
        private void load_but_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Bitmap temp = new Bitmap(fd.FileName);
                System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, temp.Width, temp.Height);
                bmaps[picked] = new Bitmap(temp.Width, temp.Height);
                Graphics gt = Graphics.FromImage(bmaps[picked]);
                gt.DrawImage(temp, rect, rect, GraphicsUnit.Pixel);
                labels[picked].Text = fd.SafeFileName;
            }
            g = Graphics.FromImage(bmaps[picked]);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            canvas.Refresh();
        }

        //zapisywanie bitmapy do pliku 
        private void save_but_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = labels[picked].Text;
            if (sf.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(sf.FileName))
                    System.IO.File.Delete(sf.FileName);
                bmaps[picked].Save(sf.FileName);
            }
                labels[picked].Text = System.IO.Path.GetFileName(sf.FileName);
        }
    }

    //klasa przechowująca punkty
    public static class PointsToDraw
    {
        public static Point start, stop, current, prevstep;
    }

    //abstrakcyjna klasa kształt
    public abstract class Shape
    {
        abstract public void doTheDrawing(Pen p,ref Graphics g);
    }
    
    //wolne rysowanie
    public class FreeDraw : Shape
    {
        override public void doTheDrawing(Pen p, ref Graphics g)
        {
            g.DrawLine(p, PointsToDraw.prevstep, PointsToDraw.current);
        }
    }

    //linie
    public class Line : Shape
    {
        override public void doTheDrawing(Pen p, ref Graphics g)
        {
            g.DrawLine(p, PointsToDraw.start, PointsToDraw.stop);
        }
    }

    //prostokąty
    public class Rectangle : Shape
    {
        override public void doTheDrawing(Pen p, ref Graphics g)
        {
            Point size = new Point();
            Point start = new Point();

            if (PointsToDraw.start.X < PointsToDraw.stop.X)
            {
                size.X = PointsToDraw.stop.X - PointsToDraw.start.X;
                start.X = PointsToDraw.start.X;
            }
            else if (PointsToDraw.start.X > PointsToDraw.stop.X)
            {
                size.X = PointsToDraw.start.X - PointsToDraw.stop.X;
                start.X = PointsToDraw.stop.X;
            }
            if (PointsToDraw.start.Y < PointsToDraw.stop.Y)
            {
                size.Y = PointsToDraw.stop.Y - PointsToDraw.start.Y;
                start.Y = PointsToDraw.start.Y;
            }
            else if(PointsToDraw.start.Y > PointsToDraw.stop.Y)
            {
                size.Y = PointsToDraw.start.Y - PointsToDraw.stop.Y;
                start.Y = PointsToDraw.stop.Y;
            }
            g.DrawRectangle(p, start.X, start.Y, size.X, size.Y);
        }
    }
}
