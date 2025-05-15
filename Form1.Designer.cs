namespace Trabajo_final_Herramientas_1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.cant_inicial = new System.Windows.Forms.NumericUpDown();
            this.precio_compra = new System.Windows.Forms.NumericUpDown();
            this.precio_venta = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cant_inicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_compra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1119, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "guardar libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 404);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1293, 308);
            this.listBox1.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AccessibleName = "";
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(216, 47);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(38, 16);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad Inicial";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio de Compra ";
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio de Venta ";
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(341, 80);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 22);
            this.titulo.TabIndex = 7;
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(341, 47);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(100, 22);
            this.isbn.TabIndex = 10;
            this.isbn.TextChanged += new System.EventHandler(this.isbn_TextChanged);
            // 
            // cant_inicial
            // 
            this.cant_inicial.Location = new System.Drawing.Point(341, 108);
            this.cant_inicial.Name = "cant_inicial";
            this.cant_inicial.Size = new System.Drawing.Size(120, 22);
            this.cant_inicial.TabIndex = 11;
            this.cant_inicial.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // precio_compra
            // 
            this.precio_compra.Location = new System.Drawing.Point(341, 140);
            this.precio_compra.Name = "precio_compra";
            this.precio_compra.Size = new System.Drawing.Size(120, 22);
            this.precio_compra.TabIndex = 12;
            // 
            // precio_venta
            // 
            this.precio_venta.Location = new System.Drawing.Point(341, 171);
            this.precio_venta.Name = "precio_venta";
            this.precio_venta.Size = new System.Drawing.Size(120, 22);
            this.precio_venta.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 724);
            this.Controls.Add(this.precio_venta);
            this.Controls.Add(this.precio_compra);
            this.Controls.Add(this.cant_inicial);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cant_inicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_compra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precio_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titulo;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.NumericUpDown cant_inicial;
        private System.Windows.Forms.NumericUpDown precio_compra;
        private System.Windows.Forms.NumericUpDown precio_venta;
    }
}

