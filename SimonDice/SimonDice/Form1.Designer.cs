namespace SimonDice
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
            components = new System.ComponentModel.Container();
            Azul = new Button();
            Amarillo = new Button();
            Rojo = new Button();
            Verde = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            btnComenzar = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Azul
            // 
            Azul.BackColor = SystemColors.ButtonFace;
            Azul.Location = new Point(150, 39);
            Azul.Name = "Azul";
            Azul.Size = new Size(112, 56);
            Azul.TabIndex = 0;
            Azul.Text = "Azul";
            Azul.UseVisualStyleBackColor = false;
            Azul.Click += Azul_Click;
            // 
            // Amarillo
            // 
            Amarillo.BackColor = SystemColors.ButtonFace;
            Amarillo.Location = new Point(363, 38);
            Amarillo.Name = "Amarillo";
            Amarillo.Size = new Size(104, 57);
            Amarillo.TabIndex = 1;
            Amarillo.Text = "Amarillo";
            Amarillo.UseVisualStyleBackColor = false;
            Amarillo.Click += Amarillo_Click;
            // 
            // Rojo
            // 
            Rojo.BackColor = Color.Gainsboro;
            Rojo.Location = new Point(150, 101);
            Rojo.Name = "Rojo";
            Rojo.Size = new Size(112, 52);
            Rojo.TabIndex = 2;
            Rojo.Text = "Rojo";
            Rojo.UseVisualStyleBackColor = false;
            Rojo.Click += Rojo_Click;
            // 
            // Verde
            // 
            Verde.BackColor = SystemColors.ButtonFace;
            Verde.ForeColor = SystemColors.ActiveCaptionText;
            Verde.Location = new Point(363, 101);
            Verde.Name = "Verde";
            Verde.Size = new Size(104, 52);
            Verde.TabIndex = 3;
            Verde.Text = "Verde";
            Verde.UseVisualStyleBackColor = false;
            Verde.Click += Verde_Click;
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(274, 158);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(75, 23);
            btnComenzar.TabIndex = 4;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 245);
            Controls.Add(btnComenzar);
            Controls.Add(Verde);
            Controls.Add(Rojo);
            Controls.Add(Amarillo);
            Controls.Add(Azul);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Azul;
        private Button Amarillo;
        private Button Rojo;
        private Button Verde;
        private System.Windows.Forms.Timer timer1;
        private Button btnComenzar;
        private System.Windows.Forms.Timer timer2;
    }
}
