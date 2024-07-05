namespace Calculadora
{
    partial class HistorialForm
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
            listBoxHistorial = new ListBox();
            SuspendLayout();
            // 
            // listBoxHistorial
            // 
            listBoxHistorial.FormattingEnabled = true;
            listBoxHistorial.ItemHeight = 15;
            listBoxHistorial.Location = new Point(90, 62);
            listBoxHistorial.Name = "listBoxHistorial";
            listBoxHistorial.Size = new Size(120, 94);
            listBoxHistorial.TabIndex = 0;
            // 
            // HistorialForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 265);
            Controls.Add(listBoxHistorial);
            Name = "HistorialForm";
            Text = "HistorialForm";
            Load += HistorialForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxHistorial;
    }
}