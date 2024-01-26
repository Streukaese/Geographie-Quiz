namespace GeographieQuizBenotet
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.radioButtonFlagge = new System.Windows.Forms.RadioButton();
            this.radioButtonHauptstadt = new System.Windows.Forms.RadioButton();
            this.radioButtonLaender = new System.Windows.Forms.RadioButton();
            this.buttonHighscoreSpeichern = new System.Windows.Forms.Button();
            this.buttonAuswahlSpielen = new System.Windows.Forms.Button();
            this.dataGridViewHighscore = new System.Windows.Forms.DataGridView();
            this.highscoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(87, 16);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Spielername:";
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(12, 28);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(147, 22);
            this.textBoxLoginName.TabIndex = 1;
            this.textBoxLoginName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginName.Click += new System.EventHandler(this.textBoxLoginName_Click);
            // 
            // radioButtonFlagge
            // 
            this.radioButtonFlagge.AutoSize = true;
            this.radioButtonFlagge.Location = new System.Drawing.Point(575, 12);
            this.radioButtonFlagge.Name = "radioButtonFlagge";
            this.radioButtonFlagge.Size = new System.Drawing.Size(185, 20);
            this.radioButtonFlagge.TabIndex = 3;
            this.radioButtonFlagge.TabStop = true;
            this.radioButtonFlagge.Text = "Geographie Quiz: Flaggen";
            this.radioButtonFlagge.UseVisualStyleBackColor = true;
            // 
            // radioButtonHauptstadt
            // 
            this.radioButtonHauptstadt.AutoSize = true;
            this.radioButtonHauptstadt.Location = new System.Drawing.Point(575, 68);
            this.radioButtonHauptstadt.Name = "radioButtonHauptstadt";
            this.radioButtonHauptstadt.Size = new System.Drawing.Size(200, 20);
            this.radioButtonHauptstadt.TabIndex = 4;
            this.radioButtonHauptstadt.TabStop = true;
            this.radioButtonHauptstadt.Text = "Geographie Quiz: Hauptstadt";
            this.radioButtonHauptstadt.UseVisualStyleBackColor = true;
            // 
            // radioButtonLaender
            // 
            this.radioButtonLaender.AutoSize = true;
            this.radioButtonLaender.Location = new System.Drawing.Point(575, 123);
            this.radioButtonLaender.Name = "radioButtonLaender";
            this.radioButtonLaender.Size = new System.Drawing.Size(177, 20);
            this.radioButtonLaender.TabIndex = 5;
            this.radioButtonLaender.TabStop = true;
            this.radioButtonLaender.Text = "Geographie Quiz: Länder";
            this.radioButtonLaender.UseVisualStyleBackColor = true;
            // 
            // buttonHighscoreSpeichern
            // 
            this.buttonHighscoreSpeichern.Location = new System.Drawing.Point(250, 17);
            this.buttonHighscoreSpeichern.Name = "buttonHighscoreSpeichern";
            this.buttonHighscoreSpeichern.Size = new System.Drawing.Size(149, 43);
            this.buttonHighscoreSpeichern.TabIndex = 6;
            this.buttonHighscoreSpeichern.Text = "Highscore\r\nSpeichern\r\n";
            this.buttonHighscoreSpeichern.UseVisualStyleBackColor = true;
            this.buttonHighscoreSpeichern.Click += new System.EventHandler(this.buttonHighscoreSpeichern_Click);
            // 
            // buttonAuswahlSpielen
            // 
            this.buttonAuswahlSpielen.Location = new System.Drawing.Point(603, 187);
            this.buttonAuswahlSpielen.Name = "buttonAuswahlSpielen";
            this.buttonAuswahlSpielen.Size = new System.Drawing.Size(149, 52);
            this.buttonAuswahlSpielen.TabIndex = 7;
            this.buttonAuswahlSpielen.Text = "Jetzt \"Auswahl\" Spielen!";
            this.buttonAuswahlSpielen.UseVisualStyleBackColor = true;
            this.buttonAuswahlSpielen.Click += new System.EventHandler(this.buttonAuswahlSpielen_Click);
            // 
            // dataGridViewHighscore
            // 
            this.dataGridViewHighscore.AllowUserToAddRows = false;
            this.dataGridViewHighscore.AllowUserToDeleteRows = false;
            this.dataGridViewHighscore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHighscore.Location = new System.Drawing.Point(15, 83);
            this.dataGridViewHighscore.Name = "dataGridViewHighscore";
            this.dataGridViewHighscore.ReadOnly = true;
            this.dataGridViewHighscore.RowHeadersWidth = 51;
            this.dataGridViewHighscore.RowTemplate.Height = 24;
            this.dataGridViewHighscore.Size = new System.Drawing.Size(536, 187);
            this.dataGridViewHighscore.TabIndex = 9;
            // 
            // highscoreBindingSource
            // 
            this.highscoreBindingSource.DataSource = typeof(GeographieQuizBenotet.Highscore);
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 282);
            this.Controls.Add(this.dataGridViewHighscore);
            this.Controls.Add(this.buttonAuswahlSpielen);
            this.Controls.Add(this.buttonHighscoreSpeichern);
            this.Controls.Add(this.radioButtonLaender);
            this.Controls.Add(this.radioButtonHauptstadt);
            this.Controls.Add(this.radioButtonFlagge);
            this.Controls.Add(this.textBoxLoginName);
            this.Controls.Add(this.labelLogin);
            this.Name = "Hauptfenster";
            this.Text = "Login - Quiz Auswahl";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.RadioButton radioButtonFlagge;
        private System.Windows.Forms.RadioButton radioButtonHauptstadt;
        private System.Windows.Forms.RadioButton radioButtonLaender;
        private System.Windows.Forms.Button buttonHighscoreSpeichern;
        private System.Windows.Forms.Button buttonAuswahlSpielen;
        private System.Windows.Forms.DataGridView dataGridViewHighscore;
        private System.Windows.Forms.BindingSource highscoreBindingSource;
    }
}

