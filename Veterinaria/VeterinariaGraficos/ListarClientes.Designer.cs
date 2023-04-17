
namespace VeterinariaGraficos
{
    partial class ListarClientes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgUserList = new System.Windows.Forms.DataGridView();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.lblEjemplo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTAR CLIENTES";
            // 
            // dgUserList
            // 
            this.dgUserList.AllowUserToAddRows = false;
            this.dgUserList.AllowUserToDeleteRows = false;
            this.dgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUserList.Location = new System.Drawing.Point(25, 49);
            this.dgUserList.Name = "dgUserList";
            this.dgUserList.ReadOnly = true;
            this.dgUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserList.Size = new System.Drawing.Size(386, 171);
            this.dgUserList.TabIndex = 1;
            this.dgUserList.Click += new System.EventHandler(this.PrintSelectedRow);
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(29, 257);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(135, 21);
            this.cbClientes.TabIndex = 2;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // lblEjemplo
            // 
            this.lblEjemplo.AutoSize = true;
            this.lblEjemplo.Location = new System.Drawing.Point(219, 260);
            this.lblEjemplo.Name = "lblEjemplo";
            this.lblEjemplo.Size = new System.Drawing.Size(35, 13);
            this.lblEjemplo.TabIndex = 3;
            this.lblEjemplo.Text = "label2";
            // 
            // ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEjemplo);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.dgUserList);
            this.Controls.Add(this.label1);
            this.Name = "ListarClientes";
            this.Size = new System.Drawing.Size(434, 344);
            this.Load += new System.EventHandler(this.ListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUserList;
        private System.Windows.Forms.ComboBox cbClientes;
        private System.Windows.Forms.Label lblEjemplo;
    }
}
