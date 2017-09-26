using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Greeting_card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sureButton.Visible = false;
        }
            
        private void cardButton_Click(object sender, EventArgs e)
        {

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Brown, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Brown);

            cardButton.Visible = false;
            BackColor = Color.Green;
            
             sureButton.Visible = true;
            
            
            
        }

        private void Sure_Click(object sender, EventArgs e)
        {
            sureButton.Visible = false;
            Refresh();
            Thread.Sleep(500);

            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);

            formGraphics.DrawLine(drawPen, 100, 225, 50, 75);
        }
    }
}
