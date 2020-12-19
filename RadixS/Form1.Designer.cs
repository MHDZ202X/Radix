namespace RadixS
{
    partial class RadixS
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.ltbDesordenado = new System.Windows.Forms.ListBox();
            this.ltbOrdenados = new System.Windows.Forms.ListBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(216, 53);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click_1);
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(90, 53);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 23);
            this.txtTamaño.TabIndex = 1;
            // 
            // ltbDesordenado
            // 
            this.ltbDesordenado.FormattingEnabled = true;
            this.ltbDesordenado.ItemHeight = 15;
            this.ltbDesordenado.Location = new System.Drawing.Point(90, 171);
            this.ltbDesordenado.Name = "ltbDesordenado";
            this.ltbDesordenado.Size = new System.Drawing.Size(120, 109);
            this.ltbDesordenado.TabIndex = 2;
            // 
            // ltbOrdenados
            // 
            this.ltbOrdenados.FormattingEnabled = true;
            this.ltbOrdenados.ItemHeight = 15;
            this.ltbOrdenados.Location = new System.Drawing.Point(279, 171);
            this.ltbOrdenados.Name = "ltbOrdenados";
            this.ltbOrdenados.Size = new System.Drawing.Size(120, 109);
            this.ltbOrdenados.TabIndex = 2;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(279, 142);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(74, 23);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(216, 82);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnAleatorio
            // 
            this.btnAleatorio.Location = new System.Drawing.Point(216, 111);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(75, 23);
            this.btnAleatorio.TabIndex = 5;
            this.btnAleatorio.Text = "Aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(90, 83);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 1;
            // 
            // RadixS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.btnAleatorio);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.ltbOrdenados);
            this.Controls.Add(this.ltbDesordenado);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.btnCrear);
            this.Name = "RadixS";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.ListBox ltbDesordenado;
        private System.Windows.Forms.ListBox ltbOrdenados;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.TextBox txtValor;
    }
}

