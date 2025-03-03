using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timeSight
{
    public partial class timeSight : Form
    {
        public timeSight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timeSight_Load(object sender, EventArgs e)
        {

        }

        #region Navbar position
        private void Form1_Load(object sender, EventArgs e)
        {
            panelNavbar.Dock = DockStyle.Bottom; // Default position
        }
        #endregion



        #region snapToEdge
        private void SnapToMiddle()
        {
            int screenWidth = this.ClientSize.Width; // Why is 'this' here? What does it do?
            int screenHeight = this.ClientSize.Height;
            int panelWidth = panelNavbar.Width;
            int panelHeight = panelNavbar.Height;

            // Define distance to edges
            int leftDistance = panelNavbar.Left;
            int rightDistance = screenWidth - (panelNavbar.Left + panelWidth);
            int topDistance = panelNavbar.Top;
            int bottomDistance = screenHeight - (panelNavbar.Top + panelHeight);

            int minDistance = Math.Min(Math.Min(leftDistance, rightDistance), Math.Min(topDistance, bottomDistance));

            if (minDistance == leftDistance)
            {
                //panelNavbar.Dock = DockStyle.Left;
                panelNavbar.Left = 0;
                panelNavbar.Top = (screenHeight - panelHeight) / 2;
            }
            else if (minDistance == rightDistance)
            {
                panelNavbar.Left = screenWidth - panelWidth;
                panelNavbar.Top = (screenHeight - panelHeight) / 2;
            }
            else if (minDistance == topDistance)
            {
                panelNavbar.Top = 0;
                panelNavbar.Left = (screenWidth - panelWidth) / 2;
            }
            else
            {
                panelNavbar.Top = screenHeight - panelHeight;
                panelNavbar.Left = (screenWidth - panelWidth) / 2;
            }
        }

        #endregion

        #region dragPanel
        private bool isDragging = false;
        private Point dragStart;

        private Size originalSize; // Store the original size
        private Control[] childControls; // Store child controls
        private void panelNavbar_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStart = e.Location;

            // Store the original size before collapsing
            originalSize = panelNavbar.Size;

            // Store and hide child controls
            childControls = panelNavbar.Controls.Cast<Control>().ToArray();
            foreach (var control in childControls)
            {
                control.Visible = false;
            }

            // Set new collapsed size
            int collapsedSize = 80; // Diameter of the circular shape
            panelNavbar.Size = new Size(collapsedSize, collapsedSize);
            panelNavbar.BackColor = Color.Aqua;

            // Create a circular region
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, collapsedSize, collapsedSize);
            panelNavbar.Region = new Region(path);
        }

        private void panelNavbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Move the panel based on the mouse movement
                this.panelNavbar.Left += e.X - dragStart.X;
                this.panelNavbar.Top += e.Y - dragStart.Y;
            }
        }

        private void panelNavbar_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;

            // Restore original size
            panelNavbar.Size = originalSize;
            panelNavbar.Region = null; // Reset shape
            panelNavbar.BackColor = SystemColors.Control; // Restore default background

            // Show child controls again
            foreach (var control in childControls)
            {
                control.Visible = true;
            }

            SnapToMiddle(); // Snap to the middle of each side
        }
        #endregion
    }
}
