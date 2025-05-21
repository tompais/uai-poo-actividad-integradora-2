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
            botonAgregarInversor = new Button();
            botonEliminarInversor = new Button();
            botonModificarInversor = new Button();
            etiquetaInversores = new Label();
            grillaAccionesDelInversor = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            etiquetaAccionesDelInversor = new Label();
            dataGridView1 = new DataGridView();
            etiquetaAcciones = new Label();
            Código = new DataGridViewTextBoxColumn();
            Denominación = new DataGridViewTextBoxColumn();
            CotizaciónActual = new DataGridViewTextBoxColumn();
            CantidadEmitida = new DataGridViewTextBoxColumn();
            botonModificarAccion = new Button();
            botonEliminarAccion = new Button();
            botonAgregarAccion = new Button();
            comprarAccion = new Button();
            venderAccion = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaInversores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionesDelInversor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grillaInversores
            // 
            grillaInversores.AllowUserToAddRows = false;
            grillaInversores.AllowUserToDeleteRows = false;
            grillaInversores.AllowUserToOrderColumns = true;
            grillaInversores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaInversores.Columns.AddRange(new DataGridViewColumn[] { Legajo, Apellido, Nombre, DNI });
            grillaInversores.Location = new Point(12, 27);
            grillaInversores.Name = "grillaInversores";
            grillaInversores.ReadOnly = true;
            grillaInversores.Size = new Size(447, 150);
            grillaInversores.TabIndex = 0;
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
            // botonAgregarInversor
            // 
            botonAgregarInversor.Location = new Point(12, 183);
            botonAgregarInversor.Name = "botonAgregarInversor";
            botonAgregarInversor.Size = new Size(75, 23);
            botonAgregarInversor.TabIndex = 1;
            botonAgregarInversor.Text = "Agregar";
            botonAgregarInversor.UseVisualStyleBackColor = true;
            // 
            // botonEliminarInversor
            // 
            botonEliminarInversor.Location = new Point(93, 183);
            botonEliminarInversor.Name = "botonEliminarInversor";
            botonEliminarInversor.Size = new Size(75, 23);
            botonEliminarInversor.TabIndex = 2;
            botonEliminarInversor.Text = "Eliminar";
            botonEliminarInversor.UseVisualStyleBackColor = true;
            // 
            // botonModificarInversor
            // 
            botonModificarInversor.Location = new Point(174, 183);
            botonModificarInversor.Name = "botonModificarInversor";
            botonModificarInversor.Size = new Size(75, 23);
            botonModificarInversor.TabIndex = 3;
            botonModificarInversor.Text = "Modificar";
            botonModificarInversor.UseVisualStyleBackColor = true;
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
            // grillaAccionesDelInversor
            // 
            grillaAccionesDelInversor.AllowUserToAddRows = false;
            grillaAccionesDelInversor.AllowUserToDeleteRows = false;
            grillaAccionesDelInversor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAccionesDelInversor.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            grillaAccionesDelInversor.Location = new Point(12, 282);
            grillaAccionesDelInversor.Name = "grillaAccionesDelInversor";
            grillaAccionesDelInversor.ReadOnly = true;
            grillaAccionesDelInversor.Size = new Size(646, 150);
            grillaAccionesDelInversor.TabIndex = 5;
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
            // etiquetaAccionesDelInversor
            // 
            etiquetaAccionesDelInversor.AutoSize = true;
            etiquetaAccionesDelInversor.Location = new Point(12, 264);
            etiquetaAccionesDelInversor.Name = "etiquetaAccionesDelInversor";
            etiquetaAccionesDelInversor.Size = new Size(119, 15);
            etiquetaAccionesDelInversor.TabIndex = 6;
            etiquetaAccionesDelInversor.Text = "Acciones del Inversor";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Código, Denominación, CotizaciónActual, CantidadEmitida });
            dataGridView1.Location = new Point(493, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 7;
            // 
            // etiquetaAcciones
            // 
            etiquetaAcciones.AutoSize = true;
            etiquetaAcciones.Location = new Point(493, 9);
            etiquetaAcciones.Name = "etiquetaAcciones";
            etiquetaAcciones.Size = new Size(55, 15);
            etiquetaAcciones.TabIndex = 8;
            etiquetaAcciones.Text = "Acciones";
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
            // botonModificarAccion
            // 
            botonModificarAccion.Location = new Point(655, 183);
            botonModificarAccion.Name = "botonModificarAccion";
            botonModificarAccion.Size = new Size(75, 23);
            botonModificarAccion.TabIndex = 11;
            botonModificarAccion.Text = "Modificar";
            botonModificarAccion.UseVisualStyleBackColor = true;
            // 
            // botonEliminarAccion
            // 
            botonEliminarAccion.Location = new Point(574, 183);
            botonEliminarAccion.Name = "botonEliminarAccion";
            botonEliminarAccion.Size = new Size(75, 23);
            botonEliminarAccion.TabIndex = 10;
            botonEliminarAccion.Text = "Eliminar";
            botonEliminarAccion.UseVisualStyleBackColor = true;
            // 
            // botonAgregarAccion
            // 
            botonAgregarAccion.Location = new Point(493, 183);
            botonAgregarAccion.Name = "botonAgregarAccion";
            botonAgregarAccion.Size = new Size(75, 23);
            botonAgregarAccion.TabIndex = 9;
            botonAgregarAccion.Text = "Agregar";
            botonAgregarAccion.UseVisualStyleBackColor = true;
            // 
            // comprarAccion
            // 
            comprarAccion.Location = new Point(664, 282);
            comprarAccion.Name = "comprarAccion";
            comprarAccion.Size = new Size(75, 23);
            comprarAccion.TabIndex = 12;
            comprarAccion.Text = "Comprar";
            comprarAccion.UseVisualStyleBackColor = true;
            // 
            // venderAccion
            // 
            venderAccion.Location = new Point(664, 311);
            venderAccion.Name = "venderAccion";
            venderAccion.Size = new Size(75, 23);
            venderAccion.TabIndex = 13;
            venderAccion.Text = "Vender";
            venderAccion.UseVisualStyleBackColor = true;
            // 
            // AdministradorCompraYVentaAcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 445);
            Controls.Add(venderAccion);
            Controls.Add(comprarAccion);
            Controls.Add(botonModificarAccion);
            Controls.Add(botonEliminarAccion);
            Controls.Add(botonAgregarAccion);
            Controls.Add(etiquetaAcciones);
            Controls.Add(dataGridView1);
            Controls.Add(etiquetaAccionesDelInversor);
            Controls.Add(grillaAccionesDelInversor);
            Controls.Add(etiquetaInversores);
            Controls.Add(botonModificarInversor);
            Controls.Add(botonEliminarInversor);
            Controls.Add(botonAgregarInversor);
            Controls.Add(grillaInversores);
            Name = "AdministradorCompraYVentaAcciones";
            Text = "Administrador de Compra y Venta de Acciones";
            ((System.ComponentModel.ISupportInitialize)grillaInversores).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaAccionesDelInversor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaInversores;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private Button botonAgregarInversor;
        private Button botonEliminarInversor;
        private Button botonModificarInversor;
        private Label etiquetaInversores;
        private DataGridView grillaAccionesDelInversor;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label etiquetaAccionesDelInversor;
        private DataGridView dataGridView1;
        private Label etiquetaAcciones;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Denominación;
        private DataGridViewTextBoxColumn CotizaciónActual;
        private DataGridViewTextBoxColumn CantidadEmitida;
        private Button botonModificarAccion;
        private Button botonEliminarAccion;
        private Button botonAgregarAccion;
        private Button comprarAccion;
        private Button venderAccion;
    }
}
