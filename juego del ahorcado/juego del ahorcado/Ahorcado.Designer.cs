namespace juego_del_ahorcado
{
    partial class Ahorcado
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
            label1 = new Label();
            label2 = new Label();
            textBoxLetraEscribir = new TextBox();
            Verificar = new Button();
            labelMostrarPalabra = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(369, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 148);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Escriba la letra";
            // 
            // textBoxLetraEscribir
            // 
            textBoxLetraEscribir.Location = new Point(341, 140);
            textBoxLetraEscribir.Name = "textBoxLetraEscribir";
            textBoxLetraEscribir.Size = new Size(100, 23);
            textBoxLetraEscribir.TabIndex = 2;
            textBoxLetraEscribir.TextChanged += textBoxLetraEscribir_TextChanged;
            // 
            // Verificar
            // 
            Verificar.Location = new Point(341, 266);
            Verificar.Name = "Verificar";
            Verificar.Size = new Size(75, 23);
            Verificar.TabIndex = 3;
            Verificar.Text = "Verificar";
            Verificar.UseVisualStyleBackColor = true;
            Verificar.Click += Verificar_Click;
            // 
            // labelMostrarPalabra
            // 
            labelMostrarPalabra.AutoSize = true;
            labelMostrarPalabra.Location = new Point(369, 208);
            labelMostrarPalabra.Name = "labelMostrarPalabra";
            labelMostrarPalabra.Size = new Size(32, 15);
            labelMostrarPalabra.TabIndex = 4;
            labelMostrarPalabra.Text = "-----";
            labelMostrarPalabra.Click += labelMostrarPalabra_Click;
            // 
            // Ahorcado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMostrarPalabra);
            Controls.Add(Verificar);
            Controls.Add(textBoxLetraEscribir);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Ahorcado";
            Text = "Ahorcado";
            Load += Ahorcado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxLetraEscribir;
        private Button Verificar;
        private Label labelMostrarPalabra;
    }
}