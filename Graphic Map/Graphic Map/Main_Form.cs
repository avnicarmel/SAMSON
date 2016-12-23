using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Graphic_Map
{   
    public partial class Main_Form : Form
    {
        private static System.Timers.Timer aTimer;
        Graphics graph;
        bool drawpoint, drawicon = false;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void ChangeMap_b_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Picture Files (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Map_Panel.BackgroundImage = Image.FromFile(dlg.FileName);
            }
        }

        private void DrawPoint_b_Click(object sender, EventArgs e)
        {
            drawpoint = true;
            drawicon = false;
            Main_Form.ActiveForm.Refresh();
        }

        private void DrawIcon_b_Click(object sender, EventArgs e)
        {
            drawicon = true;
            drawpoint = false;
            Main_Form.ActiveForm.Refresh();
        }

        private void Grid_ch_CheckedChanged(object sender, EventArgs e)
        {
            PaintEventArgs me = new PaintEventArgs(graph, new Rectangle());

            if (Grid_ch.Checked == false)
                Main_Form.ActiveForm.Refresh();
            else
                Map_Panel_Paint(sender, me);
        }

        private void Map_Panel_MouseEnter(object sender, EventArgs e)
        {
            LatLon_p.Visible = true;
        }

        private void Map_Panel_MouseLeave(object sender, EventArgs e)
        {
            LatLon_p.Visible = false;
        }

        private void Map_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            // Show appropriate coordinate point on the bottom of map panel

            double temp1 = e.X / 2.0;
            if (temp1 >= 180)
            {
                EW_l.Text = "East";
                long_l.Text = (temp1 - 180).ToString();
            }
            else
            {
                EW_l.Text = "West";
                long_l.Text = (180 - temp1).ToString();
            }

            double temp2 = e.Y / 2.0;
            if (temp2 <= 90)
            {
                NS_l.Text = "North";
                lat_l.Text = (90 - temp2).ToString();
            }
            else
            {
                NS_l.Text = "South";
                lat_l.Text = (temp2 - 90).ToString();
            }
        }

        private void Map_Panel_Paint(object sender, PaintEventArgs e)
        {
            // Checking for drawing grid, point and icon
            string[] lines;
            lines = System.IO.File.ReadAllLines(@"C:\Users\maoreliy\Graphic Map\Graphic Map\2D.txt");
            #region Draw Point
            for (int i=0; i <400;i++) { 
            if (drawpoint)
            {
                    Thread.Sleep(20);
                    //double lon = Convert.ToDouble(long_t.Text);
                    // double lat = Convert.ToDouble(lat_t.Text);
                    double lon = double.Parse((lines[i].Split('\t'))[1]);
                    double lat = double.Parse((lines[i].Split('\t'))[0]);
                if (lon > 180 || lon < -180)
                {
                    drawpoint = false;
                    MessageBox.Show("Invalid Longitude");
                    return;
                }

                if (lat > 90 || lat < -90)
                {
                    drawpoint = false;
                    MessageBox.Show("Invalid Latitude");
                    return;
                }

                e.Graphics.FillEllipse(Brushes.Yellow, (float)((lon * 2) + 360 - 2), (float)(180 - (lat * 2) - 2), 5, 5);
            }
            #endregion
        }

            #region Draw Icon
            if (drawicon)
            {
                double lon = Convert.ToDouble(long_t.Text);
                double lat = Convert.ToDouble(lat_t.Text);

                if (lon > 180 || lon < -180)
                {
                    drawicon = false;
                    MessageBox.Show("Invalid Longitude");
                    return;
                }

                if (lat > 90 || lat < -90)
                {
                    drawicon = false;
                    MessageBox.Show("Invalid Latitude");
                    return;
                }

                e.Graphics.DrawImage((Image)(Graphic_Map.Properties.Resources.icon), new Rectangle((int)((lon * 2) + 360 - 11), (int)(180 - (lat * 2) - 11), 23, 23));
            }
            #endregion

            #region Draw Grid
            if (Grid_ch.Checked == true)
            {
                Pen pen = new Pen(Color.DodgerBlue);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
                Point point1 = new Point();
                Point point2 = new Point();

                for (int i = -150; i < 160; i += 30)
                {
                    point1.X = ((i * 2) + 360);
                    point1.Y = (180 - (90 * 2));

                    point2.X = ((i * 2) + 360);
                    point2.Y = (180 - (-90 * 2));

                    e.Graphics.DrawLine(pen, point1, point2);
                }

                for (int i = -60; i < 70; i += 30)
                {
                    point1.X = ((-180 * 2) + 360);
                    point1.Y = (180 - (i * 2));

                    point2.X = ((180 * 2) + 360);
                    point2.Y = (180 - (i * 2));

                    e.Graphics.DrawLine(pen, point1, point2);
                }
            }
            #endregion
        }

        private void lat_l_Click(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            graph = Map_Panel.CreateGraphics();
        }
    }
}
