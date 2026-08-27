namespace pryMenuTorresED
{
    partial class frmPila
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
            this.gbElemento = new System.Windows.Forms.GroupBox();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigoDos = new System.Windows.Forms.Label();
            this.lblNombreDos = new System.Windows.Forms.Label();
            this.lblTramiteDos = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigoDos = new System.Windows.Forms.TextBox();
            this.txtNombreDos = new System.Windows.Forms.TextBox();
            this.txtTramiteDos = new System.Windows.Forms.TextBox();
            this.gbElemento.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElemento
            // 
            this.gbElemento.Controls.Add(this.txtTramite);
            this.gbElemento.Controls.Add(this.txtNombre);
            this.gbElemento.Controls.Add(this.txtCodigo);
            this.gbElemento.Controls.Add(this.btnAgregar);
            this.gbElemento.Controls.Add(this.lblTramite);
            this.gbElemento.Controls.Add(this.lblNombre);
            this.gbElemento.Controls.Add(this.lblCodigo);
            this.gbElemento.Location = new System.Drawing.Point(13, 13);
            this.gbElemento.Name = "gbElemento";
            this.gbElemento.Size = new System.Drawing.Size(305, 250);
            this.gbElemento.TabIndex = 0;
            this.gbElemento.TabStop = false;
            this.gbElemento.Text = "Nuevo Elemento";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.txtCodigoDos);
            this.gbEliminar.Controls.Add(this.txtNombreDos);
            this.gbEliminar.Controls.Add(this.txtTramiteDos);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.lblCodigoDos);
            this.gbEliminar.Controls.Add(this.lblNombreDos);
            this.gbEliminar.Controls.Add(this.lblTramiteDos);
            this.gbEliminar.Location = new System.Drawing.Point(337, 13);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(310, 250);
            this.gbEliminar.TabIndex = 1;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar Elemento";
            // 
            // lstPila
            // 
            this.lstPila.BackColor = System.Drawing.Color.White;
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(13, 269);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(305, 212);
            this.lstPila.TabIndex = 2;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvDatos.Location = new System.Drawing.Point(337, 270);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(310, 211);
            this.dgvDatos.TabIndex = 3;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(7, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(7, 142);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite";
            // 
            // lblCodigoDos
            // 
            this.lblCodigoDos.AutoSize = true;
            this.lblCodigoDos.Location = new System.Drawing.Point(6, 20);
            this.lblCodigoDos.Name = "lblCodigoDos";
            this.lblCodigoDos.Size = new System.Drawing.Size(40, 13);
            this.lblCodigoDos.TabIndex = 3;
            this.lblCodigoDos.Text = "Código";
            // 
            // lblNombreDos
            // 
            this.lblNombreDos.AutoSize = true;
            this.lblNombreDos.Location = new System.Drawing.Point(6, 76);
            this.lblNombreDos.Name = "lblNombreDos";
            this.lblNombreDos.Size = new System.Drawing.Size(44, 13);
            this.lblNombreDos.TabIndex = 4;
            this.lblNombreDos.Text = "Nombre";
            // 
            // lblTramiteDos
            // 
            this.lblTramiteDos.AutoSize = true;
            this.lblTramiteDos.Location = new System.Drawing.Point(6, 142);
            this.lblTramiteDos.Name = "lblTramiteDos";
            this.lblTramiteDos.Size = new System.Drawing.Size(42, 13);
            this.lblTramiteDos.TabIndex = 5;
            this.lblTramiteDos.Text = "Trámite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 181);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(293, 63);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 181);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(293, 63);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(157, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(71, 135);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(157, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // txtCodigoDos
            // 
            this.txtCodigoDos.Location = new System.Drawing.Point(65, 17);
            this.txtCodigoDos.Name = "txtCodigoDos";
            this.txtCodigoDos.Size = new System.Drawing.Size(137, 20);
            this.txtCodigoDos.TabIndex = 7;
            // 
            // txtNombreDos
            // 
            this.txtNombreDos.Location = new System.Drawing.Point(65, 69);
            this.txtNombreDos.Name = "txtNombreDos";
            this.txtNombreDos.Size = new System.Drawing.Size(137, 20);
            this.txtNombreDos.TabIndex = 8;
            // 
            // txtTramiteDos
            // 
            this.txtTramiteDos.Location = new System.Drawing.Point(65, 135);
            this.txtTramiteDos.Name = "txtTramiteDos";
            this.txtTramiteDos.Size = new System.Drawing.Size(137, 20);
            this.txtTramiteDos.TabIndex = 9;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(668, 498);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbElemento);
            this.Name = "frmPila";
            this.Text = "Pila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.gbElemento.ResumeLayout(false);
            this.gbElemento.PerformLayout();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElemento;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoDos;
        private System.Windows.Forms.TextBox txtNombreDos;
        private System.Windows.Forms.TextBox txtTramiteDos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigoDos;
        private System.Windows.Forms.Label lblNombreDos;
        private System.Windows.Forms.Label lblTramiteDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}