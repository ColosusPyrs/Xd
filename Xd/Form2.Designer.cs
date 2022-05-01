namespace Xd
{
    partial class CalcHaron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcHaron));
            this.Atras = new System.Windows.Forms.Button();
            this.SeparadorHaron = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextoHaron = new System.Windows.Forms.Label();
            this.Lado1 = new System.Windows.Forms.Label();
            this.Lado2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Lado3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(12, 12);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 23);
            this.Atras.TabIndex = 0;
            this.Atras.Text = "Atras.";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // SeparadorHaron
            // 
            this.SeparadorHaron.AutoSize = true;
            this.SeparadorHaron.Location = new System.Drawing.Point(169, 12);
            this.SeparadorHaron.Name = "SeparadorHaron";
            this.SeparadorHaron.Size = new System.Drawing.Size(9, 429);
            this.SeparadorHaron.TabIndex = 1;
            this.SeparadorHaron.Text = "l\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\nl\r\n" +
    "l\r\nl\r\nl\r\nl\r\nl\r\nl";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextoHaron
            // 
            this.TextoHaron.AutoSize = true;
            this.TextoHaron.Location = new System.Drawing.Point(185, 21);
            this.TextoHaron.Name = "TextoHaron";
            this.TextoHaron.Size = new System.Drawing.Size(145, 13);
            this.TextoHaron.TabIndex = 3;
            this.TextoHaron.Text = "Hallar el area de un triangulo.";
            // 
            // Lado1
            // 
            this.Lado1.AutoSize = true;
            this.Lado1.Location = new System.Drawing.Point(229, 114);
            this.Lado1.Name = "Lado1";
            this.Lado1.Size = new System.Drawing.Size(17, 13);
            this.Lado1.TabIndex = 4;
            this.Lado1.Text = "A:";
            this.Lado1.Click += new System.EventHandler(this.lado1_Click);
            // 
            // Lado2
            // 
            this.Lado2.AutoSize = true;
            this.Lado2.Location = new System.Drawing.Point(399, 259);
            this.Lado2.Name = "Lado2";
            this.Lado2.Size = new System.Drawing.Size(17, 13);
            this.Lado2.TabIndex = 5;
            this.Lado2.Text = "B:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(402, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(402, 367);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(118, 23);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "Mostrar resultado.";
            this.Resultado.UseVisualStyleBackColor = true;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(592, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Lado3
            // 
            this.Lado3.AutoSize = true;
            this.Lado3.Location = new System.Drawing.Point(589, 114);
            this.Lado3.Name = "Lado3";
            this.Lado3.Size = new System.Drawing.Size(17, 13);
            this.Lado3.TabIndex = 10;
            this.Lado3.Text = "C:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CalcHaron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Lado3);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Lado2);
            this.Controls.Add(this.Lado1);
            this.Controls.Add(this.TextoHaron);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SeparadorHaron);
            this.Controls.Add(this.Atras);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalcHaron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora alv: Haron.";
            this.Load += new System.EventHandler(this.CalcHaron_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label SeparadorHaron;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TextoHaron;
        private System.Windows.Forms.Label Lado1;
        private System.Windows.Forms.Label Lado2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Resultado;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Lado3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}