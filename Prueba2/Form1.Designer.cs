namespace Prueba2
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
            btn_Crear = new Button();
            label1 = new Label();
            txt_Ci = new TextBox();
            btn_Actualizar = new Button();
            btn_Leer = new Button();
            btn_Borrar = new Button();
            btn_Conectar = new Button();
            btn_Desconectar = new Button();
            txt_Nombre = new TextBox();
            label2 = new Label();
            txt_Apellido = new TextBox();
            label3 = new Label();
            txt_Contraseña = new TextBox();
            label4 = new Label();
            btn_Buscar = new Button();
            txt_Id = new TextBox();
            Id = new Label();
            SuspendLayout();
            // 
            // btn_Crear
            // 
            btn_Crear.Location = new Point(62, 238);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(75, 23);
            btn_Crear.TabIndex = 0;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = true;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 39);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "C.I.";
            // 
            // txt_Ci
            // 
            txt_Ci.Location = new Point(189, 36);
            txt_Ci.Name = "txt_Ci";
            txt_Ci.Size = new Size(100, 23);
            txt_Ci.TabIndex = 2;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Location = new Point(143, 238);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(75, 23);
            btn_Actualizar.TabIndex = 3;
            btn_Actualizar.Text = "Actualizar";
            btn_Actualizar.UseVisualStyleBackColor = true;
            btn_Actualizar.Click += btn_Actualizar_Click;
            // 
            // btn_Leer
            // 
            btn_Leer.Location = new Point(224, 238);
            btn_Leer.Name = "btn_Leer";
            btn_Leer.Size = new Size(75, 23);
            btn_Leer.TabIndex = 4;
            btn_Leer.Text = "Leer";
            btn_Leer.UseVisualStyleBackColor = true;
            btn_Leer.Click += btn_Leer_Click;
            // 
            // btn_Borrar
            // 
            btn_Borrar.Location = new Point(305, 238);
            btn_Borrar.Name = "btn_Borrar";
            btn_Borrar.Size = new Size(75, 23);
            btn_Borrar.TabIndex = 5;
            btn_Borrar.Text = "Borrar";
            btn_Borrar.UseVisualStyleBackColor = true;
            btn_Borrar.Click += btn_Borrar_Click;
            // 
            // btn_Conectar
            // 
            btn_Conectar.Location = new Point(139, 297);
            btn_Conectar.Name = "btn_Conectar";
            btn_Conectar.Size = new Size(75, 23);
            btn_Conectar.TabIndex = 6;
            btn_Conectar.Text = "Connectar";
            btn_Conectar.UseVisualStyleBackColor = true;
            btn_Conectar.Click += btn_Conectar_Click;
            // 
            // btn_Desconectar
            // 
            btn_Desconectar.Location = new Point(224, 297);
            btn_Desconectar.Name = "btn_Desconectar";
            btn_Desconectar.Size = new Size(88, 23);
            btn_Desconectar.TabIndex = 7;
            btn_Desconectar.Text = "Desconectar";
            btn_Desconectar.UseVisualStyleBackColor = true;
            btn_Desconectar.Click += btn_Desconectar_Click;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(189, 85);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(189, 134);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 142);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // txt_Contraseña
            // 
            txt_Contraseña.Location = new Point(189, 181);
            txt_Contraseña.Name = "txt_Contraseña";
            txt_Contraseña.Size = new Size(100, 23);
            txt_Contraseña.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 189);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 12;
            label4.Text = "Contraseña";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(379, 89);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 14;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Id
            // 
            txt_Id.Enabled = false;
            txt_Id.Location = new Point(368, 39);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(100, 23);
            txt_Id.TabIndex = 16;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Location = new Point(332, 39);
            Id.Name = "Id";
            Id.Size = new Size(18, 15);
            Id.TabIndex = 15;
            Id.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Id);
            Controls.Add(Id);
            Controls.Add(btn_Buscar);
            Controls.Add(txt_Contraseña);
            Controls.Add(label4);
            Controls.Add(txt_Apellido);
            Controls.Add(label3);
            Controls.Add(txt_Nombre);
            Controls.Add(label2);
            Controls.Add(btn_Desconectar);
            Controls.Add(btn_Conectar);
            Controls.Add(btn_Borrar);
            Controls.Add(btn_Leer);
            Controls.Add(btn_Actualizar);
            Controls.Add(txt_Ci);
            Controls.Add(label1);
            Controls.Add(btn_Crear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Crear;
        private Label label1;
        private TextBox txt_Ci;
        private Button btn_Actualizar;
        private Button btn_Leer;
        private Button btn_Borrar;
        private Button btn_Conectar;
        private Button btn_Desconectar;
        private TextBox txt_Nombre;
        private Label label2;
        private TextBox txt_Apellido;
        private Label label3;
        private TextBox txt_Contraseña;
        private Label label4;
        private Button btn_Buscar;
        private TextBox txt_Id;
        private Label Id;
    }
}
