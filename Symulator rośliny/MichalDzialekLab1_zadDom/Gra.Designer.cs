namespace MichalDzialekLab1_zadDom
{
    partial class Gra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gra));
            this.buttonStart2 = new System.Windows.Forms.Button();
            this.labelStart2 = new System.Windows.Forms.Label();
            this.buttonKonewka = new System.Windows.Forms.Button();
            this.buttonNawoz = new System.Windows.Forms.Button();
            this.buttonChwasty = new System.Windows.Forms.Button();
            this.buttonUltimate = new System.Windows.Forms.Button();
            this.buttonOwadobojczy = new System.Windows.Forms.Button();
            this.labelTimePassed = new System.Windows.Forms.Label();
            this.labelOwady = new System.Windows.Forms.Label();
            this.labelOwadyIlosc = new System.Windows.Forms.Label();
            this.labelChwasty = new System.Windows.Forms.Label();
            this.labelChwastyIlosc = new System.Windows.Forms.Label();
            this.labelPoziomWody = new System.Windows.Forms.Label();
            this.labelStanNawozu = new System.Windows.Forms.Label();
            this.progressBarWoda = new System.Windows.Forms.ProgressBar();
            this.progressBarNawoz = new System.Windows.Forms.ProgressBar();
            this.timerWoda = new System.Windows.Forms.Timer(this.components);
            this.timerNawoz = new System.Windows.Forms.Timer(this.components);
            this.timerOwady = new System.Windows.Forms.Timer(this.components);
            this.timerChwasty = new System.Windows.Forms.Timer(this.components);
            this.progressBarKonewka = new System.Windows.Forms.ProgressBar();
            this.progressBarDodajNawoz = new System.Windows.Forms.ProgressBar();
            this.progressBarOdchwaszczacz = new System.Windows.Forms.ProgressBar();
            this.progressBarOwadobojczy = new System.Windows.Forms.ProgressBar();
            this.timerKonweka = new System.Windows.Forms.Timer(this.components);
            this.timerDodajNawoz = new System.Windows.Forms.Timer(this.components);
            this.timerOdchwaszczacz = new System.Windows.Forms.Timer(this.components);
            this.timerOwadobojczy = new System.Windows.Forms.Timer(this.components);
            this.timerUtrudnienieOwady = new System.Windows.Forms.Timer(this.components);
            this.timerUtrudnienieChwasty = new System.Windows.Forms.Timer(this.components);
            this.progressBarUltimate = new System.Windows.Forms.ProgressBar();
            this.timerUltimate = new System.Windows.Forms.Timer(this.components);
            this.timerLevel = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPoziom1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoziom2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoziom3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoziom4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPoziom5 = new System.Windows.Forms.PictureBox();
            this.labelPoziomRosliny = new System.Windows.Forms.Label();
            this.labelPoziomRoslinyNumber = new System.Windows.Forms.Label();
            this.buttonEndGame = new System.Windows.Forms.Button();
            this.timerEndGame = new System.Windows.Forms.Timer(this.components);
            this.timerGameOver = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom5)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart2
            // 
            this.buttonStart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart2.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart2.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.start;
            this.buttonStart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart2.FlatAppearance.BorderSize = 0;
            this.buttonStart2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart2.Location = new System.Drawing.Point(308, 107);
            this.buttonStart2.Name = "buttonStart2";
            this.buttonStart2.Size = new System.Drawing.Size(171, 164);
            this.buttonStart2.TabIndex = 0;
            this.buttonStart2.UseVisualStyleBackColor = false;
            this.buttonStart2.Click += new System.EventHandler(this.buttonStart2_Click);
            // 
            // labelStart2
            // 
            this.labelStart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStart2.AutoSize = true;
            this.labelStart2.BackColor = System.Drawing.Color.Transparent;
            this.labelStart2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStart2.Location = new System.Drawing.Point(197, 274);
            this.labelStart2.Name = "labelStart2";
            this.labelStart2.Size = new System.Drawing.Size(398, 35);
            this.labelStart2.TabIndex = 1;
            this.labelStart2.Text = "Kliknij na obrazek aby rozpocząć";
            // 
            // buttonKonewka
            // 
            this.buttonKonewka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonKonewka.BackColor = System.Drawing.Color.Transparent;
            this.buttonKonewka.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Konewka;
            this.buttonKonewka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKonewka.Enabled = false;
            this.buttonKonewka.FlatAppearance.BorderSize = 0;
            this.buttonKonewka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonKonewka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonKonewka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKonewka.Location = new System.Drawing.Point(12, 12);
            this.buttonKonewka.Name = "buttonKonewka";
            this.buttonKonewka.Size = new System.Drawing.Size(75, 51);
            this.buttonKonewka.TabIndex = 2;
            this.buttonKonewka.UseVisualStyleBackColor = false;
            this.buttonKonewka.Visible = false;
            this.buttonKonewka.Click += new System.EventHandler(this.buttonKonewka_Click);
            // 
            // buttonNawoz
            // 
            this.buttonNawoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNawoz.BackColor = System.Drawing.Color.Transparent;
            this.buttonNawoz.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Nawoz;
            this.buttonNawoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNawoz.Enabled = false;
            this.buttonNawoz.FlatAppearance.BorderSize = 0;
            this.buttonNawoz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonNawoz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonNawoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNawoz.Location = new System.Drawing.Point(12, 69);
            this.buttonNawoz.Name = "buttonNawoz";
            this.buttonNawoz.Size = new System.Drawing.Size(75, 63);
            this.buttonNawoz.TabIndex = 3;
            this.buttonNawoz.UseVisualStyleBackColor = false;
            this.buttonNawoz.Visible = false;
            this.buttonNawoz.Click += new System.EventHandler(this.buttonNawoz_Click);
            // 
            // buttonChwasty
            // 
            this.buttonChwasty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChwasty.BackColor = System.Drawing.Color.Transparent;
            this.buttonChwasty.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Chwasty;
            this.buttonChwasty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonChwasty.Enabled = false;
            this.buttonChwasty.FlatAppearance.BorderSize = 0;
            this.buttonChwasty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonChwasty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonChwasty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChwasty.Location = new System.Drawing.Point(12, 138);
            this.buttonChwasty.Name = "buttonChwasty";
            this.buttonChwasty.Size = new System.Drawing.Size(75, 83);
            this.buttonChwasty.TabIndex = 4;
            this.buttonChwasty.UseVisualStyleBackColor = false;
            this.buttonChwasty.Visible = false;
            this.buttonChwasty.Click += new System.EventHandler(this.buttonChwasty_Click);
            // 
            // buttonUltimate
            // 
            this.buttonUltimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUltimate.BackColor = System.Drawing.Color.Transparent;
            this.buttonUltimate.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Przesadz;
            this.buttonUltimate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUltimate.Enabled = false;
            this.buttonUltimate.FlatAppearance.BorderSize = 0;
            this.buttonUltimate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonUltimate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonUltimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUltimate.Location = new System.Drawing.Point(12, 311);
            this.buttonUltimate.Name = "buttonUltimate";
            this.buttonUltimate.Size = new System.Drawing.Size(75, 85);
            this.buttonUltimate.TabIndex = 5;
            this.buttonUltimate.UseVisualStyleBackColor = false;
            this.buttonUltimate.Visible = false;
            this.buttonUltimate.Click += new System.EventHandler(this.buttonUltimate_Click);
            // 
            // buttonOwadobojczy
            // 
            this.buttonOwadobojczy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOwadobojczy.BackColor = System.Drawing.Color.Transparent;
            this.buttonOwadobojczy.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Owadobojczy;
            this.buttonOwadobojczy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOwadobojczy.Enabled = false;
            this.buttonOwadobojczy.FlatAppearance.BorderSize = 0;
            this.buttonOwadobojczy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOwadobojczy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOwadobojczy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOwadobojczy.Location = new System.Drawing.Point(12, 227);
            this.buttonOwadobojczy.Name = "buttonOwadobojczy";
            this.buttonOwadobojczy.Size = new System.Drawing.Size(62, 78);
            this.buttonOwadobojczy.TabIndex = 6;
            this.buttonOwadobojczy.UseVisualStyleBackColor = false;
            this.buttonOwadobojczy.Visible = false;
            this.buttonOwadobojczy.Click += new System.EventHandler(this.buttonOwadobojczy_Click);
            // 
            // labelTimePassed
            // 
            this.labelTimePassed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimePassed.AutoSize = true;
            this.labelTimePassed.BackColor = System.Drawing.Color.Transparent;
            this.labelTimePassed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimePassed.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimePassed.Location = new System.Drawing.Point(371, 38);
            this.labelTimePassed.Name = "labelTimePassed";
            this.labelTimePassed.Size = new System.Drawing.Size(86, 25);
            this.labelTimePassed.TabIndex = 7;
            this.labelTimePassed.Text = "00:00:00";
            this.labelTimePassed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTimePassed.Visible = false;
            // 
            // labelOwady
            // 
            this.labelOwady.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOwady.AutoSize = true;
            this.labelOwady.BackColor = System.Drawing.Color.Transparent;
            this.labelOwady.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOwady.Location = new System.Drawing.Point(687, 38);
            this.labelOwady.Name = "labelOwady";
            this.labelOwady.Size = new System.Drawing.Size(73, 25);
            this.labelOwady.TabIndex = 8;
            this.labelOwady.Text = "Owady:";
            this.labelOwady.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOwady.Visible = false;
            // 
            // labelOwadyIlosc
            // 
            this.labelOwadyIlosc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOwadyIlosc.AutoSize = true;
            this.labelOwadyIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelOwadyIlosc.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOwadyIlosc.Location = new System.Drawing.Point(766, 38);
            this.labelOwadyIlosc.Name = "labelOwadyIlosc";
            this.labelOwadyIlosc.Size = new System.Drawing.Size(22, 25);
            this.labelOwadyIlosc.TabIndex = 9;
            this.labelOwadyIlosc.Text = "0";
            this.labelOwadyIlosc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOwadyIlosc.Visible = false;
            // 
            // labelChwasty
            // 
            this.labelChwasty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChwasty.AutoSize = true;
            this.labelChwasty.BackColor = System.Drawing.Color.Transparent;
            this.labelChwasty.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChwasty.Location = new System.Drawing.Point(674, 86);
            this.labelChwasty.Name = "labelChwasty";
            this.labelChwasty.Size = new System.Drawing.Size(86, 25);
            this.labelChwasty.TabIndex = 10;
            this.labelChwasty.Text = "Chwasty:";
            this.labelChwasty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChwasty.Visible = false;
            // 
            // labelChwastyIlosc
            // 
            this.labelChwastyIlosc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelChwastyIlosc.AutoSize = true;
            this.labelChwastyIlosc.BackColor = System.Drawing.Color.Transparent;
            this.labelChwastyIlosc.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelChwastyIlosc.Location = new System.Drawing.Point(766, 86);
            this.labelChwastyIlosc.Name = "labelChwastyIlosc";
            this.labelChwastyIlosc.Size = new System.Drawing.Size(22, 25);
            this.labelChwastyIlosc.TabIndex = 11;
            this.labelChwastyIlosc.Text = "0";
            this.labelChwastyIlosc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChwastyIlosc.Visible = false;
            // 
            // labelPoziomWody
            // 
            this.labelPoziomWody.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPoziomWody.AutoSize = true;
            this.labelPoziomWody.BackColor = System.Drawing.Color.Transparent;
            this.labelPoziomWody.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomWody.Location = new System.Drawing.Point(668, 165);
            this.labelPoziomWody.Name = "labelPoziomWody";
            this.labelPoziomWody.Size = new System.Drawing.Size(120, 25);
            this.labelPoziomWody.TabIndex = 12;
            this.labelPoziomWody.Text = "Poziom wody:";
            this.labelPoziomWody.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPoziomWody.Visible = false;
            // 
            // labelStanNawozu
            // 
            this.labelStanNawozu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelStanNawozu.AutoSize = true;
            this.labelStanNawozu.BackColor = System.Drawing.Color.Transparent;
            this.labelStanNawozu.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStanNawozu.Location = new System.Drawing.Point(667, 246);
            this.labelStanNawozu.Name = "labelStanNawozu";
            this.labelStanNawozu.Size = new System.Drawing.Size(121, 25);
            this.labelStanNawozu.TabIndex = 13;
            this.labelStanNawozu.Text = "Stan nawozu:";
            this.labelStanNawozu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStanNawozu.Visible = false;
            // 
            // progressBarWoda
            // 
            this.progressBarWoda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarWoda.Location = new System.Drawing.Point(679, 198);
            this.progressBarWoda.Name = "progressBarWoda";
            this.progressBarWoda.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarWoda.RightToLeftLayout = true;
            this.progressBarWoda.Size = new System.Drawing.Size(100, 23);
            this.progressBarWoda.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarWoda.TabIndex = 14;
            this.progressBarWoda.Value = 100;
            this.progressBarWoda.Visible = false;
            // 
            // progressBarNawoz
            // 
            this.progressBarNawoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarNawoz.Location = new System.Drawing.Point(679, 282);
            this.progressBarNawoz.Maximum = 200;
            this.progressBarNawoz.Name = "progressBarNawoz";
            this.progressBarNawoz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressBarNawoz.RightToLeftLayout = true;
            this.progressBarNawoz.Size = new System.Drawing.Size(100, 23);
            this.progressBarNawoz.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarNawoz.TabIndex = 15;
            this.progressBarNawoz.Value = 200;
            this.progressBarNawoz.Visible = false;
            // 
            // timerWoda
            // 
            this.timerWoda.Interval = 1000;
            this.timerWoda.Tick += new System.EventHandler(this.timerWoda_Tick);
            // 
            // timerNawoz
            // 
            this.timerNawoz.Interval = 1000;
            this.timerNawoz.Tick += new System.EventHandler(this.timerNawoz_Tick);
            // 
            // timerOwady
            // 
            this.timerOwady.Interval = 1000;
            this.timerOwady.Tick += new System.EventHandler(this.timerOwady_Tick);
            // 
            // timerChwasty
            // 
            this.timerChwasty.Interval = 1000;
            this.timerChwasty.Tick += new System.EventHandler(this.timerChwasty_Tick);
            // 
            // progressBarKonewka
            // 
            this.progressBarKonewka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarKonewka.Location = new System.Drawing.Point(93, 31);
            this.progressBarKonewka.Name = "progressBarKonewka";
            this.progressBarKonewka.Size = new System.Drawing.Size(76, 22);
            this.progressBarKonewka.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarKonewka.TabIndex = 16;
            this.progressBarKonewka.Value = 100;
            this.progressBarKonewka.Visible = false;
            // 
            // progressBarDodajNawoz
            // 
            this.progressBarDodajNawoz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarDodajNawoz.Location = new System.Drawing.Point(93, 89);
            this.progressBarDodajNawoz.Name = "progressBarDodajNawoz";
            this.progressBarDodajNawoz.Size = new System.Drawing.Size(76, 22);
            this.progressBarDodajNawoz.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarDodajNawoz.TabIndex = 17;
            this.progressBarDodajNawoz.Value = 100;
            this.progressBarDodajNawoz.Visible = false;
            // 
            // progressBarOdchwaszczacz
            // 
            this.progressBarOdchwaszczacz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarOdchwaszczacz.Location = new System.Drawing.Point(93, 165);
            this.progressBarOdchwaszczacz.Name = "progressBarOdchwaszczacz";
            this.progressBarOdchwaszczacz.Size = new System.Drawing.Size(76, 22);
            this.progressBarOdchwaszczacz.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarOdchwaszczacz.TabIndex = 18;
            this.progressBarOdchwaszczacz.Value = 100;
            this.progressBarOdchwaszczacz.Visible = false;
            // 
            // progressBarOwadobojczy
            // 
            this.progressBarOwadobojczy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarOwadobojczy.Location = new System.Drawing.Point(93, 258);
            this.progressBarOwadobojczy.Name = "progressBarOwadobojczy";
            this.progressBarOwadobojczy.Size = new System.Drawing.Size(76, 22);
            this.progressBarOwadobojczy.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarOwadobojczy.TabIndex = 19;
            this.progressBarOwadobojczy.Value = 100;
            this.progressBarOwadobojczy.Visible = false;
            // 
            // timerKonweka
            // 
            this.timerKonweka.Interval = 1000;
            this.timerKonweka.Tick += new System.EventHandler(this.timerKonweka_Tick);
            // 
            // timerDodajNawoz
            // 
            this.timerDodajNawoz.Interval = 1000;
            this.timerDodajNawoz.Tick += new System.EventHandler(this.timerDodajNawoz_Tick);
            // 
            // timerOdchwaszczacz
            // 
            this.timerOdchwaszczacz.Interval = 1000;
            this.timerOdchwaszczacz.Tick += new System.EventHandler(this.timerOdchwaszczacz_Tick);
            // 
            // timerOwadobojczy
            // 
            this.timerOwadobojczy.Interval = 1000;
            this.timerOwadobojczy.Tick += new System.EventHandler(this.timerOwadobojczy_Tick);
            // 
            // timerUtrudnienieOwady
            // 
            this.timerUtrudnienieOwady.Tick += new System.EventHandler(this.timerUtrudnienieOwady_Tick);
            // 
            // timerUtrudnienieChwasty
            // 
            this.timerUtrudnienieChwasty.Tick += new System.EventHandler(this.timerUtrudnienieChwasty_Tick);
            // 
            // progressBarUltimate
            // 
            this.progressBarUltimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarUltimate.Location = new System.Drawing.Point(93, 350);
            this.progressBarUltimate.Maximum = 120;
            this.progressBarUltimate.Name = "progressBarUltimate";
            this.progressBarUltimate.Size = new System.Drawing.Size(76, 22);
            this.progressBarUltimate.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarUltimate.TabIndex = 20;
            this.progressBarUltimate.Value = 120;
            this.progressBarUltimate.Visible = false;
            // 
            // timerUltimate
            // 
            this.timerUltimate.Interval = 1000;
            this.timerUltimate.Tick += new System.EventHandler(this.timerUltimate_Tick);
            // 
            // timerLevel
            // 
            this.timerLevel.Interval = 1000;
            this.timerLevel.Tick += new System.EventHandler(this.timerLevel_Tick);
            // 
            // pictureBoxPoziom1
            // 
            this.pictureBoxPoziom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoziom1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoziom1.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Poziom0;
            this.pictureBoxPoziom1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPoziom1.Location = new System.Drawing.Point(278, 258);
            this.pictureBoxPoziom1.Name = "pictureBoxPoziom1";
            this.pictureBoxPoziom1.Size = new System.Drawing.Size(250, 121);
            this.pictureBoxPoziom1.TabIndex = 21;
            this.pictureBoxPoziom1.TabStop = false;
            this.pictureBoxPoziom1.Visible = false;
            // 
            // pictureBoxPoziom2
            // 
            this.pictureBoxPoziom2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoziom2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoziom2.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Poziom1;
            this.pictureBoxPoziom2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPoziom2.Location = new System.Drawing.Point(324, 198);
            this.pictureBoxPoziom2.Name = "pictureBoxPoziom2";
            this.pictureBoxPoziom2.Size = new System.Drawing.Size(155, 173);
            this.pictureBoxPoziom2.TabIndex = 22;
            this.pictureBoxPoziom2.TabStop = false;
            this.pictureBoxPoziom2.Visible = false;
            // 
            // pictureBoxPoziom3
            // 
            this.pictureBoxPoziom3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoziom3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoziom3.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Poziom2;
            this.pictureBoxPoziom3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPoziom3.Location = new System.Drawing.Point(324, 178);
            this.pictureBoxPoziom3.Name = "pictureBoxPoziom3";
            this.pictureBoxPoziom3.Size = new System.Drawing.Size(175, 218);
            this.pictureBoxPoziom3.TabIndex = 23;
            this.pictureBoxPoziom3.TabStop = false;
            this.pictureBoxPoziom3.Visible = false;
            // 
            // pictureBoxPoziom4
            // 
            this.pictureBoxPoziom4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoziom4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoziom4.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Poziom3;
            this.pictureBoxPoziom4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPoziom4.Location = new System.Drawing.Point(308, 133);
            this.pictureBoxPoziom4.Name = "pictureBoxPoziom4";
            this.pictureBoxPoziom4.Size = new System.Drawing.Size(209, 263);
            this.pictureBoxPoziom4.TabIndex = 24;
            this.pictureBoxPoziom4.TabStop = false;
            this.pictureBoxPoziom4.Visible = false;
            // 
            // pictureBoxPoziom5
            // 
            this.pictureBoxPoziom5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPoziom5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPoziom5.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.Poziom4;
            this.pictureBoxPoziom5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPoziom5.Location = new System.Drawing.Point(308, 86);
            this.pictureBoxPoziom5.Name = "pictureBoxPoziom5";
            this.pictureBoxPoziom5.Size = new System.Drawing.Size(207, 313);
            this.pictureBoxPoziom5.TabIndex = 25;
            this.pictureBoxPoziom5.TabStop = false;
            this.pictureBoxPoziom5.Visible = false;
            // 
            // labelPoziomRosliny
            // 
            this.labelPoziomRosliny.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPoziomRosliny.AutoSize = true;
            this.labelPoziomRosliny.BackColor = System.Drawing.Color.Transparent;
            this.labelPoziomRosliny.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomRosliny.Location = new System.Drawing.Point(627, 326);
            this.labelPoziomRosliny.Name = "labelPoziomRosliny";
            this.labelPoziomRosliny.Size = new System.Drawing.Size(133, 25);
            this.labelPoziomRosliny.TabIndex = 26;
            this.labelPoziomRosliny.Text = "Poziom rośliny:";
            this.labelPoziomRosliny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPoziomRosliny.Visible = false;
            // 
            // labelPoziomRoslinyNumber
            // 
            this.labelPoziomRoslinyNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPoziomRoslinyNumber.AutoSize = true;
            this.labelPoziomRoslinyNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPoziomRoslinyNumber.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoziomRoslinyNumber.Location = new System.Drawing.Point(766, 326);
            this.labelPoziomRoslinyNumber.Name = "labelPoziomRoslinyNumber";
            this.labelPoziomRoslinyNumber.Size = new System.Drawing.Size(22, 25);
            this.labelPoziomRoslinyNumber.TabIndex = 27;
            this.labelPoziomRoslinyNumber.Text = "1";
            this.labelPoziomRoslinyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPoziomRoslinyNumber.Visible = false;
            // 
            // buttonEndGame
            // 
            this.buttonEndGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonEndGame.Enabled = false;
            this.buttonEndGame.FlatAppearance.BorderSize = 0;
            this.buttonEndGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonEndGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonEndGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndGame.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEndGame.Location = new System.Drawing.Point(681, 376);
            this.buttonEndGame.Name = "buttonEndGame";
            this.buttonEndGame.Size = new System.Drawing.Size(107, 62);
            this.buttonEndGame.TabIndex = 28;
            this.buttonEndGame.Text = "Koniec Gry";
            this.buttonEndGame.UseVisualStyleBackColor = false;
            this.buttonEndGame.Visible = false;
            this.buttonEndGame.Click += new System.EventHandler(this.buttonEndGame_Click);
            // 
            // timerEndGame
            // 
            this.timerEndGame.Interval = 1000;
            this.timerEndGame.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // timerGameOver
            // 
            this.timerGameOver.Interval = 1000;
            this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
            // 
            // Gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEndGame);
            this.Controls.Add(this.labelPoziomRoslinyNumber);
            this.Controls.Add(this.labelPoziomRosliny);
            this.Controls.Add(this.pictureBoxPoziom5);
            this.Controls.Add(this.pictureBoxPoziom4);
            this.Controls.Add(this.pictureBoxPoziom3);
            this.Controls.Add(this.pictureBoxPoziom2);
            this.Controls.Add(this.pictureBoxPoziom1);
            this.Controls.Add(this.progressBarUltimate);
            this.Controls.Add(this.progressBarOwadobojczy);
            this.Controls.Add(this.progressBarOdchwaszczacz);
            this.Controls.Add(this.progressBarDodajNawoz);
            this.Controls.Add(this.progressBarKonewka);
            this.Controls.Add(this.progressBarNawoz);
            this.Controls.Add(this.progressBarWoda);
            this.Controls.Add(this.labelStanNawozu);
            this.Controls.Add(this.labelPoziomWody);
            this.Controls.Add(this.labelChwastyIlosc);
            this.Controls.Add(this.labelChwasty);
            this.Controls.Add(this.labelOwadyIlosc);
            this.Controls.Add(this.labelOwady);
            this.Controls.Add(this.labelTimePassed);
            this.Controls.Add(this.buttonOwadobojczy);
            this.Controls.Add(this.buttonUltimate);
            this.Controls.Add(this.buttonChwasty);
            this.Controls.Add(this.buttonNawoz);
            this.Controls.Add(this.buttonKonewka);
            this.Controls.Add(this.labelStart2);
            this.Controls.Add(this.buttonStart2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gra";
            this.Text = "Gra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gra_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Gra_FormClosed);
            this.Load += new System.EventHandler(this.Gra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoziom5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart2;
        private System.Windows.Forms.Label labelStart2;
        private System.Windows.Forms.Button buttonKonewka;
        private System.Windows.Forms.Button buttonNawoz;
        private System.Windows.Forms.Button buttonChwasty;
        private System.Windows.Forms.Button buttonUltimate;
        private System.Windows.Forms.Button buttonOwadobojczy;
        private System.Windows.Forms.Label labelTimePassed;
        private System.Windows.Forms.Label labelOwady;
        private System.Windows.Forms.Label labelOwadyIlosc;
        private System.Windows.Forms.Label labelChwasty;
        private System.Windows.Forms.Label labelChwastyIlosc;
        private System.Windows.Forms.Label labelPoziomWody;
        private System.Windows.Forms.Label labelStanNawozu;
        private System.Windows.Forms.ProgressBar progressBarWoda;
        private System.Windows.Forms.ProgressBar progressBarNawoz;
        private System.Windows.Forms.Timer timerWoda;
        private System.Windows.Forms.Timer timerNawoz;
        private System.Windows.Forms.Timer timerOwady;
        private System.Windows.Forms.Timer timerChwasty;
        private System.Windows.Forms.ProgressBar progressBarKonewka;
        private System.Windows.Forms.ProgressBar progressBarDodajNawoz;
        private System.Windows.Forms.ProgressBar progressBarOdchwaszczacz;
        private System.Windows.Forms.ProgressBar progressBarOwadobojczy;
        private System.Windows.Forms.Timer timerKonweka;
        private System.Windows.Forms.Timer timerDodajNawoz;
        private System.Windows.Forms.Timer timerOdchwaszczacz;
        private System.Windows.Forms.Timer timerOwadobojczy;
        private System.Windows.Forms.Timer timerUtrudnienieOwady;
        private System.Windows.Forms.Timer timerUtrudnienieChwasty;
        private System.Windows.Forms.ProgressBar progressBarUltimate;
        private System.Windows.Forms.Timer timerUltimate;
        private System.Windows.Forms.Timer timerLevel;
        private System.Windows.Forms.PictureBox pictureBoxPoziom1;
        private System.Windows.Forms.PictureBox pictureBoxPoziom2;
        private System.Windows.Forms.PictureBox pictureBoxPoziom3;
        private System.Windows.Forms.PictureBox pictureBoxPoziom4;
        private System.Windows.Forms.PictureBox pictureBoxPoziom5;
        private System.Windows.Forms.Label labelPoziomRosliny;
        private System.Windows.Forms.Label labelPoziomRoslinyNumber;
        private System.Windows.Forms.Button buttonEndGame;
        private System.Windows.Forms.Timer timerEndGame;
        private System.Windows.Forms.Timer timerGameOver;
    }
}