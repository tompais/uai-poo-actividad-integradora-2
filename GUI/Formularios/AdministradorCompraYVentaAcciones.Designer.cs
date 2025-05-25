namespace uai_poo_actividad_integradora_2
{
    partial class AdministradorCompraYVentaAcciones
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
            grillaInversores = new DataGridView();
            Legajo = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            botonAgregarInversor = new Button();
            botonEliminarInversor = new Button();
            botonModificarInversor = new Button();
            etiquetaInversores = new Label();
            grillaInversiones = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            etiquetaInversiones = new Label();
            grillaAcciones = new DataGridView();
            Código = new DataGridViewTextBoxColumn();
            Denominación = new DataGridViewTextBoxColumn();
            CotizaciónActual = new DataGridViewTextBoxColumn();
            CantidadEmitida = new DataGridViewTextBoxColumn();
            etiquetaAcciones = new Label();
            botonModificarAccion = new Button();
            botonEliminarAccion = new Button();
            botonAgregarAccion = new Button();
            botonComprarAccion = new Button();
            botonVenderAccion = new Button();
            campoNumericoTotalRecaudadoClientesComunes = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            campoNumericoTotalRecaudadoClientesPremium1 = new NumericUpDown();
            campoNumericoTotalRecaudadoClientesPremium2 = new NumericUpDown();
            label3 = new Label();
            campoNumericoTotalRecaudadoGeneral = new NumericUpDown();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaInversores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversiones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAcciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesComunes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesPremium1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesPremium2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoGeneral).BeginInit();
            SuspendLayout();
            // 
            // grillaInversores
            // 
            grillaInversores.AllowUserToAddRows = false;
            grillaInversores.AllowUserToDeleteRows = false;
            grillaInversores.AllowUserToOrderColumns = true;
            grillaInversores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversores.Columns.AddRange(new DataGridViewColumn[] { Legajo, Apellido, Nombre, DNI, Tipo });
            grillaInversores.Location = new Point(12, 27);
            grillaInversores.Name = "grillaInversores";
            grillaInversores.ReadOnly = true;
            grillaInversores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaInversores.Size = new Size(545, 150);
            grillaInversores.TabIndex = 0;
            grillaInversores.SelectionChanged += GrillaInversores_SelectionChanged;
            // 
            // Legajo
            // 
            Legajo.HeaderText = "Legajo";
            Legajo.Name = "Legajo";
            Legajo.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // botonAgregarInversor
            // 
            botonAgregarInversor.Location = new Point(12, 183);
            botonAgregarInversor.Name = "botonAgregarInversor";
            botonAgregarInversor.Size = new Size(75, 23);
            botonAgregarInversor.TabIndex = 1;
            botonAgregarInversor.Text = "Agregar";
            botonAgregarInversor.UseVisualStyleBackColor = true;
            botonAgregarInversor.Click += BotonAgregarInversor_Click;
            // 
            // botonEliminarInversor
            // 
            botonEliminarInversor.Enabled = false;
            botonEliminarInversor.Location = new Point(93, 183);
            botonEliminarInversor.Name = "botonEliminarInversor";
            botonEliminarInversor.Size = new Size(75, 23);
            botonEliminarInversor.TabIndex = 2;
            botonEliminarInversor.Text = "Eliminar";
            botonEliminarInversor.UseVisualStyleBackColor = true;
            botonEliminarInversor.Click += BotonEliminarInversor_Click;
            // 
            // botonModificarInversor
            // 
            botonModificarInversor.Enabled = false;
            botonModificarInversor.Location = new Point(174, 183);
            botonModificarInversor.Name = "botonModificarInversor";
            botonModificarInversor.Size = new Size(75, 23);
            botonModificarInversor.TabIndex = 3;
            botonModificarInversor.Text = "Modificar";
            botonModificarInversor.UseVisualStyleBackColor = true;
            botonModificarInversor.Click += BotonModificarInversor_Click;
            // 
            // etiquetaInversores
            // 
            etiquetaInversores.AutoSize = true;
            etiquetaInversores.Location = new Point(12, 9);
            etiquetaInversores.Name = "etiquetaInversores";
            etiquetaInversores.Size = new Size(60, 15);
            etiquetaInversores.TabIndex = 4;
            etiquetaInversores.Text = "Inversores";
            // 
            // grillaInversiones
            // 
            grillaInversiones.AllowUserToAddRows = false;
            grillaInversiones.AllowUserToDeleteRows = false;
            grillaInversiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversiones.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            grillaInversiones.Location = new Point(12, 282);
            grillaInversiones.Name = "grillaInversiones";
            grillaInversiones.ReadOnly = true;
            grillaInversiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaInversiones.Size = new Size(646, 150);
            grillaInversiones.TabIndex = 5;
            grillaInversiones.SelectionChanged += GrillaInversiones_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Codigo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Denominación";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cotización Actual";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Cantidad Emitida";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad en Posesión";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Valor Total de la Inversión";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // etiquetaInversiones
            // 
            etiquetaInversiones.AutoSize = true;
            etiquetaInversiones.Location = new Point(12, 264);
            etiquetaInversiones.Name = "etiquetaInversiones";
            etiquetaInversiones.Size = new Size(66, 15);
            etiquetaInversiones.TabIndex = 6;
            etiquetaInversiones.Text = "Inversiones";
            // 
            // grillaAcciones
            // 
            grillaAcciones.AllowUserToAddRows = false;
            grillaAcciones.AllowUserToDeleteRows = false;
            grillaAcciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAcciones.Columns.AddRange(new DataGridViewColumn[] { Código, Denominación, CotizaciónActual, CantidadEmitida });
            grillaAcciones.Location = new Point(594, 27);
            grillaAcciones.Name = "grillaAcciones";
            grillaAcciones.ReadOnly = true;
            grillaAcciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaAcciones.Size = new Size(445, 150);
            grillaAcciones.TabIndex = 7;
            grillaAcciones.SelectionChanged += GrillaAcciones_SelectionChanged;
            // 
            // Código
            // 
            Código.HeaderText = "Código";
            Código.Name = "Código";
            Código.ReadOnly = true;
            // 
            // Denominación
            // 
            Denominación.HeaderText = "Denominación";
            Denominación.Name = "Denominación";
            Denominación.ReadOnly = true;
            // 
            // CotizaciónActual
            // 
            CotizaciónActual.HeaderText = "Cotización Actual";
            CotizaciónActual.Name = "CotizaciónActual";
            CotizaciónActual.ReadOnly = true;
            // 
            // CantidadEmitida
            // 
            CantidadEmitida.HeaderText = "Cantidad Emitida";
            CantidadEmitida.Name = "CantidadEmitida";
            CantidadEmitida.ReadOnly = true;
            // 
            // etiquetaAcciones
            // 
            etiquetaAcciones.AutoSize = true;
            etiquetaAcciones.Location = new Point(594, 9);
            etiquetaAcciones.Name = "etiquetaAcciones";
            etiquetaAcciones.Size = new Size(55, 15);
            etiquetaAcciones.TabIndex = 8;
            etiquetaAcciones.Text = "Acciones";
            // 
            // botonModificarAccion
            // 
            botonModificarAccion.Enabled = false;
            botonModificarAccion.Location = new Point(756, 183);
            botonModificarAccion.Name = "botonModificarAccion";
            botonModificarAccion.Size = new Size(75, 23);
            botonModificarAccion.TabIndex = 11;
            botonModificarAccion.Text = "Modificar";
            botonModificarAccion.UseVisualStyleBackColor = true;
            botonModificarAccion.Click += BotonModificarAccion_Click;
            // 
            // botonEliminarAccion
            // 
            botonEliminarAccion.Enabled = false;
            botonEliminarAccion.Location = new Point(675, 183);
            botonEliminarAccion.Name = "botonEliminarAccion";
            botonEliminarAccion.Size = new Size(75, 23);
            botonEliminarAccion.TabIndex = 10;
            botonEliminarAccion.Text = "Eliminar";
            botonEliminarAccion.UseVisualStyleBackColor = true;
            botonEliminarAccion.Click += BotonEliminarAccion_Click;
            // 
            // botonAgregarAccion
            // 
            botonAgregarAccion.Location = new Point(594, 183);
            botonAgregarAccion.Name = "botonAgregarAccion";
            botonAgregarAccion.Size = new Size(75, 23);
            botonAgregarAccion.TabIndex = 9;
            botonAgregarAccion.Text = "Agregar";
            botonAgregarAccion.UseVisualStyleBackColor = true;
            botonAgregarAccion.Click += BotonAgregarAccion_Click;
            // 
            // botonComprarAccion
            // 
            botonComprarAccion.Enabled = false;
            botonComprarAccion.Location = new Point(664, 282);
            botonComprarAccion.Name = "botonComprarAccion";
            botonComprarAccion.Size = new Size(75, 23);
            botonComprarAccion.TabIndex = 12;
            botonComprarAccion.Text = "Comprar";
            botonComprarAccion.UseVisualStyleBackColor = true;
            botonComprarAccion.Click += BotonComprarAccion_Click;
            // 
            // botonVenderAccion
            // 
            botonVenderAccion.Enabled = false;
            botonVenderAccion.Location = new Point(664, 311);
            botonVenderAccion.Name = "botonVenderAccion";
            botonVenderAccion.Size = new Size(75, 23);
            botonVenderAccion.TabIndex = 13;
            botonVenderAccion.Text = "Vender";
            botonVenderAccion.UseVisualStyleBackColor = true;
            botonVenderAccion.Click += BotonVenderAccion_Click;
            // 
            // campoNumericoTotalRecaudadoClientesComunes
            // 
            campoNumericoTotalRecaudadoClientesComunes.DecimalPlaces = 2;
            campoNumericoTotalRecaudadoClientesComunes.Location = new Point(1166, 230);
            campoNumericoTotalRecaudadoClientesComunes.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            campoNumericoTotalRecaudadoClientesComunes.Name = "campoNumericoTotalRecaudadoClientesComunes";
            campoNumericoTotalRecaudadoClientesComunes.ReadOnly = true;
            campoNumericoTotalRecaudadoClientesComunes.Size = new Size(120, 23);
            campoNumericoTotalRecaudadoClientesComunes.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1076, 212);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 15;
            label1.Text = "Total Recaudado de Clientes Comunes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1013, 264);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 16;
            label2.Text = "Total Recaudado por Clientes Premium (<=20.000)";
            // 
            // campoNumericoTotalRecaudadoClientesPremium1
            // 
            campoNumericoTotalRecaudadoClientesPremium1.DecimalPlaces = 2;
            campoNumericoTotalRecaudadoClientesPremium1.Location = new Point(1166, 282);
            campoNumericoTotalRecaudadoClientesPremium1.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            campoNumericoTotalRecaudadoClientesPremium1.Name = "campoNumericoTotalRecaudadoClientesPremium1";
            campoNumericoTotalRecaudadoClientesPremium1.ReadOnly = true;
            campoNumericoTotalRecaudadoClientesPremium1.Size = new Size(120, 23);
            campoNumericoTotalRecaudadoClientesPremium1.TabIndex = 17;
            // 
            // campoNumericoTotalRecaudadoClientesPremium2
            // 
            campoNumericoTotalRecaudadoClientesPremium2.DecimalPlaces = 2;
            campoNumericoTotalRecaudadoClientesPremium2.Location = new Point(1166, 337);
            campoNumericoTotalRecaudadoClientesPremium2.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            campoNumericoTotalRecaudadoClientesPremium2.Name = "campoNumericoTotalRecaudadoClientesPremium2";
            campoNumericoTotalRecaudadoClientesPremium2.ReadOnly = true;
            campoNumericoTotalRecaudadoClientesPremium2.Size = new Size(120, 23);
            campoNumericoTotalRecaudadoClientesPremium2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1021, 319);
            label3.Name = "label3";
            label3.Size = new Size(265, 15);
            label3.TabIndex = 18;
            label3.Text = "Total Recaudado por Clientes Premium (>20.000)";
            // 
            // campoNumericoTotalRecaudadoGeneral
            // 
            campoNumericoTotalRecaudadoGeneral.DecimalPlaces = 2;
            campoNumericoTotalRecaudadoGeneral.Location = new Point(1166, 395);
            campoNumericoTotalRecaudadoGeneral.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            campoNumericoTotalRecaudadoGeneral.Name = "campoNumericoTotalRecaudadoGeneral";
            campoNumericoTotalRecaudadoGeneral.ReadOnly = true;
            campoNumericoTotalRecaudadoGeneral.Size = new Size(120, 23);
            campoNumericoTotalRecaudadoGeneral.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1148, 377);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 20;
            label4.Text = "Total Recaudado General";
            // 
            // AdministradorCompraYVentaAcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1298, 445);
            Controls.Add(campoNumericoTotalRecaudadoGeneral);
            Controls.Add(label4);
            Controls.Add(campoNumericoTotalRecaudadoClientesPremium2);
            Controls.Add(label3);
            Controls.Add(campoNumericoTotalRecaudadoClientesPremium1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(campoNumericoTotalRecaudadoClientesComunes);
            Controls.Add(botonVenderAccion);
            Controls.Add(botonComprarAccion);
            Controls.Add(botonModificarAccion);
            Controls.Add(botonEliminarAccion);
            Controls.Add(botonAgregarAccion);
            Controls.Add(etiquetaAcciones);
            Controls.Add(grillaAcciones);
            Controls.Add(etiquetaInversiones);
            Controls.Add(grillaInversiones);
            Controls.Add(etiquetaInversores);
            Controls.Add(botonModificarInversor);
            Controls.Add(botonEliminarInversor);
            Controls.Add(botonAgregarInversor);
            Controls.Add(grillaInversores);
            Name = "AdministradorCompraYVentaAcciones";
            Text = "Administrador de Compra y Venta de Acciones";
            Load += AdministradorCompraYVentaAcciones_Load;
            ((System.ComponentModel.ISupportInitialize)grillaInversores).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaInversiones).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAcciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesComunes).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesPremium1).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoClientesPremium2).EndInit();
            ((System.ComponentModel.ISupportInitialize)campoNumericoTotalRecaudadoGeneral).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaInversores;
        private Button botonAgregarInversor;
        private Button botonEliminarInversor;
        private Button botonModificarInversor;
        private Label etiquetaInversores;
        private DataGridView grillaInversiones;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label etiquetaInversiones;
        private DataGridView grillaAcciones;
        private Label etiquetaAcciones;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Denominación;
        private DataGridViewTextBoxColumn CotizaciónActual;
        private DataGridViewTextBoxColumn CantidadEmitida;
        private Button botonModificarAccion;
        private Button botonEliminarAccion;
        private Button botonAgregarAccion;
        private Button botonComprarAccion;
        private Button botonVenderAccion;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Tipo;
        private NumericUpDown campoNumericoTotalRecaudadoClientesComunes;
        private Label label1;
        private Label label2;
        private NumericUpDown campoNumericoTotalRecaudadoClientesPremium1;
        private NumericUpDown campoNumericoTotalRecaudadoClientesPremium2;
        private Label label3;
        private NumericUpDown campoNumericoTotalRecaudadoGeneral;
        private Label label4;
    }
}
