namespace generar_el_texto_aleatorio
{
    partial class AbrirArchivoBtn
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
            radioButtonParrafo = new RadioButton();
            radioButtonPalabra = new RadioButton();
            checkBoxLoreIpsum = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxMinOraciones = new TextBox();
            textBoxMaxPalabras = new TextBox();
            textBoxMaxOraciones = new TextBox();
            textBoxMinPalabras = new TextBox();
            EmpezarBtn = new Button();
            AbrirBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // radioButtonParrafo
            // 
            radioButtonParrafo.AutoSize = true;
            radioButtonParrafo.Location = new Point(101, 12);
            radioButtonParrafo.Name = "radioButtonParrafo";
            radioButtonParrafo.Size = new Size(63, 19);
            radioButtonParrafo.TabIndex = 0;
            radioButtonParrafo.TabStop = true;
            radioButtonParrafo.Text = "Parrafo";
            radioButtonParrafo.UseVisualStyleBackColor = true;
            radioButtonParrafo.CheckedChanged += radioButtonParrafo_CheckedChanged;
            // 
            // radioButtonPalabra
            // 
            radioButtonPalabra.AutoSize = true;
            radioButtonPalabra.Location = new Point(487, 12);
            radioButtonPalabra.Name = "radioButtonPalabra";
            radioButtonPalabra.Size = new Size(64, 19);
            radioButtonPalabra.TabIndex = 1;
            radioButtonPalabra.TabStop = true;
            radioButtonPalabra.Text = "Palabra";
            radioButtonPalabra.UseVisualStyleBackColor = true;
            radioButtonPalabra.CheckedChanged += radioButtonPalabra_CheckedChanged;
            // 
            // checkBoxLoreIpsum
            // 
            checkBoxLoreIpsum.AutoSize = true;
            checkBoxLoreIpsum.Location = new Point(255, 200);
            checkBoxLoreIpsum.Name = "checkBoxLoreIpsum";
            checkBoxLoreIpsum.Size = new Size(156, 19);
            checkBoxLoreIpsum.TabIndex = 2;
            checkBoxLoreIpsum.Text = "Empezar con Lore Ipsum";
            checkBoxLoreIpsum.UseVisualStyleBackColor = true;
            checkBoxLoreIpsum.CheckedChanged += checkBoxLoreIpsum_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 49);
            label1.Name = "label1";
            label1.Size = new Size(239, 15);
            label1.TabIndex = 3;
            label1.Text = "Canidad minima de oraciones en un parrafo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(241, 15);
            label2.TabIndex = 4;
            label2.Text = "Canidad maxima de oraciones en un parrafo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 49);
            label3.Name = "label3";
            label3.Size = new Size(229, 15);
            label3.TabIndex = 5;
            label3.Text = "Canidad minima de palabras en la oracion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(417, 114);
            label4.Name = "label4";
            label4.Size = new Size(231, 15);
            label4.TabIndex = 6;
            label4.Text = "Canidad maxima de palabras en la oracion";
            // 
            // textBoxMinOraciones
            // 
            textBoxMinOraciones.Enabled = false;
            textBoxMinOraciones.Location = new Point(64, 67);
            textBoxMinOraciones.Name = "textBoxMinOraciones";
            textBoxMinOraciones.Size = new Size(100, 23);
            textBoxMinOraciones.TabIndex = 7;
            textBoxMinOraciones.TextChanged += textBoxMinOraciones_TextChanged;
            // 
            // textBoxMaxPalabras
            // 
            textBoxMaxPalabras.Enabled = false;
            textBoxMaxPalabras.Location = new Point(487, 143);
            textBoxMaxPalabras.Name = "textBoxMaxPalabras";
            textBoxMaxPalabras.Size = new Size(100, 23);
            textBoxMaxPalabras.TabIndex = 8;
            textBoxMaxPalabras.TextChanged += textBoxMaxPalabras_TextChanged;
            // 
            // textBoxMaxOraciones
            // 
            textBoxMaxOraciones.Enabled = false;
            textBoxMaxOraciones.Location = new Point(64, 132);
            textBoxMaxOraciones.Name = "textBoxMaxOraciones";
            textBoxMaxOraciones.Size = new Size(100, 23);
            textBoxMaxOraciones.TabIndex = 9;
            textBoxMaxOraciones.TextChanged += textBoxMaxOraciones_TextChanged;
            // 
            // textBoxMinPalabras
            // 
            textBoxMinPalabras.Enabled = false;
            textBoxMinPalabras.Location = new Point(487, 67);
            textBoxMinPalabras.Name = "textBoxMinPalabras";
            textBoxMinPalabras.Size = new Size(100, 23);
            textBoxMinPalabras.TabIndex = 10;
            textBoxMinPalabras.TextChanged += textBoxMinPalabras_TextChanged;
            // 
            // EmpezarBtn
            // 
            EmpezarBtn.Location = new Point(214, 294);
            EmpezarBtn.Name = "EmpezarBtn";
            EmpezarBtn.Size = new Size(75, 23);
            EmpezarBtn.TabIndex = 11;
            EmpezarBtn.Text = "Empezar";
            EmpezarBtn.UseVisualStyleBackColor = true;
            EmpezarBtn.Click += EmpezarBtn_Click;
            // 
            // AbrirBtn
            // 
            AbrirBtn.Location = new Point(367, 294);
            AbrirBtn.Name = "AbrirBtn";
            AbrirBtn.Size = new Size(96, 23);
            AbrirBtn.TabIndex = 12;
            AbrirBtn.Text = "Abrir Archivo";
            AbrirBtn.UseVisualStyleBackColor = true;
            AbrirBtn.Click += AbrirBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AbrirArchivoBtn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 329);
            Controls.Add(AbrirBtn);
            Controls.Add(EmpezarBtn);
            Controls.Add(textBoxMinPalabras);
            Controls.Add(textBoxMaxOraciones);
            Controls.Add(textBoxMaxPalabras);
            Controls.Add(textBoxMinOraciones);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxLoreIpsum);
            Controls.Add(radioButtonPalabra);
            Controls.Add(radioButtonParrafo);
            Name = "AbrirArchivoBtn";
            Text = "LoreIpsum";
            Load += LoreIpsum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonParrafo;
        private RadioButton radioButtonPalabra;
        private CheckBox checkBoxLoreIpsum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxMinOraciones;
        private TextBox textBoxMaxPalabras;
        private TextBox textBoxMaxOraciones;
        private TextBox textBoxMinPalabras;
        private Button EmpezarBtn;
        private Button AbrirBtn;
        private OpenFileDialog openFileDialog1;
    }
}