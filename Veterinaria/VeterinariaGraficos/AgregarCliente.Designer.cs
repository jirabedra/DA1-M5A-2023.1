
namespace VeterinariaGraficos
{
    partial class AgregarCliente
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
            this.lblAgregarCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.nupId = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbEsSocio = new System.Windows.Forms.CheckBox();
            this.radioBtnFamiliar = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nupId)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarCliente
            // 
            this.lblAgregarCliente.AutoSize = true;
            this.lblAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarCliente.Location = new System.Drawing.Point(40, 43);
            this.lblAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarCliente.Name = "lblAgregarCliente";
            this.lblAgregarCliente.Size = new System.Drawing.Size(181, 29);
            this.lblAgregarCliente.TabIndex = 0;
            this.lblAgregarCliente.Text = "Agregar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA NACIMIENTO: ";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(142, 349);
            this.btnAgregarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(111, 42);
            this.btnAgregarCliente.TabIndex = 6;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // nupId
            // 
            this.nupId.Location = new System.Drawing.Point(452, 120);
            this.nupId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nupId.Name = "nupId";
            this.nupId.Size = new System.Drawing.Size(105, 26);
            this.nupId.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(452, 160);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 26);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombreChanged);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(452, 211);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(198, 26);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // cbEsSocio
            // 
            this.cbEsSocio.AutoSize = true;
            this.cbEsSocio.Location = new System.Drawing.Point(450, 266);
            this.cbEsSocio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEsSocio.Name = "cbEsSocio";
            this.cbEsSocio.Size = new System.Drawing.Size(102, 24);
            this.cbEsSocio.TabIndex = 10;
            this.cbEsSocio.Text = "es socio?";
            this.cbEsSocio.UseVisualStyleBackColor = true;
            // 
            // radioBtnFamiliar
            // 
            this.radioBtnFamiliar.AutoSize = true;
            this.radioBtnFamiliar.Location = new System.Drawing.Point(142, 266);
            this.radioBtnFamiliar.Name = "radioBtnFamiliar";
            this.radioBtnFamiliar.Size = new System.Drawing.Size(147, 24);
            this.radioBtnFamiliar.TabIndex = 11;
            this.radioBtnFamiliar.TabStop = true;
            this.radioBtnFamiliar.Text = "familiar de socio";
            this.radioBtnFamiliar.UseVisualStyleBackColor = true;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioBtnFamiliar);
            this.Controls.Add(this.cbEsSocio);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.nupId);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAgregarCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgregarCliente";
            this.Size = new System.Drawing.Size(810, 482);
            this.Load += new System.EventHandler(this.AgregarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.NumericUpDown nupId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbEsSocio;
        private System.Windows.Forms.RadioButton radioBtnFamiliar;
    }
}
