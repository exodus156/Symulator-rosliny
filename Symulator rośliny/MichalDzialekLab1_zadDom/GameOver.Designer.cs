namespace MichalDzialekLab1_zadDom
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonGameOverReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGameOver
            // 
            this.labelGameOver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGameOver.Location = new System.Drawing.Point(7, 9);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(781, 175);
            this.labelGameOver.TabIndex = 0;
            this.labelGameOver.Text = "Przykro mi, ale przegrałeś :(";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGameOverReturn
            // 
            this.buttonGameOverReturn.BackColor = System.Drawing.Color.Transparent;
            this.buttonGameOverReturn.FlatAppearance.BorderSize = 0;
            this.buttonGameOverReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonGameOverReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonGameOverReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameOverReturn.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonGameOverReturn.Location = new System.Drawing.Point(310, 350);
            this.buttonGameOverReturn.Name = "buttonGameOverReturn";
            this.buttonGameOverReturn.Size = new System.Drawing.Size(182, 88);
            this.buttonGameOverReturn.TabIndex = 1;
            this.buttonGameOverReturn.Text = "Powrót do menu";
            this.buttonGameOverReturn.UseVisualStyleBackColor = false;
            this.buttonGameOverReturn.Click += new System.EventHandler(this.buttonGameOverReturn_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MichalDzialekLab1_zadDom.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGameOverReturn);
            this.Controls.Add(this.labelGameOver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOver";
            this.Text = "GameOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonGameOverReturn;
    }
}