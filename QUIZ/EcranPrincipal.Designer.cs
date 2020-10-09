namespace QUIZ
{
    partial class EcranPrincipal
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
            this.BtnSuivante = new System.Windows.Forms.Button();
            this.GboxQuestion = new System.Windows.Forms.GroupBox();
            this.BtnDemarrer = new System.Windows.Forms.Button();
            this.LblChoixQuiz = new System.Windows.Forms.Label();
            this.CmbMenuQuiz = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnSuivante
            // 
            this.BtnSuivante.Location = new System.Drawing.Point(604, 218);
            this.BtnSuivante.Name = "BtnSuivante";
            this.BtnSuivante.Size = new System.Drawing.Size(75, 48);
            this.BtnSuivante.TabIndex = 10;
            this.BtnSuivante.Text = "Suivante";
            this.BtnSuivante.UseVisualStyleBackColor = true;
            // 
            // GboxQuestion
            // 
            this.GboxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxQuestion.Location = new System.Drawing.Point(170, 127);
            this.GboxQuestion.Name = "GboxQuestion";
            this.GboxQuestion.Size = new System.Drawing.Size(413, 206);
            this.GboxQuestion.TabIndex = 9;
            this.GboxQuestion.TabStop = false;
            this.GboxQuestion.Text = "groupBox1";
            // 
            // BtnDemarrer
            // 
            this.BtnDemarrer.Location = new System.Drawing.Point(170, 62);
            this.BtnDemarrer.Name = "BtnDemarrer";
            this.BtnDemarrer.Size = new System.Drawing.Size(75, 23);
            this.BtnDemarrer.TabIndex = 8;
            this.BtnDemarrer.Text = "Démarrer";
            this.BtnDemarrer.UseVisualStyleBackColor = true;
            // 
            // LblChoixQuiz
            // 
            this.LblChoixQuiz.AutoSize = true;
            this.LblChoixQuiz.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChoixQuiz.Location = new System.Drawing.Point(12, 9);
            this.LblChoixQuiz.Name = "LblChoixQuiz";
            this.LblChoixQuiz.Size = new System.Drawing.Size(103, 19);
            this.LblChoixQuiz.TabIndex = 7;
            this.LblChoixQuiz.Text = "Choisir le quiz:";
            // 
            // CmbMenuQuiz
            // 
            this.CmbMenuQuiz.FormattingEnabled = true;
            this.CmbMenuQuiz.Location = new System.Drawing.Point(16, 34);
            this.CmbMenuQuiz.Name = "CmbMenuQuiz";
            this.CmbMenuQuiz.Size = new System.Drawing.Size(245, 21);
            this.CmbMenuQuiz.TabIndex = 6;
            this.CmbMenuQuiz.SelectedIndexChanged += new System.EventHandler(this.CmbMenuQuiz_SelectedIndexChanged);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSuivante);
            this.Controls.Add(this.GboxQuestion);
            this.Controls.Add(this.BtnDemarrer);
            this.Controls.Add(this.LblChoixQuiz);
            this.Controls.Add(this.CmbMenuQuiz);
            this.Name = "EcranPrincipal";
            this.Text = "Ecran Principal";
            this.Load += new System.EventHandler(this.EcranPrincipal_Load);
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