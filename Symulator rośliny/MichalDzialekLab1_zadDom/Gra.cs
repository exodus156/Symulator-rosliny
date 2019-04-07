using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MichalDzialekLab1_zadDom
{
   
    public partial class Gra : Form
    {
        public Gra()
        {
            InitializeComponent();
        }

        /// <summary>
        /// liczniki dla owadów i chwastów
        /// </summary>
        int counterOwady = 0;
        int counterChwasty = 0;

        /// <summary>
        /// Najważniejszy licznik, skaluje level rośliny + zwiększa poziom trudności
        /// </summary>
        int counterLevel = 0;

        /// <summary>
        /// Licznik do końca gry
        /// </summary>
        int counterEndGame = 0;

        /// <summary>
        /// Generator losowej ilości owadów
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomOwad(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        /// <summary>
        /// Generator losowej ilości chwastów
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int RandomChwast(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        //Tworzenie nowego licznika czasu
        System.Timers.Timer timepassed;
        int h, m, s;

        /// <summary>
        /// Kontrola przycisku rozpoczynającego gre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart2_Click(object sender, EventArgs e)
        {
            //Wyłączenie przycisku start, gdyż gra się uruchomiła
            buttonStart2.Enabled = false;
            buttonStart2.Visible = false;

            //Usunięcie podpisu pod przyciskiem start, gdyż gra już się uruchomiła
            labelStart2.Enabled = false;
            labelStart2.Visible = false;

            //Pojawienie się kontrolek
            buttonKonewka.Enabled = true;
            buttonKonewka.Visible = true;

            buttonNawoz.Enabled = true;
            buttonNawoz.Visible = true;

            buttonChwasty.Enabled = true;
            buttonChwasty.Visible = true;

            buttonOwadobojczy.Enabled = true;
            buttonOwadobojczy.Visible = true;

            buttonUltimate.Enabled = true;
            buttonUltimate.Visible = true;

            //Wyświetlenie liczników
            labelChwasty.Visible = true;
            labelChwastyIlosc.Visible = true;
            timerChwasty.Enabled = true;

            labelOwady.Visible = true;
            labelOwadyIlosc.Visible = true;
            timerOwady.Enabled = true;

            labelPoziomWody.Visible = true;
            labelStanNawozu.Visible = true;

            labelPoziomRosliny.Visible = true;
            labelPoziomRoslinyNumber.Visible = true;
            pictureBoxPoziom1.Visible = true;
            timerLevel.Enabled = true;
            
            //Kontrola timeru wody
            progressBarWoda.Visible = true;
            timerWoda.Enabled = true;

            //kontrola timeru nawozu
            progressBarNawoz.Visible = true;
            timerNawoz.Enabled = true;

            //Aktywowanie pomiaru czasu
            labelTimePassed.Visible = true;
            timepassed.Start();

            //kontrola progress barów dla narzędzi
            progressBarOwadobojczy.Visible = true;
            progressBarOdchwaszczacz.Visible = true;
            progressBarKonewka.Visible = true;
            progressBarDodajNawoz.Visible = true;
            progressBarUltimate.Visible = true;

            //Kontrola timerów narzędzi z lewej strony
            timerDodajNawoz.Enabled = true;
            timerKonweka.Enabled = true;
            timerOdchwaszczacz.Enabled = true;
            timerOwadobojczy.Enabled = true;
            timerUltimate.Enabled = true;

            //Aktywowanie utrudnień
            timerUtrudnienieChwasty.Enabled = true;
            timerUtrudnienieOwady.Enabled = true;

            //Aktywowanie timera dla przegranej
            timerGameOver.Enabled = true;
        }

        /// <summary>
        /// Zatrzymanie licznika czasu wraz z zamknięciem gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gra_FormClosing(object sender, FormClosingEventArgs e)
        {
            timepassed.Close();
        }

        /// <summary>
        /// kontrola przycisku konewka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonKonewka_Click(object sender, EventArgs e)
        {
            progressBarWoda.Value = 100;
            progressBarKonewka.Value = 0;
        }
        /// <summary>
        /// timer obsługujący zmniejszanie poziomu nawodnienia rośliny
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerWoda_Tick(object sender, EventArgs e)
        {
            progressBarWoda.Increment(-1);
            if (progressBarWoda.Value > 70)
            {
                progressBarWoda.SetState(1);
            }
            else if (progressBarWoda.Value > 30)
            {
                progressBarWoda.SetState(3);
            }
            else if (progressBarWoda.Value < 30)
            {
                progressBarWoda.SetState(2);
            }
        }
        /// <summary>
        /// timer obsługujący zmniejszanie poziomu nawozu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerNawoz_Tick(object sender, EventArgs e)
        {
            progressBarNawoz.Increment(-1);
            if (progressBarNawoz.Value >= 120)
            {
                progressBarNawoz.SetState(1);
            }
            else if (progressBarNawoz.Value >= 60)
            {
                progressBarNawoz.SetState(3);
            }
            else if (progressBarNawoz.Value <= 60)
            {
                progressBarNawoz.SetState(2);
            }
        }
        /// <summary>
        /// timer osbługujący ilość owadów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOwady_Tick(object sender, EventArgs e)
        {
            counterOwady++;
            if(counterOwady == 120)
            {
                int IloscOwadow = Int32.Parse(labelOwadyIlosc.Text);
                int sumaOwadow = IloscOwadow + RandomOwad(0, 4);
                labelOwadyIlosc.Text = string.Format("{0}", sumaOwadow.ToString());
                labelOwadyIlosc.Refresh();
                counterOwady = 0;
            }
        }
        /// <summary>
        /// timer obsługujący ilość chwastów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerChwasty_Tick(object sender, EventArgs e)
        {
            counterChwasty++;
            if (counterChwasty == 120)
            {
                int IloscChwastow = Int32.Parse(labelChwastyIlosc.Text);
                int sumaChwastow = IloscChwastow + RandomChwast(0, 4);
                labelChwastyIlosc.Text = string.Format("{0}", sumaChwastow.ToString());
                labelChwastyIlosc.Refresh();
                counterChwasty = 0;
            }
        }
        
        /// <summary>
        /// Timer obsługujący pasek konewki
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerKonweka_Tick(object sender, EventArgs e)
        {
            progressBarKonewka.Increment(10);
            if(progressBarKonewka.Value == 100)
            {
                progressBarKonewka.Visible = false;
                buttonKonewka.Enabled = true;
            }
            else if(progressBarKonewka.Value < 100)
            {
                progressBarKonewka.Visible = true;
                buttonKonewka.Enabled = false;
            }
        }

        /// <summary>
        /// Timer obsługujący pasek dodania nawozu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDodajNawoz_Tick(object sender, EventArgs e)
        {
            progressBarDodajNawoz.Increment(8);
            if(progressBarDodajNawoz.Value == 100)
            {
                progressBarDodajNawoz.Visible = false;
                buttonNawoz.Enabled = true;
            }
            else if(progressBarDodajNawoz.Value < 100)
            {
                progressBarDodajNawoz.Visible = true;
                buttonNawoz.Enabled = false;
            }
        }

        /// <summary>
        /// Timer obsługujący pasek odchwaszczacza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOdchwaszczacz_Tick(object sender, EventArgs e)
        {
            progressBarOdchwaszczacz.Increment(6);
            if(progressBarOdchwaszczacz.Value == 100)
            {
                progressBarOdchwaszczacz.Visible = false;
                buttonChwasty.Enabled = true;
            }
            else if(progressBarOdchwaszczacz.Value < 100)
            {
                progressBarOdchwaszczacz.Visible = true;
                buttonChwasty.Enabled = false;
            }
        }

        /// <summary>
        /// Timer obsługujący pasek owadobójczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerOwadobojczy_Tick(object sender, EventArgs e)
        {
            progressBarOwadobojczy.Increment(6);
            if(progressBarOwadobojczy.Value == 100)
            {
                progressBarOwadobojczy.Visible = false;
                buttonOwadobojczy.Enabled = true;
            }
            else if(progressBarOwadobojczy.Value < 100)
            {
                progressBarOwadobojczy.Visible = true;
                buttonOwadobojczy.Enabled = false;
            }
        }

        /// <summary>
        /// Zatrzymanie licznika czasu wraz z zamknięciem gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gra_FormClosed(object sender, FormClosedEventArgs e)
        {
            timepassed.Stop();
        }

        /// <summary>
        /// kontrola przycisku dodaj nawóz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNawoz_Click(object sender, EventArgs e)
        {
            progressBarDodajNawoz.Value = 0;
            progressBarNawoz.Value = 200;
        }

        /// <summary>
        /// kontrola przycisku odchwaszczacz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChwasty_Click(object sender, EventArgs e)
        {
            progressBarOdchwaszczacz.Value = 0;
            int chwasty = Int32.Parse(labelChwastyIlosc.Text);
            if(chwasty <= 0)
            {
                chwasty = 0;
                labelChwastyIlosc.Text = string.Format("{0}", chwasty.ToString());
            }
            else if(chwasty > 0)
            {
                chwasty -= 5;
                labelChwastyIlosc.Text = string.Format("{0}", chwasty.ToString());
                if (chwasty <= 0)
                {
                    chwasty = 0;
                    labelChwastyIlosc.Text = string.Format("{0}", chwasty.ToString());
                }
            }
        }

        /// <summary>
        /// kontrola przycisku owadobójczego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOwadobojczy_Click(object sender, EventArgs e)
        {
            progressBarOwadobojczy.Value = 0;
            int owady = Int32.Parse(labelOwadyIlosc.Text);
            if(owady <= 0)
            {
                owady = 0;
                labelOwadyIlosc.Text = string.Format("{0}", owady.ToString());
            }
            else if(owady > 0)
            {
                owady -= 5;
                labelOwadyIlosc.Text = string.Format("{0}", owady.ToString());
                if (owady <= 0)
                {
                    owady = 0;
                    labelOwadyIlosc.Text = string.Format("{0}", owady.ToString());
                }
            }
        }

        /// <summary>
        /// Dodanie utrudnienia dla ilości owadów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUtrudnienieOwady_Tick(object sender, EventArgs e)
        {
            int owady = Int32.Parse(labelOwadyIlosc.Text);
            if(owady == 0)
            {
                timerWoda.Interval = 1000;
            }
            else if(owady < 15)
            {
                timerWoda.Interval = 750;
            }
            else if (owady < 20)
            {
                timerWoda.Interval = 500;
            }
            else if (owady < 25)
            {
                timerWoda.Interval = 250;
            }
            else if (owady < 50)
            {
                timerWoda.Interval = 100;
            }
        }

        /// <summary>
        /// Dodanie utrudnienia dla ilości chwastów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUtrudnienieChwasty_Tick(object sender, EventArgs e)
        {
            int chwasty = Int32.Parse(labelChwastyIlosc.Text);
            if(chwasty == 0)
            {
                timerNawoz.Interval = 1000;
            }
            else if(chwasty < 15)
            {
                timerNawoz.Interval = 750;
            }
            else if (chwasty < 20)
            {
                timerNawoz.Interval = 500;
            }
            else if (chwasty < 25)
            {
                timerNawoz.Interval = 250;
            }
            else if (chwasty < 50)
            {
                timerNawoz.Interval = 100;
            }
        }

        /// <summary>
        /// Kontrola paska ultimate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUltimate_Tick(object sender, EventArgs e)
        {
            progressBarUltimate.Increment(1);
            if (progressBarUltimate.Value == 120)
            {
                progressBarUltimate.Visible = false;
                buttonUltimate.Enabled = true;
            }
            else if (progressBarUltimate.Value < 120)
            {
                progressBarUltimate.Visible = true;
                buttonUltimate.Enabled = false;
            }

        }

        /// <summary>
        /// kontrola przycisku ultimate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUltimate_Click(object sender, EventArgs e)
        {
            progressBarUltimate.Value = 0;

            //Usuwanie owadów
            int owady = Int32.Parse(labelOwadyIlosc.Text);
            owady = 0;
            labelOwadyIlosc.Text = string.Format("{0}", owady.ToString());

            //Usuwanie chwastów
            int chwasty = Int32.Parse(labelChwastyIlosc.Text);
            chwasty = 0;
            labelChwastyIlosc.Text = string.Format("{0}", chwasty.ToString());

        }

        private void timerLevel_Tick(object sender, EventArgs e)
        {
            counterLevel++;
            if(counterLevel == 180)
            {
                //Pojawienie się obrazka dla poziomu 2
                pictureBoxPoziom1.Visible = false;
                pictureBoxPoziom2.Visible = true;

                //Zmiana numeru levelu rośliny
                labelPoziomRoslinyNumber.Text = 2.ToString();

                //Przyspieszenie nr.1
                timerOwady.Interval = 800;
                timerChwasty.Interval = 800;
            }
            else if (counterLevel == 360)
            {
                //Pojawienie się obrazka dla poziomu 3
                pictureBoxPoziom2.Visible = false;
                pictureBoxPoziom3.Visible = true;

                //Zmiana numeru levelu rośliny
                labelPoziomRoslinyNumber.Text = 3.ToString();

                //Przyspieszenie nr.2
                timerOwady.Interval = 650;
                timerChwasty.Interval = 650;
            }
            else if (counterLevel == 540)
            {
                //Pojawienie się obrazka dla poziomu 4
                pictureBoxPoziom3.Visible = false;
                pictureBoxPoziom4.Visible = true;

                //Zmiana numeru levelu rośliny
                labelPoziomRoslinyNumber.Text = 4.ToString();

                //Przyspieszenie nr.3
                timerOwady.Interval = 525;
                timerChwasty.Interval = 525;
            }
            else if (counterLevel == 720)
            {
                //Pojawienie się obrazka dla poziomu 5
                pictureBoxPoziom4.Visible = false;
                pictureBoxPoziom5.Visible = true;

                //Zmiana numeru levelu rośliny
                labelPoziomRoslinyNumber.Text = 5.ToString();

                //Przyspieszenie nr.4
                timerOwady.Interval = 400;
                timerChwasty.Interval = 400;

                //Uruchomienie ostatniego timera
                timerEndGame.Enabled = true;
            }
            else if (counterLevel == 780)
            {
                //Przyspieszenie nr.5
                timerOwady.Interval = 200;
                timerChwasty.Interval = 200;
            }
            else if (counterLevel == 840)
            {
                //Przyspieszenie nr.6
                timerOwady.Interval = 100;
                timerChwasty.Interval = 100;
            }
        }

        /// <summary>
        /// Timer dla przycisku koniec gry, niewidoczny dla gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            counterEndGame++;
            if(counterEndGame == 120)
            {
                buttonEndGame.Enabled = true;
                buttonEndGame.Visible = true;
            }
        }

        /// <summary>
        /// przycisk kończący grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEndGame_Click(object sender, EventArgs e)
        {
            Victory victory = new Victory();
            victory.Show();
            Close();
        }

        /// <summary>
        /// Timer dla przegranej gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerGameOver_Tick(object sender, EventArgs e)
        {
           if(progressBarWoda.Value == 0 && progressBarNawoz.Value == 0)
            {
                GameOver gameover = new GameOver();
                gameover.Show();
                Close();
            }
        }

        /// <summary>
        /// Licznik czasu który minął
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Gra_Load(object sender, EventArgs e)
        {
           timepassed = new System.Timers.Timer();
            timepassed.Interval = 1000;
            timepassed.Elapsed += OnTimeEvent;
        }

        /// <summary>
        /// Modyfikowanie czasu aby miał podział na godziny/minuty/sekundy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
           {
           s += 1;
           //sekundy na minuty
           if (s == 60)
           {
               s = 0;
               m += 1;
           }
           //minuty na godziny
           if (m == 60)
           {
               m = 0;
               h += 1;
           }
           labelTimePassed.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
           labelTimePassed.Refresh();
           }));
        }

    }
    /// <summary>
    /// Dynamiczna zmiana koloru paska postępu
    /// </summary>
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
