
namespace VeterinariaGraficos
{
    partial class SubirArchivo
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
            this.btn_subirArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_subirArchivo
            // 
            this.btn_subirArchivo.Location = new System.Drawing.Point(299, 218);
            this.btn_subirArchivo.Name = "btn_subirArchivo";
            this.btn_subirArchivo.Size = new System.Drawing.Size(220, 80);
            this.btn_subirArchivo.TabIndex = 0;
            this.btn_subirArchivo.Text = "Subir archivo";
            this.btn_subirArchivo.UseVisualStyleBackColor = true;
            this.btn_subirArchivo.Click += new System.EventHandler(this.btn_subirArchivo_click);
            // 
            // SubirArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_subirArchivo);
            this.Name = "SubirArchivo";
            this.Size = new System.Drawing.Size(874, 513);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_subirArchivo;
    }
}
