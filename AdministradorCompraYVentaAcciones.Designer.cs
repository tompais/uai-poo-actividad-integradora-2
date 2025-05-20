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
            dataGridView1 = new DataGridView();
            Legajo = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            botonAgregarInversor = new Button();
            botonEliminarInversor = new Button();
            botonModificarInversor = new Button();
            etiquetaInversores = new Label();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            etiquetaAccionesDelInversor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Legajo, Apellido, Nombre, DNI });
            dataGridView1.Location = new Point(12, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(447, 150);
            dataGridView1.TabIndex = 0;
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
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(12, 282);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(646, 150);
            dataGridView2.TabIndex = 5;
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
            // AdministradorCompraYVentaAcciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 445);
            Controls.Add(etiquetaAccionesDelInversor);
            Controls.Add(dataGridView2);
            Controls.Add(etiquetaInversores);
            Controls.Add(botonModificarInversor);
            Controls.Add(botonEliminarInversor);
            Controls.Add(botonAgregarInversor);
            Controls.Add(dataGridView1);
            Name = "AdministradorCompraYVentaAcciones";
            Text = "Administrador de Compra y Venta de Acciones";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Legajo;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn DNI;
        private Button botonAgregarInversor;
        private Button botonEliminarInversor;
        private Button botonModificarInversor;
        private Label etiquetaInversores;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label etiquetaAccionesDelInversor;
    }
}
