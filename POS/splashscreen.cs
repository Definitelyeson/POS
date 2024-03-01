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


namespace POS
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
        
            InitializeComponent();
           
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
