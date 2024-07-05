namespace generar_el_texto_aleatorio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMostrar = new TextBox();
            MostrarCantidadParafosYPalabrasLabel = new Label();
            GuardarBtn = new Button();
            SalirBtn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBoxMostrar
            // 
            textBoxMostrar.Location = new Point(12, 36);
            textBoxMostrar.Multiline = true;
            textBoxMostrar.Name = "textBoxMostrar";
            textBoxMostrar.ScrollBars = ScrollBars.Both;
            textBoxMostrar.Size = new Size(776, 230);
            textBoxMostrar.TabIndex = 0;
            textBoxMostrar.TextChanged += textBoxMostrar_TextChanged;
            // 
            // MostrarCantidadParafosYPalabrasLabel
            // 
            MostrarCantidadParafosYPalabrasLabel.AutoSize = true;
            MostrarCantidadParafosYPalabrasLabel.Location = new Point(380, 9);
            MostrarCantidadParafosYPalabrasLabel.Name = "MostrarCantidadParafosYPalabrasLabel";
            MostrarCantidadParafosYPalabrasLabel.Size = new Size(38, 15);
            MostrarCantidadParafosYPalabrasLabel.TabIndex = 1;
            MostrarCantidadParafosYPalabrasLabel.Text = "label1";
            MostrarCantidadParafosYPalabrasLabel.Click += MostrarCantidadParafosYPalabrasLabel_Click;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(286, 288);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(75, 23);
            GuardarBtn.TabIndex = 2;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // SalirBtn
            // 
            SalirBtn.Location = new Point(474, 288);
            SalirBtn.Name = "SalirBtn";
            SalirBtn.Size = new Size(75, 23);
            SalirBtn.TabIndex = 3;
            SalirBtn.Text = "Salir";
            SalirBtn.UseVisualStyleBackColor = true;
            SalirBtn.Click += SalirBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(SalirBtn);
            Controls.Add(GuardarBtn);
            Controls.Add(MostrarCantidadParafosYPalabrasLabel);
            Controls.Add(textBoxMostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMostrar;
        private Label MostrarCantidadParafosYPalabrasLabel;
        private Button GuardarBtn;
        private Button SalirBtn;
        private SaveFileDialog saveFileDialog1;
    }
}
