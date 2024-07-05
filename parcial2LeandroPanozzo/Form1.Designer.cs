namespace parcial2LeandroPanozzo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnProcessText = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.CargarArchivoBtn = new System.Windows.Forms.Button();
            this.GuardarTextoDeTextBox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CantPalabras = new System.Windows.Forms.Label();
            this.CantCaracteresEspacio = new System.Windows.Forms.Label();
            this.CantCaracteresSinEspacio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnProcessText
            // 
            this.btnProcessText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProcessText.Location = new System.Drawing.Point(220, 297);
            this.btnProcessText.Name = "btnProcessText";
            this.btnProcessText.Size = new System.Drawing.Size(110, 23);
            this.btnProcessText.TabIndex = 3;
            this.btnProcessText.Text = "Ver estadistica";
            this.btnProcessText.UseVisualStyleBackColor = true;
            this.btnProcessText.Click += new System.EventHandler(this.btnProcessText_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarBtn.Location = new System.Drawing.Point(675, 297);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(113, 23);
            this.GuardarBtn.TabIndex = 9;
            this.GuardarBtn.Text = "GuardarEstadisticas";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // CargarArchivoBtn
            // 
            this.CargarArchivoBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CargarArchivoBtn.Location = new System.Drawing.Point(12, 297);
            this.CargarArchivoBtn.Name = "CargarArchivoBtn";
            this.CargarArchivoBtn.Size = new System.Drawing.Size(114, 23);
            this.CargarArchivoBtn.TabIndex = 10;
            this.CargarArchivoBtn.Text = "Cargar archivo";
            this.CargarArchivoBtn.UseVisualStyleBackColor = true;
            this.CargarArchivoBtn.Click += new System.EventHandler(this.CargarArchivoBtn_Click);
            // 
            // GuardarTextoDeTextBox
            // 
            this.GuardarTextoDeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarTextoDeTextBox.Location = new System.Drawing.Point(431, 297);
            this.GuardarTextoDeTextBox.Name = "GuardarTextoDeTextBox";
            this.GuardarTextoDeTextBox.Size = new System.Drawing.Size(145, 23);
            this.GuardarTextoDeTextBox.TabIndex = 11;
            this.GuardarTextoDeTextBox.Text = "GuardarTextoIngresado";
            this.GuardarTextoDeTextBox.UseVisualStyleBackColor = true;
            this.GuardarTextoDeTextBox.Click += new System.EventHandler(this.GuardarTextoDeTextBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 193);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 57);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CantPalabras
            // 
            this.CantPalabras.AutoSize = true;
            this.CantPalabras.Location = new System.Drawing.Point(16, 9);
            this.CantPalabras.Name = "CantPalabras";
            this.CantPalabras.Size = new System.Drawing.Size(110, 13);
            this.CantPalabras.TabIndex = 14;
            this.CantPalabras.Text = "Cantidad de palabras:";
            this.CantPalabras.Click += new System.EventHandler(this.CantPalabras_Click);
            // 
            // CantCaracteresEspacio
            // 
            this.CantCaracteresEspacio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CantCaracteresEspacio.AutoSize = true;
            this.CantCaracteresEspacio.Location = new System.Drawing.Point(262, 9);
            this.CantCaracteresEspacio.Name = "CantCaracteresEspacio";
            this.CantCaracteresEspacio.Size = new System.Drawing.Size(192, 13);
            this.CantCaracteresEspacio.TabIndex = 15;
            this.CantCaracteresEspacio.Text = "Cantidad de caracteres (con espacios):";
            this.CantCaracteresEspacio.Click += new System.EventHandler(this.CantCaracteresEspacio_Click);
            // 
            // CantCaracteresSinEspacio
            // 
            this.CantCaracteresSinEspacio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CantCaracteresSinEspacio.AutoSize = true;
            this.CantCaracteresSinEspacio.Location = new System.Drawing.Point(549, 9);
            this.CantCaracteresSinEspacio.Name = "CantCaracteresSinEspacio";
            this.CantCaracteresSinEspacio.Size = new System.Drawing.Size(187, 13);
            this.CantCaracteresSinEspacio.TabIndex = 16;
            this.CantCaracteresSinEspacio.Text = "Cantidad de caracteres (sin espacios):";
            this.CantCaracteresSinEspacio.Click += new System.EventHandler(this.CantCaracteresSinEspacio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.CantCaracteresSinEspacio);
            this.Controls.Add(this.CantCaracteresEspacio);
            this.Controls.Add(this.CantPalabras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GuardarTextoDeTextBox);
            this.Controls.Add(this.CargarArchivoBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.btnProcessText);
            this.MinimumSize = new System.Drawing.Size(816, 389);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnProcessText;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button CargarArchivoBtn;
        private System.Windows.Forms.Button GuardarTextoDeTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CantPalabras;
        private System.Windows.Forms.Label CantCaracteresEspacio;
        private System.Windows.Forms.Label CantCaracteresSinEspacio;
    }
}

