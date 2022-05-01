namespace Xd
{
    partial class CalcInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcInicio));
            this.AreaHeron = new System.Windows.Forms.Button();
            this.SeparadorInicio = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.Button();
            this.Ecuacion2doGrado = new System.Windows.Forms.Button();
            this.EnergiaCineticaPotencial = new System.Windows.Forms.Button();
            this.PotencialElectrico = new System.Windows.Forms.Button();
            this.IntencidadLeyCoulomb = new System.Windows.Forms.Button();
            this.PendienteRecta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AreaHeron
            // 
            this.AreaHeron.Location = new System.Drawing.Point(12, 12);
            this.AreaHeron.Name = "AreaHeron";
            this.AreaHeron.Size = new System.Drawing.Size(106, 23);
            this.AreaHeron.TabIndex = 0;
            this.AreaHeron.Text = "Area con heron.";
            this.AreaHeron.UseVisualStyleBackColor = true;
            this.AreaHeron.Click += new System.EventHandler(this.AreaHeron_Click);
            // 
            // SeparadorInicio
            // 
            this.SeparadorInicio.AutoSize = true;
            this.SeparadorInicio.Location = new System.Drawing.Point(169, 12);
            this.SeparadorInicio.Name = "SeparadorInicio";
            this.SeparadorInicio.Size = new System.Drawing.Size(9, 429);
            this.SeparadorInicio.TabIndex = 1;
            this.SeparadorInicio.Text = "l\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\n" +
    "l\r\nl\r\nl\r\nl\r\nl\r\nl";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(12, 415);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(58, 23);
            this.Salir.TabIndex = 6;
            this.Salir.Text = "Salir.";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ecuacion2doGrado
            // 
            this.Ecuacion2doGrado.Location = new System.Drawing.Point(13, 42);
            this.Ecuacion2doGrado.Name = "Ecuacion2doGrado";
            this.Ecuacion2doGrado.Size = new System.Drawing.Size(130, 23);
            this.Ecuacion2doGrado.TabIndex = 1;
            this.Ecuacion2doGrado.Text = "Ecuacion de 2do grado.";
            this.Ecuacion2doGrado.UseVisualStyleBackColor = true;
            this.Ecuacion2doGrado.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnergiaCineticaPotencial
            // 
            this.EnergiaCineticaPotencial.Location = new System.Drawing.Point(12, 71);
            this.EnergiaCineticaPotencial.Name = "EnergiaCineticaPotencial";
            this.EnergiaCineticaPotencial.Size = new System.Drawing.Size(151, 23);
            this.EnergiaCineticaPotencial.TabIndex = 2;
            this.EnergiaCineticaPotencial.Text = "Energ. cinetica y potencial.";
            this.EnergiaCineticaPotencial.UseVisualStyleBackColor = true;
            this.EnergiaCineticaPotencial.Click += new System.EventHandler(this.EnergiaCineticaPotencial_Click);
            // 
            // PotencialElectrico
            // 
            this.PotencialElectrico.Location = new System.Drawing.Point(12, 100);
            this.PotencialElectrico.Name = "PotencialElectrico";
            this.PotencialElectrico.Size = new System.Drawing.Size(106, 23);
            this.PotencialElectrico.TabIndex = 3;
            this.PotencialElectrico.Text = "Potencial electrico.";
            this.PotencialElectrico.UseVisualStyleBackColor = true;
            this.PotencialElectrico.Click += new System.EventHandler(this.PotencialEle_Click);
            // 
            // IntencidadLeyCoulomb
            // 
            this.IntencidadLeyCoulomb.Location = new System.Drawing.Point(12, 129);
            this.IntencidadLeyCoulomb.Name = "IntencidadLeyCoulomb";
            this.IntencidadLeyCoulomb.Size = new System.Drawing.Size(151, 23);
            this.IntencidadLeyCoulomb.TabIndex = 4;
            this.IntencidadLeyCoulomb.Text = "Intensidad ley de Coulomb.";
            this.IntencidadLeyCoulomb.UseVisualStyleBackColor = true;
            this.IntencidadLeyCoulomb.Click += new System.EventHandler(this.IntencidadLeyCoulomb_Click);
            // 
            // PendienteRecta
            // 
            this.PendienteRecta.Location = new System.Drawing.Point(12, 159);
            this.PendienteRecta.Name = "PendienteRecta";
            this.PendienteRecta.Size = new System.Drawing.Size(131, 23);
            this.PendienteRecta.TabIndex = 5;
            this.PendienteRecta.Text = "Pendiente de la recta.";
            this.PendienteRecta.UseVisualStyleBackColor = true;
            this.PendienteRecta.Click += new System.EventHandler(this.PendienteRecta_Click);
            // 
            // CalcInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PendienteRecta);
            this.Controls.Add(this.IntencidadLeyCoulomb);
            this.Controls.Add(this.PotencialElectrico);
            this.Controls.Add(this.EnergiaCineticaPotencial);
            this.Controls.Add(this.Ecuacion2doGrado);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.SeparadorInicio);
            this.Controls.Add(this.AreaHeron);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora alv: Inicio.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AreaHeron;
        private System.Windows.Forms.Label SeparadorInicio;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Ecuacion2doGrado;
        private System.Windows.Forms.Button EnergiaCineticaPotencial;
        private System.Windows.Forms.Button PotencialElectrico;
        private System.Windows.Forms.Button IntencidadLeyCoulomb;
        private System.Windows.Forms.Button PendienteRecta;
    }
}

