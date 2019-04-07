namespace MichalDzialekLab1_zadDom
{
    partial class SymulatorRosliny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymulatorRosliny));
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonStart1 = new System.Windows.Forms.Button();
            this.buttonHowToPlay = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.Location = new System.Drawing.Point(122, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(548, 84);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Symulator Rośliny";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // buttonStart1
            // 
            this.buttonStart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart1.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStart1.FlatAppearance.BorderSize = 0;
            this.buttonStart1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.buttonStart1.Location = new System.Drawing.Point(326, 203);
            this.buttonStart1.Name = "buttonStart1";
            this.buttonStart1.Size = new System.Drawing.Size(149, 49);
            this.buttonStart1.TabIndex = 1;
            this.buttonStart1.Text = "Start";
            this.buttonStart1.UseVisualStyleBackColor = false;
            this.buttonStart1.Click += new System.EventHandler(this.buttonStart1_Click);
            // 
            // buttonHowToPlay
            // 
            this.buttonHowToPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.transparent;
            this.buttonHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHowToPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonHowToPlay.FlatAppearance.BorderSize = 0;
            this.buttonHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHowToPlay.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.buttonHowToPlay.Location = new System.Drawing.Point(267, 278);
            this.buttonHowToPlay.Name = "buttonHowToPlay";
            this.buttonHowToPlay.Size = new System.Drawing.Size(261, 63);
            this.buttonHowToPlay.TabIndex = 4;
            this.buttonHowToPlay.Text = "Jak grać";
            this.buttonHowToPlay.UseVisualStyleBackColor = false;
            this.buttonHowToPlay.Click += new System.EventHandler(this.buttonHowToPlay_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.transparent;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(296, 372);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(197, 50);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Wyjście";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // SymulatorRosliny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHowToPlay);
            this.Controls.Add(this.buttonStart1);
            this.Controls.Add(this.labelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SymulatorRosliny";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonStart1;
        private System.Windows.Forms.Button buttonHowToPlay;
        private System.Windows.Forms.Button buttonExit;
    }
}

