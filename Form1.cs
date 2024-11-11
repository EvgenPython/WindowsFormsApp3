using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private int _width = 500;
        private int _height = 400;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            this.Width = _width;
            this.Height = _height;
            timer1.Tick += new EventHandler(_update);
            timer1.Interval = 1000;
            timer1.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }
        public void letters()
        {
            Random r = new Random();
            symbol = new Label();
            symbol.Text = Convert.ToChar(r.Next(97, 122)).ToString().ToUpper() + "\n";
            int x = r.Next(10, _width - 10);
            while (a <= _height)
            {
                symbol.Location = new Point(x, 10 + a);
                this.Controls.Add(symbol);
                this.Refresh();
                a += 10;
            }
                
        }
        public void _update(object myUpdate, EventArgs eventsArgs)
        {
            letters();
        }
        public void OKP(object sender, KeyEventArgs e)
        {
            MessageBox.Show(e.KeyCode.ToString());
            if (e.KeyCode.ToString() == symbol.Text)
            {
                letters();
            }
        }
    }
}
