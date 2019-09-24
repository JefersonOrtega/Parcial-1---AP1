namespace Parcial1_AP1.UI.Registros
{
    partial class rEvaluacion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEvaluacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PerdidotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LogradotextBox = new System.Windows.Forms.TextBox();
            this.ValortextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDEvaluacionnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EstudiantetextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PronosticocomboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDEvaluacionnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estudiante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PerdidotextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LogradotextBox);
            this.groupBox1.Controls.Add(this.ValortextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calificacion Tareas y Parcial";
            // 
            // PerdidotextBox
            // 
            this.PerdidotextBox.Location = new System.Drawing.Point(178, 36);
            this.PerdidotextBox.Name = "PerdidotextBox";
            this.PerdidotextBox.ReadOnly = true;
            this.PerdidotextBox.Size = new System.Drawing.Size(53, 20);
            this.PerdidotextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "-";
            // 
            // LogradotextBox
            // 
            this.LogradotextBox.Location = new System.Drawing.Point(91, 37);
            this.LogradotextBox.Name = "LogradotextBox";
            this.LogradotextBox.Size = new System.Drawing.Size(53, 20);
            this.LogradotextBox.TabIndex = 4;
            this.LogradotextBox.TextChanged += new System.EventHandler(this.LogradotextBox_TextChanged);
            // 
            // ValortextBox
            // 
            this.ValortextBox.Location = new System.Drawing.Point(10, 37);
            this.ValortextBox.Name = "ValortextBox";
            this.ValortextBox.Size = new System.Drawing.Size(53, 20);
            this.ValortextBox.TabIndex = 3;
            this.ValortextBox.TextChanged += new System.EventHandler(this.ValortextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Perdido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor";
            // 
            // IDEvaluacionnumericUpDown
            // 
            this.IDEvaluacionnumericUpDown.Location = new System.Drawing.Point(34, 11);
            this.IDEvaluacionnumericUpDown.Name = "IDEvaluacionnumericUpDown";
            this.IDEvaluacionnumericUpDown.Size = new System.Drawing.Size(81, 20);
            this.IDEvaluacionnumericUpDown.TabIndex = 4;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(117, 7);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(33, 24);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(223, 9);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(91, 20);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // EstudiantetextBox
            // 
            this.EstudiantetextBox.Location = new System.Drawing.Point(76, 54);
            this.EstudiantetextBox.Name = "EstudiantetextBox";
            this.EstudiantetextBox.Size = new System.Drawing.Size(238, 20);
            this.EstudiantetextBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Por como vas deberías:";
            // 
            // PronosticocomboBox
            // 
            this.PronosticocomboBox.FormattingEnabled = true;
            this.PronosticocomboBox.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.PronosticocomboBox.Location = new System.Drawing.Point(16, 209);
            this.PronosticocomboBox.Name = "PronosticocomboBox";
            this.PronosticocomboBox.Size = new System.Drawing.Size(291, 21);
            this.PronosticocomboBox.TabIndex = 9;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(16, 265);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(85, 49);
            this.Nuevobutton.TabIndex = 10;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(121, 265);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(85, 49);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(229, 265);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(85, 49);
            this.Eliminarbutton.TabIndex = 12;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(150, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "=";
            // 
            // rEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(340, 342);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.PronosticocomboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EstudiantetextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IDEvaluacionnumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rEvaluacion";
            this.Text = "rEvaluacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDEvaluacionnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown IDEvaluacionnumericUpDown;
        private System.Windows.Forms.TextBox PerdidotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LogradotextBox;
        private System.Windows.Forms.TextBox ValortextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox EstudiantetextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox PronosticocomboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Label label9;
    }
}