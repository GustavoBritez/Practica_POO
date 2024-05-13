namespace Sistema_De_Asistencias
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
            label1 = new Label();
            LB_Asistencia = new Label();
            LB_Legajo = new Label();
            label4 = new Label();
            txt_Legajo = new TextBox();
            panel1 = new Panel();
            LB_Modalidad = new Label();
            LB_Legajo_2 = new Label();
            ck_Presencial = new CheckBox();
            button1 = new Button();
            DGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 28);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Asistencia";
            // 
            // LB_Asistencia
            // 
            LB_Asistencia.AutoSize = true;
            LB_Asistencia.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LB_Asistencia.Location = new Point(36, 65);
            LB_Asistencia.Name = "LB_Asistencia";
            LB_Asistencia.Size = new Size(148, 22);
            LB_Asistencia.TabIndex = 1;
            LB_Asistencia.Text = "Marcar Asistencia";
            // 
            // LB_Legajo
            // 
            LB_Legajo.AutoSize = true;
            LB_Legajo.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LB_Legajo.Location = new Point(12, 105);
            LB_Legajo.Name = "LB_Legajo";
            LB_Legajo.Size = new Size(62, 22);
            LB_Legajo.TabIndex = 2;
            LB_Legajo.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bodoni MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(0, 22);
            label4.TabIndex = 3;
            // 
            // txt_Legajo
            // 
            txt_Legajo.Location = new Point(80, 107);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(148, 23);
            txt_Legajo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(LB_Modalidad);
            panel1.Controls.Add(LB_Legajo_2);
            panel1.Location = new Point(2, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 126);
            panel1.TabIndex = 7;
            // 
            // LB_Modalidad
            // 
            LB_Modalidad.AutoSize = true;
            LB_Modalidad.Location = new Point(10, 61);
            LB_Modalidad.Name = "LB_Modalidad";
            LB_Modalidad.Size = new Size(77, 15);
            LB_Modalidad.TabIndex = 1;
            LB_Modalidad.Text = "Horas Totales";
            // 
            // LB_Legajo_2
            // 
            LB_Legajo_2.AutoSize = true;
            LB_Legajo_2.Location = new Point(10, 20);
            LB_Legajo_2.Name = "LB_Legajo_2";
            LB_Legajo_2.Size = new Size(64, 15);
            LB_Legajo_2.TabIndex = 0;
            LB_Legajo_2.Text = "Modalidad";
            // 
            // ck_Presencial
            // 
            ck_Presencial.AutoSize = true;
            ck_Presencial.BackColor = Color.PeachPuff;
            ck_Presencial.Location = new Point(149, 136);
            ck_Presencial.Name = "ck_Presencial";
            ck_Presencial.Size = new Size(79, 19);
            ck_Presencial.TabIndex = 10;
            ck_Presencial.Text = "Presencial";
            ck_Presencial.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PeachPuff;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(149, 161);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.AllowUserToResizeColumns = false;
            DGV.AllowUserToResizeRows = false;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Enabled = false;
            DGV.Location = new Point(275, 65);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowTemplate.Height = 25;
            DGV.Size = new Size(343, 272);
            DGV.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(701, 349);
            Controls.Add(DGV);
            Controls.Add(button1);
            Controls.Add(ck_Presencial);
            Controls.Add(panel1);
            Controls.Add(txt_Legajo);
            Controls.Add(label4);
            Controls.Add(LB_Legajo);
            Controls.Add(LB_Asistencia);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LB_Asistencia;
        private Label LB_Legajo;
        private Label label4;
        private TextBox txt_Legajo;
        private Panel panel1;
        private Label LB_Modalidad;
        private Label LB_Legajo_2;
        private CheckBox ck_Presencial;
        private Button button1;
        private DataGridView DGV;
    }
}