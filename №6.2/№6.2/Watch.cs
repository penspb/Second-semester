using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._2
{
    /// <summary>
    /// class watch
    /// </summary>
    public partial class Watch : Form
    {
        /// <summary>
        /// timer
        /// </summary>
        private Timer timer = new Timer();

        /// <summary>
        /// initialize
        /// </summary>
        public Watch()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockFace.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
