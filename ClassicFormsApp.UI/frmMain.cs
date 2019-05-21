using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicFormsApp.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {            
            SetButtonLocations();
        }

        public void SetButtonLocations()
        {
            var bounds = this.Bounds;

            button1.Location = new Point(0, (int)(bounds.Height * 0.9f));
            button1.Size = new Size((int)(bounds.Width * 0.333f), (int)(bounds.Height * 0.1f));

            button2.Location = new Point((int)(bounds.Width * 0.333f), (int)(bounds.Height * 0.9f));
            button2.Size = new Size((int)(bounds.Width * 0.333f), (int)(bounds.Height * 0.1f));

            button3.Location = new Point((int)(bounds.Width * 0.333f) * 2, (int)(bounds.Height * 0.9f));
            button3.Size = new Size((int)(bounds.Width * 0.333f), (int)(bounds.Height * 0.1f));

            tabControl1.Size = new Size(bounds.Width, (int)(bounds.Height * 0.9f));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SetButtonLocations();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

    }
}
