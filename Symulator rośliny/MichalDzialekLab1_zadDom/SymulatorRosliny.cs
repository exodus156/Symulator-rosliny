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
    public partial class SymulatorRosliny : Form
    {
        public SymulatorRosliny()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kontrola tytułu aplikacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTitle_Click(object sender, EventArgs e)
        {
            //Przeźroczyste tło tytułu
            BackColor = Color.Transparent;
        }
        /// <summary>
        /// Kontrola przycisku zamykającego aplikację
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Zamyknięcie aplikacji
            Close();
        }
        /// <summary>
        /// Kontrola przycisku "Jak grać"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHowToPlay_Click(object sender, EventArgs e)
        {
            //Tworzenie obiektu howToPlay z klasy HowToPlay
            HowToPlay howToPlay = new HowToPlay();
            //Wyświetlanie strony howToPlay
            howToPlay.Show();
        }
        /// <summary>
        /// Kontrola przycisku start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart1_Click(object sender, EventArgs e)
        {
            //Tworzenie obiektu gra z klasy Gra
            Gra gra = new Gra();
            //Wyświetlanie strony gra
            gra.Show();

        }
    }
}
