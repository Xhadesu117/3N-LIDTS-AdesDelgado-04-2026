namespace _3N_LIDTS_AdesDelgado_04_C__2026
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbNombre = new TextBox();
            tbApellidos = new TextBox();
            tbTelefono = new TextBox();
            tbEdad = new TextBox();
            tbEstatura = new TextBox();
            groupBox1 = new GroupBox();
            rbOtro = new RadioButton();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 56);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(69, 88);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "APELLIDOS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(69, 129);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "TELEFONO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(69, 168);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "EDAD: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 208);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 4;
            label5.Text = "ESTATURA: ";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(168, 53);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(273, 23);
            tbNombre.TabIndex = 5;
            // 
            // tbApellidos
            // 
            tbApellidos.Location = new Point(168, 88);
            tbApellidos.Name = "tbApellidos";
            tbApellidos.Size = new Size(273, 23);
            tbApellidos.TabIndex = 6;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(168, 126);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(273, 23);
            tbTelefono.TabIndex = 7;
            // 
            // tbEdad
            // 
            tbEdad.Location = new Point(168, 165);
            tbEdad.Name = "tbEdad";
            tbEdad.Size = new Size(273, 23);
            tbEdad.TabIndex = 8;
            // 
            // tbEstatura
            // 
            tbEstatura.Location = new Point(168, 205);
            tbEstatura.Name = "tbEstatura";
            tbEstatura.Size = new Size(273, 23);
            tbEstatura.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOtro);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Controls.Add(rbFemenino);
            groupBox1.Location = new Point(98, 282);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "GENERO.";
            // 
            // rbOtro
            // 
            rbOtro.AutoSize = true;
            rbOtro.Location = new Point(239, 44);
            rbOtro.Name = "rbOtro";
            rbOtro.Size = new Size(54, 19);
            rbOtro.TabIndex = 2;
            rbOtro.TabStop = true;
            rbOtro.Text = "Otros";
            rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(125, 44);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 1;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(17, 44);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 0;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(51, 432);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(181, 58);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(274, 432);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(175, 58);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 525);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(tbEstatura);
            Controls.Add(tbEdad);
            Controls.Add(tbTelefono);
            Controls.Add(tbApellidos);
            Controls.Add(tbNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Actividad 04 - Formulario de Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbNombre;
        private TextBox tbApellidos;
        private TextBox tbTelefono;
        private TextBox tbEdad;
        private TextBox tbEstatura;
        private GroupBox groupBox1;
        private RadioButton rbOtro;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private Button btnGuardar;
        private Button btnLimpiar;
    }
}