using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace objectmove
{
    public partial class SecondLevel : Form
    {
        public SecondLevel()
        {
            InitializeComponent();
        }
        public bool isTouching(Control player, Control obj)
        {
            Rectangle objPlayer = player.Bounds;
            Rectangle objNesne = obj.Bounds;
            return objPlayer.IntersectsWith(objNesne);
        }
        private void secondlevel_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (isTouching(pctman, pctfinish))
            {
                timer1.Stop();
                MessageBox.Show("congratulations!", "Pass the second level", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
               
            }
        }

        private void secondlevel_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pctman.Location.X;
            int y = pctman.Location.Y;

            if (e.KeyCode == Keys.Right && x <= 750)
            {
                x = x + 5;
            }
            if (e.KeyCode == Keys.Left && x > 0)
            {
                x = x - 5;
            }
            if (e.KeyCode == Keys.Up && y > 0)
            {
                y = y - 5;
            }
            if (e.KeyCode == Keys.Down && y < 420)
            {
                y = y + 5;
            }
            if (isTouching(pctman, pct1))
            {
                pct1.Visible = false;

            }
            if (isTouching(pctman, pct2))
            {
                pct2.Visible = false;
            }
            if (isTouching(pctman, pct3))
            {
                pct3.Visible = false;
            }
            if (isTouching(pctman, pct4))
            {
                pct4.Visible = false;
            }
            if (isTouching(pctman, pc5))
            {
                pc5.Visible = false;
            }
            if (isTouching(pctman, pct6))
            {
                pct6.Visible = false;
            }


            if (isTouching(pctman, panel8))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel11))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();

            }
            if (isTouching(pctman, panel1))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel2))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel3))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel4))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel5))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel6))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel7))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel9))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel10))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel12))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel13))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel14))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel15))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel16))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel17))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            if (isTouching(pctman, panel18))
            {
                MessageBox.Show("GAME OVER", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            pctman.Location = new Point(x, y);
        }
    }
}
