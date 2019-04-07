namespace MichalDzialekLab1_zadDom
{
    partial class Victory
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
            this.labelVictory = new System.Windows.Forms.Label();
            this.buttonVictoryReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelVictory
            // 
            this.labelVictory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVictory.BackColor = System.Drawing.Color.Transparent;
            this.labelVictory.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVictory.Location = new System.Drawing.Point(36, 9);
            this.labelVictory.Name = "labelVictory";
            this.labelVictory.Size = new System.Drawing.Size(733, 108);
            this.labelVictory.TabIndex = 0;
            this.labelVictory.Text = "Gratulacje, wygrałeś !";
            this.labelVictory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonVictoryReturn
            // 
            this.buttonVictoryReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVictoryReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonVictoryReturn.FlatAppearance.BorderSize = 0;
            this.buttonVictoryReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVictoryReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVictoryReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVictoryReturn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVictoryReturn.Location = new System.Drawing.Point(304, 341);
            this.buttonVictoryReturn.Name = "buttonVictoryReturn";
            this.buttonVictoryReturn.Size = new System.Drawing.Size(182, 97);
            this.buttonVictoryReturn.TabIndex = 1;
            this.buttonVictoryReturn.Text = "Powrót do menu";
            this.buttonVictoryReturn.UseVisualStyleBackColor = false;
            this.buttonVictoryReturn.Click += new System.EventHandler(this.buttonVictoryReturn_Click);
            // 
            // Victory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVictoryReturn);
            this.Controls.Add(this.labelVictory);
            this.Name = "Victory";
            this.Text = "Victory";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelVictory;
        private System.Windows.Forms.Button buttonVictoryReturn;
    }
}