namespace GeographieQuizBenotet
{
    partial class Quiz
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
            this.pictureBoxQuizBild = new System.Windows.Forms.PictureBox();
            this.labelQuizAnzeigeFrageNr = new System.Windows.Forms.Label();
            this.buttonQuizAntwort1 = new System.Windows.Forms.Button();
            this.buttonQuizAntwort2 = new System.Windows.Forms.Button();
            this.buttonQuizAntwort3 = new System.Windows.Forms.Button();
            this.buttonQuizAntwort4 = new System.Windows.Forms.Button();
            this.labelQuizFrage = new System.Windows.Forms.Label();
            this.labelQuizPunkte = new System.Windows.Forms.Label();
            this.labelQuizLand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuizBild)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxQuizBild
            // 
            this.pictureBoxQuizBild.ErrorImage = null;
            this.pictureBoxQuizBild.InitialImage = null;
            this.pictureBoxQuizBild.Location = new System.Drawing.Point(156, 28);
            this.pictureBoxQuizBild.Name = "pictureBoxQuizBild";
            this.pictureBoxQuizBild.Size = new System.Drawing.Size(540, 298);
            this.pictureBoxQuizBild.TabIndex = 0;
            this.pictureBoxQuizBild.TabStop = false;
            // 
            // labelQuizAnzeigeFrageNr
            // 
            this.labelQuizAnzeigeFrageNr.AutoSize = true;
            this.labelQuizAnzeigeFrageNr.Location = new System.Drawing.Point(397, 9);
            this.labelQuizAnzeigeFrageNr.Name = "labelQuizAnzeigeFrageNr";
            this.labelQuizAnzeigeFrageNr.Size = new System.Drawing.Size(95, 16);
            this.labelQuizAnzeigeFrageNr.TabIndex = 1;
            this.labelQuizAnzeigeFrageNr.Text = "Frage 1 von 10";
            // 
            // buttonQuizAntwort1
            // 
            this.buttonQuizAntwort1.Location = new System.Drawing.Point(92, 393);
            this.buttonQuizAntwort1.Name = "buttonQuizAntwort1";
            this.buttonQuizAntwort1.Size = new System.Drawing.Size(305, 56);
            this.buttonQuizAntwort1.TabIndex = 2;
            this.buttonQuizAntwort1.Text = "Antwort 1";
            this.buttonQuizAntwort1.UseVisualStyleBackColor = true;
            this.buttonQuizAntwort1.Click += new System.EventHandler(this.pruefeAntwortEvent_Click);
            // 
            // buttonQuizAntwort2
            // 
            this.buttonQuizAntwort2.Location = new System.Drawing.Point(447, 393);
            this.buttonQuizAntwort2.Name = "buttonQuizAntwort2";
            this.buttonQuizAntwort2.Size = new System.Drawing.Size(305, 56);
            this.buttonQuizAntwort2.TabIndex = 3;
            this.buttonQuizAntwort2.Text = "Antwort 2";
            this.buttonQuizAntwort2.UseVisualStyleBackColor = true;
            this.buttonQuizAntwort2.Click += new System.EventHandler(this.pruefeAntwortEvent_Click);
            // 
            // buttonQuizAntwort3
            // 
            this.buttonQuizAntwort3.Location = new System.Drawing.Point(92, 473);
            this.buttonQuizAntwort3.Name = "buttonQuizAntwort3";
            this.buttonQuizAntwort3.Size = new System.Drawing.Size(305, 56);
            this.buttonQuizAntwort3.TabIndex = 4;
            this.buttonQuizAntwort3.Text = "Antwort 3";
            this.buttonQuizAntwort3.UseVisualStyleBackColor = true;
            this.buttonQuizAntwort3.Click += new System.EventHandler(this.pruefeAntwortEvent_Click);
            // 
            // buttonQuizAntwort4
            // 
            this.buttonQuizAntwort4.Location = new System.Drawing.Point(447, 473);
            this.buttonQuizAntwort4.Name = "buttonQuizAntwort4";
            this.buttonQuizAntwort4.Size = new System.Drawing.Size(305, 56);
            this.buttonQuizAntwort4.TabIndex = 5;
            this.buttonQuizAntwort4.Text = "Antwort 4";
            this.buttonQuizAntwort4.UseVisualStyleBackColor = true;
            this.buttonQuizAntwort4.Click += new System.EventHandler(this.pruefeAntwortEvent_Click);
            // 
            // labelQuizFrage
            // 
            this.labelQuizFrage.AutoSize = true;
            this.labelQuizFrage.Location = new System.Drawing.Point(288, 348);
            this.labelQuizFrage.Name = "labelQuizFrage";
            this.labelQuizFrage.Size = new System.Drawing.Size(336, 16);
            this.labelQuizFrage.TabIndex = 6;
            this.labelQuizFrage.Text = "\"Hier stehen die Fragen für das Quiz im Bezug zum Bild\"";
            // 
            // labelQuizPunkte
            // 
            this.labelQuizPunkte.AutoSize = true;
            this.labelQuizPunkte.Location = new System.Drawing.Point(12, 28);
            this.labelQuizPunkte.Name = "labelQuizPunkte";
            this.labelQuizPunkte.Size = new System.Drawing.Size(129, 48);
            this.labelQuizPunkte.TabIndex = 7;
            this.labelQuizPunkte.Text = "\"Hier stehen die Pkt\"\r\n<Richtig 1 von 2>\r\nPunkte 3!";
            // 
            // labelQuizLand
            // 
            this.labelQuizLand.AutoSize = true;
            this.labelQuizLand.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizLand.Location = new System.Drawing.Point(366, 144);
            this.labelQuizLand.Name = "labelQuizLand";
            this.labelQuizLand.Size = new System.Drawing.Size(149, 55);
            this.labelQuizLand.TabIndex = 8;
            this.labelQuizLand.Text = "Doener";
            this.labelQuizLand.Visible = false;
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 541);
            this.Controls.Add(this.labelQuizLand);
            this.Controls.Add(this.labelQuizPunkte);
            this.Controls.Add(this.labelQuizFrage);
            this.Controls.Add(this.buttonQuizAntwort4);
            this.Controls.Add(this.buttonQuizAntwort3);
            this.Controls.Add(this.buttonQuizAntwort2);
            this.Controls.Add(this.buttonQuizAntwort1);
            this.Controls.Add(this.labelQuizAnzeigeFrageNr);
            this.Controls.Add(this.pictureBoxQuizBild);
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuizBild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxQuizBild;
        private System.Windows.Forms.Label labelQuizAnzeigeFrageNr;
        private System.Windows.Forms.Button buttonQuizAntwort1;
        private System.Windows.Forms.Button buttonQuizAntwort2;
        private System.Windows.Forms.Button buttonQuizAntwort3;
        private System.Windows.Forms.Button buttonQuizAntwort4;
        private System.Windows.Forms.Label labelQuizFrage;
        private System.Windows.Forms.Label labelQuizPunkte;
        private System.Windows.Forms.Label labelQuizLand;
    }
}