namespace uai_poo_actividad_integradora_2.GUI.Formularios.Acciones.Modificar
{
    partial class FormularioModificarAccion
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
            botonModificarAccion = new Button();
            etiquetaCantidadEmitida = new Label();
            campoNumericoCantidadEmitida = new NumericUpDown();
            etiquetaCotizacionActual = new Label();
            campoNumericoCotizacionActual = new NumericUpDown();
            label2 = new Label();
            selectorDenominacion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCantidadEmitida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCotizacionActual).BeginInit();
            SuspendLayout();
            // 
            // botonModificarAccion
            // 
            botonModificarAccion.Enabled = false;
            botonModificarAccion.Location = new Point(107, 144);
            botonModificarAccion.Name = "botonModificarAccion";
            botonModificarAccion.Size = new Size(75, 23);
            botonModificarAccion.TabIndex = 17;
            botonModificarAccion.Text = "Modificar";
            botonModificarAccion.UseVisualStyleBackColor = true;
            botonModificarAccion.Click += BotonModificarAccion_Click;
            // 
            // etiquetaCantidadEmitida
            // 
            etiquetaCantidadEmitida.AutoSize = true;
            etiquetaCantidadEmitida.Location = new Point(84, 97);
            etiquetaCantidadEmitida.Name = "etiquetaCantidadEmitida";
            etiquetaCantidadEmitida.Size = new Size(98, 15);
            etiquetaCantidadEmitida.TabIndex = 16;
            etiquetaCantidadEmitida.Text = "Cantidad Emitida";
            // 
            // campoNumericoCantidadEmitida
            // 
            campoNumericoCantidadEmitida.Location = new Point(84, 115);
            campoNumericoCantidadEmitida.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoCantidadEmitida.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            campoNumericoCantidadEmitida.Name = "campoNumericoCantidadEmitida";
            campoNumericoCantidadEmitida.Size = new Size(121, 23);
            campoNumericoCantidadEmitida.TabIndex = 15;
            campoNumericoCantidadEmitida.Value = new decimal(new int[] { 1, 0, 0, 0 });
            campoNumericoCantidadEmitida.ValueChanged += ValidarAccionAModificar;
            // 
            // etiquetaCotizacionActual
            // 
            etiquetaCotizacionActual.AutoSize = true;
            etiquetaCotizacionActual.Location = new Point(84, 53);
            etiquetaCotizacionActual.Name = "etiquetaCotizacionActual";
            etiquetaCotizacionActual.Size = new Size(100, 15);
            etiquetaCotizacionActual.TabIndex = 14;
            etiquetaCotizacionActual.Text = "Cotización Actual";
            // 
            // campoNumericoCotizacionActual
            // 
            campoNumericoCotizacionActual.DecimalPlaces = 2;
            campoNumericoCotizacionActual.Location = new Point(84, 71);
            campoNumericoCotizacionActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            campoNumericoCotizacionActual.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoCotizacionActual.Name = "campoNumericoCotizacionActual";
            campoNumericoCotizacionActual.Size = new Size(121, 23);
            campoNumericoCotizacionActual.TabIndex = 13;
            campoNumericoCotizacionActual.Value = new decimal(new int[] { 100, 0, 0, 0 });
            campoNumericoCotizacionActual.ValueChanged += ValidarAccionAModificar;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 9);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 12;
            label2.Text = "Denominación";
            // 
            // selectorDenominacion
            // 
            selectorDenominacion.DropDownStyle = ComboBoxStyle.DropDownList;
            selectorDenominacion.FormattingEnabled = true;
            selectorDenominacion.Items.AddRange(new object[] { "Ordinaria", "Preferida", "Clase A", "Clase B" });
            selectorDenominacion.Location = new Point(84, 27);
            selectorDenominacion.Name = "selectorDenominacion";
            selectorDenominacion.Size = new Size(121, 23);
            selectorDenominacion.TabIndex = 11;
            // 
            // FormularioModificarAccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 184);
            Controls.Add(botonModificarAccion);
            Controls.Add(etiquetaCantidadEmitida);
            Controls.Add(campoNumericoCantidadEmitida);
            Controls.Add(etiquetaCotizacionActual);
            Controls.Add(campoNumericoCotizacionActual);
            Controls.Add(label2);
            Controls.Add(selectorDenominacion);
            Name = "FormularioModificarAccion";
            Text = "Modificar Acción";
            Load += FormularioModificarAccion_Load;
            ((System.ComponentModel.ISupportInitialize)campoNumericoCantidadEmitida).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoCotizacionActual).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonModificarAccion;
        private Label etiquetaCantidadEmitida;
        private NumericUpDown campoNumericoCantidadEmitida;
        private Label etiquetaCotizacionActual;
        private NumericUpDown campoNumericoCotizacionActual;
        private Label label2;
        private ComboBox selectorDenominacion;
    }
}