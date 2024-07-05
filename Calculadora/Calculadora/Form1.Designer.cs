namespace Calculadora
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
            tableLayoutPanel1 = new TableLayoutPanel();
            PuntoBtn = new Button();
            TresBtn = new Button();
            seisBtn = new Button();
            CincoBtn = new Button();
            CuatroBtn = new Button();
            nueveBtn = new Button();
            OchoBtn = new Button();
            SiesteBtn = new Button();
            MultiplicacionBtn = new Button();
            ResultBtn = new Button();
            BorrarBtn = new Button();
            DivisionBtn = new Button();
            RestaBtn = new Button();
            SumaBtn = new Button();
            DosBtn = new Button();
            UnoBtn = new Button();
            CeroBtn = new Button();
            BorrarTodoBtn = new Button();
            CalcularFechas = new Button();
            Historial = new Button();
            textBox1 = new TextBox();
            HistorialToolStripMenuItem = new ToolStrip();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(PuntoBtn, 2, 3);
            tableLayoutPanel1.Controls.Add(TresBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(seisBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(CincoBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(CuatroBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(nueveBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(OchoBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(SiesteBtn, 0, 0);
            tableLayoutPanel1.Controls.Add(MultiplicacionBtn, 3, 3);
            tableLayoutPanel1.Controls.Add(ResultBtn, 3, 4);
            tableLayoutPanel1.Controls.Add(BorrarBtn, 2, 4);
            tableLayoutPanel1.Controls.Add(DivisionBtn, 3, 2);
            tableLayoutPanel1.Controls.Add(RestaBtn, 3, 1);
            tableLayoutPanel1.Controls.Add(SumaBtn, 3, 0);
            tableLayoutPanel1.Controls.Add(DosBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(UnoBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(CeroBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(BorrarTodoBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(CalcularFechas, 0, 3);
            tableLayoutPanel1.Controls.Add(Historial, 1, 4);
            tableLayoutPanel1.Location = new Point(12, 140);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(584, 165);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PuntoBtn
            // 
            PuntoBtn.Dock = DockStyle.Fill;
            PuntoBtn.Location = new Point(295, 102);
            PuntoBtn.Name = "PuntoBtn";
            PuntoBtn.Size = new Size(140, 27);
            PuntoBtn.TabIndex = 18;
            PuntoBtn.Text = ".";
            PuntoBtn.UseVisualStyleBackColor = true;
            PuntoBtn.Click += PuntoBtn_Click;
            // 
            // TresBtn
            // 
            TresBtn.Dock = DockStyle.Fill;
            TresBtn.Location = new Point(295, 69);
            TresBtn.Name = "TresBtn";
            TresBtn.Size = new Size(140, 27);
            TresBtn.TabIndex = 14;
            TresBtn.Text = "3";
            TresBtn.UseVisualStyleBackColor = true;
            TresBtn.Click += TresBtn_Click;
            // 
            // seisBtn
            // 
            seisBtn.Dock = DockStyle.Fill;
            seisBtn.Location = new Point(295, 36);
            seisBtn.Name = "seisBtn";
            seisBtn.Size = new Size(140, 27);
            seisBtn.TabIndex = 10;
            seisBtn.Text = "6";
            seisBtn.UseVisualStyleBackColor = true;
            seisBtn.Click += SeisBtn_Click;
            // 
            // CincoBtn
            // 
            CincoBtn.Dock = DockStyle.Fill;
            CincoBtn.Location = new Point(149, 36);
            CincoBtn.Name = "CincoBtn";
            CincoBtn.Size = new Size(140, 27);
            CincoBtn.TabIndex = 9;
            CincoBtn.Text = "5";
            CincoBtn.UseVisualStyleBackColor = true;
            CincoBtn.Click += CincoBtn_Click;
            // 
            // CuatroBtn
            // 
            CuatroBtn.Dock = DockStyle.Fill;
            CuatroBtn.Location = new Point(3, 36);
            CuatroBtn.Name = "CuatroBtn";
            CuatroBtn.Size = new Size(140, 27);
            CuatroBtn.TabIndex = 8;
            CuatroBtn.Text = "4";
            CuatroBtn.UseVisualStyleBackColor = true;
            CuatroBtn.Click += CuatroBtn_Click;
            // 
            // nueveBtn
            // 
            nueveBtn.Dock = DockStyle.Fill;
            nueveBtn.Location = new Point(295, 3);
            nueveBtn.Name = "nueveBtn";
            nueveBtn.Size = new Size(140, 27);
            nueveBtn.TabIndex = 6;
            nueveBtn.Text = "9";
            nueveBtn.UseVisualStyleBackColor = true;
            nueveBtn.Click += NueveBtn_Click;
            // 
            // OchoBtn
            // 
            OchoBtn.Dock = DockStyle.Fill;
            OchoBtn.Location = new Point(149, 3);
            OchoBtn.Name = "OchoBtn";
            OchoBtn.Size = new Size(140, 27);
            OchoBtn.TabIndex = 5;
            OchoBtn.Text = "8";
            OchoBtn.UseVisualStyleBackColor = true;
            OchoBtn.Click += OchoBtn_Click;
            // 
            // SiesteBtn
            // 
            SiesteBtn.Dock = DockStyle.Fill;
            SiesteBtn.Location = new Point(3, 3);
            SiesteBtn.Name = "SiesteBtn";
            SiesteBtn.Size = new Size(140, 27);
            SiesteBtn.TabIndex = 4;
            SiesteBtn.Text = "7";
            SiesteBtn.UseVisualStyleBackColor = true;
            SiesteBtn.Click += SieteBtn_Click;
            // 
            // MultiplicacionBtn
            // 
            MultiplicacionBtn.Dock = DockStyle.Fill;
            MultiplicacionBtn.Location = new Point(441, 102);
            MultiplicacionBtn.Name = "MultiplicacionBtn";
            MultiplicacionBtn.Size = new Size(140, 27);
            MultiplicacionBtn.TabIndex = 19;
            MultiplicacionBtn.Text = "X";
            MultiplicacionBtn.UseVisualStyleBackColor = true;
            MultiplicacionBtn.Click += MultiplicacionBtn_Click;
            // 
            // ResultBtn
            // 
            ResultBtn.Dock = DockStyle.Fill;
            ResultBtn.Location = new Point(441, 135);
            ResultBtn.Name = "ResultBtn";
            ResultBtn.Size = new Size(140, 27);
            ResultBtn.TabIndex = 21;
            ResultBtn.Text = "=";
            ResultBtn.UseVisualStyleBackColor = true;
            ResultBtn.Click += ResultBtn_Click;
            // 
            // BorrarBtn
            // 
            BorrarBtn.Dock = DockStyle.Fill;
            BorrarBtn.Location = new Point(295, 135);
            BorrarBtn.Name = "BorrarBtn";
            BorrarBtn.Size = new Size(140, 27);
            BorrarBtn.TabIndex = 22;
            BorrarBtn.Text = "Borrar";
            BorrarBtn.UseVisualStyleBackColor = true;
            BorrarBtn.Click += BorrarBtn_Click;
            // 
            // DivisionBtn
            // 
            DivisionBtn.Dock = DockStyle.Fill;
            DivisionBtn.Location = new Point(441, 69);
            DivisionBtn.Name = "DivisionBtn";
            DivisionBtn.Size = new Size(140, 27);
            DivisionBtn.TabIndex = 25;
            DivisionBtn.Text = "/";
            DivisionBtn.UseVisualStyleBackColor = true;
            DivisionBtn.Click += DivisionBtn_Click;
            // 
            // RestaBtn
            // 
            RestaBtn.Dock = DockStyle.Fill;
            RestaBtn.Location = new Point(441, 36);
            RestaBtn.Name = "RestaBtn";
            RestaBtn.Size = new Size(140, 27);
            RestaBtn.TabIndex = 26;
            RestaBtn.Text = "-";
            RestaBtn.UseVisualStyleBackColor = true;
            RestaBtn.Click += RestaBtn_Click;
            // 
            // SumaBtn
            // 
            SumaBtn.Dock = DockStyle.Fill;
            SumaBtn.Location = new Point(441, 3);
            SumaBtn.Name = "SumaBtn";
            SumaBtn.Size = new Size(140, 27);
            SumaBtn.TabIndex = 27;
            SumaBtn.Text = "+";
            SumaBtn.UseVisualStyleBackColor = true;
            SumaBtn.Click += SumaBtn_Click;
            // 
            // DosBtn
            // 
            DosBtn.Dock = DockStyle.Fill;
            DosBtn.Location = new Point(149, 69);
            DosBtn.Name = "DosBtn";
            DosBtn.Size = new Size(140, 27);
            DosBtn.TabIndex = 13;
            DosBtn.Text = "2";
            DosBtn.UseVisualStyleBackColor = true;
            DosBtn.Click += DosBtn_Click;
            // 
            // UnoBtn
            // 
            UnoBtn.Dock = DockStyle.Fill;
            UnoBtn.Location = new Point(3, 69);
            UnoBtn.Name = "UnoBtn";
            UnoBtn.Size = new Size(140, 27);
            UnoBtn.TabIndex = 12;
            UnoBtn.Text = "1";
            UnoBtn.UseVisualStyleBackColor = true;
            UnoBtn.Click += UnoBtn_Click;
            // 
            // CeroBtn
            // 
            CeroBtn.Dock = DockStyle.Fill;
            CeroBtn.Location = new Point(149, 102);
            CeroBtn.Name = "CeroBtn";
            CeroBtn.Size = new Size(140, 27);
            CeroBtn.TabIndex = 17;
            CeroBtn.Text = "0";
            CeroBtn.UseVisualStyleBackColor = true;
            CeroBtn.Click += CeroBtn_Click;
            // 
            // BorrarTodoBtn
            // 
            BorrarTodoBtn.Location = new Point(3, 135);
            BorrarTodoBtn.Name = "BorrarTodoBtn";
            BorrarTodoBtn.Size = new Size(139, 27);
            BorrarTodoBtn.TabIndex = 24;
            BorrarTodoBtn.Text = "Borrar todo";
            BorrarTodoBtn.UseVisualStyleBackColor = true;
            BorrarTodoBtn.Click += BorrarTodoBtn_Click;
            // 
            // CalcularFechas
            // 
            CalcularFechas.Location = new Point(3, 102);
            CalcularFechas.Name = "CalcularFechas";
            CalcularFechas.Size = new Size(139, 27);
            CalcularFechas.TabIndex = 28;
            CalcularFechas.Text = "Calcular Fechas";
            CalcularFechas.UseVisualStyleBackColor = true;
            CalcularFechas.Click += CalcularFechas_Click;
            // 
            // Historial
            // 
            Historial.Dock = DockStyle.Fill;
            Historial.Location = new Point(149, 135);
            Historial.Name = "Historial";
            Historial.Size = new Size(140, 27);
            Historial.TabIndex = 29;
            Historial.Text = "Mostrar historial";
            Historial.UseVisualStyleBackColor = true;
            Historial.Click += Historial_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 24);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(578, 110);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // HistorialToolStripMenuItem
            // 
            HistorialToolStripMenuItem.Location = new Point(0, 0);
            HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem";
            HistorialToolStripMenuItem.Size = new Size(602, 25);
            HistorialToolStripMenuItem.TabIndex = 2;
            HistorialToolStripMenuItem.Text = "toolStrip1";
            HistorialToolStripMenuItem.ItemClicked += HistorialToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(602, 314);
            Controls.Add(HistorialToolStripMenuItem);
            Controls.Add(textBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button20;
        private Button button16;
        private Button TresBtn;
        private Button DosBtn;
        private Button UnoBtn;
        private Button button12;
        private Button seisBtn;
        private Button CincoBtn;
        private Button CuatroBtn;
        private Button button8;
        private Button nueveBtn;
        private Button OchoBtn;
        private Button SiesteBtn;
        private Button PuntoBtn;
        private Button CeroBtn;
        private Button MultiplicacionBtn;
        private Button ResultBtn;
        private Button BorrarBtn;
        private Button BorrarTodoBtn;
        private Button DivisionBtn;
        private Button RestaBtn;
        private Button SumaBtn;
        private TextBox textBox1;
        private Button CalcularFechas;
        private Button Historial;
        private ToolStrip HistorialToolStripMenuItem;
    }
}
