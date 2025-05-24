namespace uai_poo_actividad_integradora_2.GUI.Formularios.Inversores
{
    partial class FormularioModificarInversor
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
            campoDeTextoApellido = new TextBox();
            etiquetaApellido = new Label();
            etiquetaNombre = new Label();
            campoDeTextoNombre = new TextBox();
            etiquetaDNI = new Label();
            campoNumericoDNI = new NumericUpDown();
            botonAgregar = new Button();
            etiquetaTipoDeInversor = new Label();
            selectorTipoInversor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)campoNumericoDNI).BeginInit();
            SuspendLayout();
            // 
            // campoDeTextoApellido
            // 
            campoDeTextoApellido.Location = new Point(76, 27);
            campoDeTextoApellido.Name = "campoDeTextoApellido";
            campoDeTextoApellido.Size = new Size(100, 23);
            campoDeTextoApellido.TabIndex = 0;
            campoDeTextoApellido.TextChanged += ValidarInversorAModificar;
            // 
            // etiquetaApellido
            // 
            etiquetaApellido.AutoSize = true;
            etiquetaApellido.Location = new Point(76, 9);
            etiquetaApellido.Name = "etiquetaApellido";
            etiquetaApellido.Size = new Size(51, 15);
            etiquetaApellido.TabIndex = 1;
            etiquetaApellido.Text = "Apellido";
            // 
            // etiquetaNombre
            // 
            etiquetaNombre.AutoSize = true;
            etiquetaNombre.Location = new Point(76, 53);
            etiquetaNombre.Name = "etiquetaNombre";
            etiquetaNombre.Size = new Size(51, 15);
            etiquetaNombre.TabIndex = 3;
            etiquetaNombre.Text = "Nombre";
            // 
            // campoDeTextoNombre
            // 
            campoDeTextoNombre.Location = new Point(76, 71);
            campoDeTextoNombre.Name = "campoDeTextoNombre";
            campoDeTextoNombre.Size = new Size(100, 23);
            campoDeTextoNombre.TabIndex = 2;
            campoDeTextoNombre.TextChanged += ValidarInversorAModificar;
            // 
            // etiquetaDNI
            // 
            etiquetaDNI.AutoSize = true;
            etiquetaDNI.Location = new Point(76, 97);
            etiquetaDNI.Name = "etiquetaDNI";
            etiquetaDNI.Size = new Size(27, 15);
            etiquetaDNI.TabIndex = 4;
            etiquetaDNI.Text = "DNI";
            // 
            // campoNumericoDNI
            // 
            campoNumericoDNI.Location = new Point(76, 115);
            campoNumericoDNI.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            campoNumericoDNI.Minimum = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoDNI.Name = "campoNumericoDNI";
            campoNumericoDNI.Size = new Size(100, 23);
            campoNumericoDNI.TabIndex = 5;
            campoNumericoDNI.Value = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoDNI.ValueChanged += ValidarInversorAModificar;
            // 
            // botonAgregar
            // 
            botonAgregar.Enabled = false;
            botonAgregar.Location = new Point(86, 188);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(75, 23);
            botonAgregar.TabIndex = 6;
            botonAgregar.Text = "Modificar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += BotonModificar_Click;
            // 
            // etiquetaTipoDeInversor
            // 
            etiquetaTipoDeInversor.AutoSize = true;
            etiquetaTipoDeInversor.Location = new Point(76, 141);
            etiquetaTipoDeInversor.Name = "etiquetaTipoDeInversor";
            etiquetaTipoDeInversor.Size = new Size(92, 15);
            etiquetaTipoDeInversor.TabIndex = 10;
            etiquetaTipoDeInversor.Text = "Tipo de Inversor";
            // 
            // selectorTipoInversor
            // 
            selectorTipoInversor.DropDownStyle = ComboBoxStyle.DropDownList;
            selectorTipoInversor.FormattingEnabled = true;
            selectorTipoInversor.Items.AddRange(new object[] { "NORMAL", "PREMIUM" });
            selectorTipoInversor.Location = new Point(76, 159);
            selectorTipoInversor.Name = "selectorTipoInversor";
            selectorTipoInversor.Size = new Size(100, 23);
            selectorTipoInversor.TabIndex = 9;
            // 
            // FormularioModificarInversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 226);
            Controls.Add(etiquetaTipoDeInversor);
            Controls.Add(selectorTipoInversor);
            Controls.Add(botonAgregar);
            Controls.Add(campoNumericoDNI);
            Controls.Add(etiquetaDNI);
            Controls.Add(etiquetaNombre);
            Controls.Add(campoDeTextoNombre);
            Controls.Add(etiquetaApellido);
            Controls.Add(campoDeTextoApellido);
            Name = "FormularioModificarInversor";
            Text = "Modificar Inversor";
            Load += FormularioModificarInversor_Load;
            ((System.ComponentModel.ISupportInitialize)campoNumericoDNI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox campoDeTextoApellido;
        private Label etiquetaApellido;
        private Label etiquetaNombre;
        private TextBox campoDeTextoNombre;
        private Label etiquetaDNI;
        private NumericUpDown campoNumericoDNI;
        private Button botonAgregar;
        private Label etiquetaTipoDeInversor;
        private ComboBox selectorTipoInversor;
    }
}