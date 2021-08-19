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

namespace Airline_M_S
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            Thread th = new Thread(new ThreadStart(Loading));
            th.Start();
            InitializeComponent();

            for(int i=0;i<=1000;i++)
            {
                Thread.Sleep(10);
            }
            th.Abort();
        }

        void Loading()
        {
            Formloading sp = new Formloading();
            Application.Run(sp);
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formhome Y = new Formhome();
            Y.Show();
            
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
