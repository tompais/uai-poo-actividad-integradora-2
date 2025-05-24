namespace uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Agregar
{
    partial class FormularioAgregarAccion
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
            campoDeTextoEnmascaradoCodigo = new MaskedTextBox();
            label1 = new Label();
            selectorDenominacion = new ComboBox();
            label2 = new Label();
            campoNumericoCotizacionActual = new NumericUpDown();
            etiquetaCotizacionActual = new Label();
            etiquetaCantidadEmitida = new Label();
            campoNumericoCantidadEmitida = new NumericUpDown();
            botonAgregarAccion = new Button();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCotizacionActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCantidadEmitida).BeginInit();
            SuspendLayout();
            // 
            // campoDeTextoEnmascaradoCodigo
            // 
            campoDeTextoEnmascaradoCodigo.Location = new Point(82, 27);
            campoDeTextoEnmascaradoCodigo.Mask = ">LLLL-0000-L0L0";
            campoDeTextoEnmascaradoCodigo.Name = "campoDeTextoEnmascaradoCodigo";
            campoDeTextoEnmascaradoCodigo.Size = new Size(121, 23);
            campoDeTextoEnmascaradoCodigo.TabIndex = 0;
            campoDeTextoEnmascaradoCodigo.TextChanged += ValidarAccionAAgregar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // selectorDenominacion
            // 
            selectorDenominacion.DropDownStyle = ComboBoxStyle.DropDownList;
            selectorDenominacion.FormattingEnabled = true;
            selectorDenominacion.Items.AddRange(new object[] { "Ordinaria", "Preferida", "Clase A", "Clase B" });
            selectorDenominacion.Location = new Point(82, 71);
            selectorDenominacion.Name = "selectorDenominacion";
            selectorDenominacion.Size = new Size(121, 23);
            selectorDenominacion.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 53);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Denominación";
            // 
            // campoNumericoCotizacionActual
            // 
            campoNumericoCotizacionActual.DecimalPlaces = 2;
            campoNumericoCotizacionActual.Location = new Point(82, 115);
            campoNumericoCotizacionActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoCotizacionActual.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoCotizacionActual.Name = "campoNumericoCotizacionActual";
            campoNumericoCotizacionActual.Size = new Size(121, 23);
            campoNumericoCotizacionActual.TabIndex = 4;
            campoNumericoCotizacionActual.Value = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoCotizacionActual.ValueChanged += ValidarAccionAAgregar;
            // 
            // etiquetaCotizacionActual
            // 
            etiquetaCotizacionActual.AutoSize = true;
            etiquetaCotizacionActual.Location = new Point(82, 97);
            etiquetaCotizacionActual.Name = "etiquetaCotizacionActual";
            etiquetaCotizacionActual.Size = new Size(100, 15);
            etiquetaCotizacionActual.TabIndex = 5;
            etiquetaCotizacionActual.Text = "Cotización Actual";
            // 
            // etiquetaCantidadEmitida
            // 
            etiquetaCantidadEmitida.AutoSize = true;
            etiquetaCantidadEmitida.Location = new Point(82, 141);
            etiquetaCantidadEmitida.Name = "etiquetaCantidadEmitida";
            etiquetaCantidadEmitida.Size = new Size(98, 15);
            etiquetaCantidadEmitida.TabIndex = 7;
            etiquetaCantidadEmitida.Text = "Cantidad Emitida";
            // 
            // campoNumericoCantidadEmitida
            // 
            campoNumericoCantidadEmitida.Location = new Point(82, 159);
            campoNumericoCantidadEmitida.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoCantidadEmitida.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            campoNumericoCantidadEmitida.Name = "campoNumericoCantidadEmitida";
            campoNumericoCantidadEmitida.Size = new Size(121, 23);
            campoNumericoCantidadEmitida.TabIndex = 6;
            campoNumericoCantidadEmitida.Value = new decimal(new int[] { 1, 0, 0, 0 });
            campoNumericoCantidadEmitida.ValueChanged += ValidarAccionAAgregar;
            // 
            // botonAgregarAccion
            // 
            botonAgregarAccion.Enabled = false;
            botonAgregarAccion.Location = new Point(105, 188);
            botonAgregarAccion.Name = "botonAgregarAccion";
            botonAgregarAccion.Size = new Size(75, 23);
            botonAgregarAccion.TabIndex = 8;
            botonAgregarAccion.Text = "Agregar";
            botonAgregarAccion.UseVisualStyleBackColor = true;
            botonAgregarAccion.Click += BotonAgregarAccion_Click;
            // 
            // FormularioAgregarAccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 229);
            Controls.Add(botonAgregarAccion);
            Controls.Add(etiquetaCantidadEmitida);
            Controls.Add(campoNumericoCantidadEmitida);
            Controls.Add(etiquetaCotizacionActual);
            Controls.Add(campoNumericoCotizacionActual);
            Controls.Add(label2);
            Controls.Add(selectorDenominacion);
            Controls.Add(label1);
            Controls.Add(campoDeTextoEnmascaradoCodigo);
            Name = "FormularioAgregarAccion";
            Text = "Agregar Acción";
            Load += FormularioAgregarAccion_Load;
            ((System.ComponentModel.ISupportInitialize)campoNumericoCotizacionActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCantidadEmitida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox campoDeTextoEnmascaradoCodigo;
        private Label label1;
        private ComboBox selectorDenominacion;
        private Label label2;
        private NumericUpDown campoNumericoCotizacionActual;
        private Label etiquetaCotizacionActual;
        private Label etiquetaCantidadEmitida;
        private NumericUpDown campoNumericoCantidadEmitida;
        private Button botonAgregarAccion;
    }
}