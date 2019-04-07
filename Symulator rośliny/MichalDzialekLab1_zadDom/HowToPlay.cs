using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalDzialekLab1_zadDom
{
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Kontrola przycisku "Powrót" w okienku How to play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //Zamyka okieno How to play
            Close();
        }
    }
}
