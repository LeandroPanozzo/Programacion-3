namespace Calculadora
{
    partial class CalculoFechas
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
            AceptarBtn = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // AceptarBtn
            // 
            AceptarBtn.DialogResult = DialogResult.OK;
            AceptarBtn.Location = new Point(151, 198);
            AceptarBtn.Name = "AceptarBtn";
            AceptarBtn.Size = new Size(75, 23);
            AceptarBtn.TabIndex = 0;
            AceptarBtn.Text = "Aceptar";
            AceptarBtn.UseVisualStyleBackColor = true;
            AceptarBtn.Click += AceptarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 6);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la primer fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(227, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 67);
            label2.Name = "label2";
            label2.Size = new Size(263, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese la segunda fecha que restara a la primera";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(88, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(227, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // CalculoFechas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 261);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(AceptarBtn);
            Name = "CalculoFechas";
            Text = "CalculoFechas";
            Load += CalculoFechas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AceptarBtn;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
    }
}