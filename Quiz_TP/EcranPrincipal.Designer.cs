namespace Quiz_TP
{
    partial class FrmEcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSuivante = new System.Windows.Forms.Button();
            this.GboxQuestion = new System.Windows.Forms.GroupBox();
            this.BtnDemarrer = new System.Windows.Forms.Button();
            this.LblChoixQuiz = new System.Windows.Forms.Label();
            this.CmbMenuQuiz = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSuivante
            // 
            this.BtnSuivante.Location = new System.Drawing.Point(490, 339);
            this.BtnSuivante.Name = "BtnSuivante";
            this.BtnSuivante.Size = new System.Drawing.Size(93, 30);
            this.BtnSuivante.TabIndex = 15;
            this.BtnSuivante.Text = "Suivante";
            this.BtnSuivante.UseVisualStyleBackColor = true;
            this.BtnSuivante.Click += new System.EventHandler(this.BtnSuivante_Click);
            // 
            // GboxQuestion
            // 
            this.GboxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxQuestion.Location = new System.Drawing.Point(170, 127);
            this.GboxQuestion.Name = "GboxQuestion";
            this.GboxQuestion.Size = new System.Drawing.Size(413, 206);
            this.GboxQuestion.TabIndex = 14;
            this.GboxQuestion.TabStop = false;
            this.GboxQuestion.Text = "groupBox1";
            this.GboxQuestion.Enter += new System.EventHandler(this.GboxQuestion_Enter);
            // 
            // BtnDemarrer
            // 
            this.BtnDemarrer.Location = new System.Drawing.Point(170, 62);
            this.BtnDemarrer.Name = "BtnDemarrer";
            this.BtnDemarrer.Size = new System.Drawing.Size(75, 23);
            this.BtnDemarrer.TabIndex = 13;
            this.BtnDemarrer.Text = "Démarrer";
            this.BtnDemarrer.UseVisualStyleBackColor = true;
            this.BtnDemarrer.Click += new System.EventHandler(this.BtnDemarrer_Click);
            // 
            // LblChoixQuiz
            // 
            this.LblChoixQuiz.AutoSize = true;
            this.LblChoixQuiz.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChoixQuiz.Location = new System.Drawing.Point(12, 9);
            this.LblChoixQuiz.Name = "LblChoixQuiz";
            this.LblChoixQuiz.Size = new System.Drawing.Size(103, 19);
            this.LblChoixQuiz.TabIndex = 12;
            this.LblChoixQuiz.Text = "Choisir le quiz:";
            // 
            // CmbMenuQuiz
            // 
            this.CmbMenuQuiz.FormattingEnabled = true;
            this.CmbMenuQuiz.Location = new System.Drawing.Point(16, 34);
            this.CmbMenuQuiz.Name = "CmbMenuQuiz";
            this.CmbMenuQuiz.Size = new System.Drawing.Size(245, 21);
            this.CmbMenuQuiz.TabIndex = 11;
            // 
            // FrmEcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSuivante);
            this.Controls.Add(this.GboxQuestion);
            this.Controls.Add(this.BtnDemarrer);
            this.Controls.Add(this.LblChoixQuiz);
            this.Controls.Add(this.CmbMenuQuiz);
            this.Name = "FrmEcranPrincipal";
            this.Text = "Ecran Principale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSuivante;
        private System.Windows.Forms.GroupBox GboxQuestion;
        private System.Windows.Forms.Button BtnDemarrer;
        private System.Windows.Forms.Label LblChoixQuiz;
        private System.Windows.Forms.ComboBox CmbMenuQuiz;
    }
}

