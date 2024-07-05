namespace tateti_winforms
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
            EmpezarBtn = new Button();
            label1 = new Label();
            Jugador1textBox1 = new TextBox();
            Jugador2textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // EmpezarBtn
            // 
            EmpezarBtn.Anchor = AnchorStyles.Bottom;
            EmpezarBtn.Location = new Point(347, 277);
            EmpezarBtn.Name = "EmpezarBtn";
            EmpezarBtn.Size = new Size(75, 23);
            EmpezarBtn.TabIndex = 0;
            EmpezarBtn.Text = "Empazar";
            EmpezarBtn.UseVisualStyleBackColor = true;
            EmpezarBtn.Click += EmpezarBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(210, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingrese los nombres de los jugadores";
            // 
            // Jugador1textBox1
            // 
            Jugador1textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Jugador1textBox1.Location = new Point(311, 65);
            Jugador1textBox1.Name = "Jugador1textBox1";
            Jugador1textBox1.Size = new Size(160, 23);
            Jugador1textBox1.TabIndex = 3;
            Jugador1textBox1.TextChanged += Jugador1textBox1_TextChanged;
            // 
            // Jugador2textBox2
            // 
            Jugador2textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Jugador2textBox2.Location = new Point(311, 118);
            Jugador2textBox2.Name = "Jugador2textBox2";
            Jugador2textBox2.Size = new Size(160, 23);
            Jugador2textBox2.TabIndex = 4;
            Jugador2textBox2.TextChanged += Jugador2textBox2_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(68, 73);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 5;
            label2.Text = "Jugador 1";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(68, 126);
            label3.Name = "label3";
            label3.Size = new Size(83, 18);
            label3.TabIndex = 6;
            label3.Text = "Jugador 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 312);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Jugador2textBox2);
            Controls.Add(Jugador1textBox1);
            Controls.Add(label1);
            Controls.Add(EmpezarBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EmpezarBtn;
        private Label label1;
        private TextBox Jugador1textBox1;
        private TextBox Jugador2textBox2;
        private Label label2;
        private Label label3;
    }
}
