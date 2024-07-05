namespace EncontrarPares
{
    partial class Form2
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
            EmpezarBtn = new Button();
            label1 = new Label();
            radioButtonDificultadFacil = new RadioButton();
            radioButtonDificultadMedia = new RadioButton();
            radioButtonDificultadDificil = new RadioButton();
            SuspendLayout();
            // 
            // EmpezarBtn
            // 
            EmpezarBtn.Anchor = AnchorStyles.Bottom;
            EmpezarBtn.Enabled = false;
            EmpezarBtn.Location = new Point(244, 287);
            EmpezarBtn.Margin = new Padding(4);
            EmpezarBtn.Name = "EmpezarBtn";
            EmpezarBtn.Size = new Size(96, 32);
            EmpezarBtn.TabIndex = 0;
            EmpezarBtn.Text = "Empezar";
            EmpezarBtn.UseVisualStyleBackColor = true;
            EmpezarBtn.Click += EmpezarBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(174, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 24);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la dificultad";
            // 
            // radioButtonDificultadFacil
            // 
            radioButtonDificultadFacil.Anchor = AnchorStyles.None;
            radioButtonDificultadFacil.AutoSize = true;
            radioButtonDificultadFacil.Location = new Point(220, 80);
            radioButtonDificultadFacil.Margin = new Padding(4);
            radioButtonDificultadFacil.Name = "radioButtonDificultadFacil";
            radioButtonDificultadFacil.Size = new Size(148, 25);
            radioButtonDificultadFacil.TabIndex = 2;
            radioButtonDificultadFacil.Text = "Facil (10 vidas)";
            radioButtonDificultadFacil.UseVisualStyleBackColor = true;
            radioButtonDificultadFacil.CheckedChanged += radioButtonDificultadFacil_CheckedChanged;
            // 
            // radioButtonDificultadMedia
            // 
            radioButtonDificultadMedia.Anchor = AnchorStyles.None;
            radioButtonDificultadMedia.AutoSize = true;
            radioButtonDificultadMedia.Location = new Point(220, 138);
            radioButtonDificultadMedia.Margin = new Padding(4);
            radioButtonDificultadMedia.Name = "radioButtonDificultadMedia";
            radioButtonDificultadMedia.Size = new Size(146, 25);
            radioButtonDificultadMedia.TabIndex = 3;
            radioButtonDificultadMedia.Text = "Medio (5 vidas)";
            radioButtonDificultadMedia.UseVisualStyleBackColor = true;
            radioButtonDificultadMedia.CheckedChanged += radioButtonDificultadMedia_CheckedChanged;
            // 
            // radioButtonDificultadDificil
            // 
            radioButtonDificultadDificil.Anchor = AnchorStyles.None;
            radioButtonDificultadDificil.AutoSize = true;
            radioButtonDificultadDificil.Location = new Point(220, 213);
            radioButtonDificultadDificil.Margin = new Padding(4);
            radioButtonDificultadDificil.Name = "radioButtonDificultadDificil";
            radioButtonDificultadDificil.Size = new Size(146, 25);
            radioButtonDificultadDificil.TabIndex = 4;
            radioButtonDificultadDificil.Text = "Dificil (3 vidas)";
            radioButtonDificultadDificil.UseVisualStyleBackColor = true;
            radioButtonDificultadDificil.CheckedChanged += radioButtonDificultadDificil_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(radioButtonDificultadDificil);
            Controls.Add(radioButtonDificultadMedia);
            Controls.Add(radioButtonDificultadFacil);
            Controls.Add(label1);
            Controls.Add(EmpezarBtn);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(192, 0, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(600, 400);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmpezarBtn;
        private Label label1;
        private RadioButton radioButtonDificultadFacil;
        private RadioButton radioButtonDificultadMedia;
        private RadioButton radioButtonDificultadDificil;
    }
}