namespace Lab_7
{
    partial class Numero7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numero7));
            this.button1 = new System.Windows.Forms.Button();
            this.Numero8 = new System.Windows.Forms.Button();
            this.Numero9 = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.numero6 = new System.Windows.Forms.Button();
            this.numero5 = new System.Windows.Forms.Button();
            this.numero4 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.numero3 = new System.Windows.Forms.Button();
            this.numero2 = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.Button();
            this.ansant = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.numero0 = new System.Windows.Forms.Button();
            this.TEXTresultado = new System.Windows.Forms.TextBox();
            this.label_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(27, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.click_boton);
            // 
            // Numero8
            // 
            this.Numero8.BackColor = System.Drawing.Color.White;
            this.Numero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero8.ForeColor = System.Drawing.Color.Black;
            this.Numero8.Location = new System.Drawing.Point(95, 149);
            this.Numero8.Name = "Numero8";
            this.Numero8.Size = new System.Drawing.Size(62, 50);
            this.Numero8.TabIndex = 1;
            this.Numero8.Text = "8";
            this.Numero8.UseVisualStyleBackColor = false;
            this.Numero8.Click += new System.EventHandler(this.click_boton);
            // 
            // Numero9
            // 
            this.Numero9.BackColor = System.Drawing.Color.White;
            this.Numero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero9.ForeColor = System.Drawing.Color.Black;
            this.Numero9.Location = new System.Drawing.Point(163, 149);
            this.Numero9.Name = "Numero9";
            this.Numero9.Size = new System.Drawing.Size(62, 50);
            this.Numero9.TabIndex = 2;
            this.Numero9.Text = "9";
            this.Numero9.UseVisualStyleBackColor = false;
            this.Numero9.Click += new System.EventHandler(this.click_boton);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.White;
            this.borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.ForeColor = System.Drawing.Color.Black;
            this.borrar.Location = new System.Drawing.Point(231, 149);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(62, 50);
            this.borrar.TabIndex = 3;
            this.borrar.Text = "DEL";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.Delete_1number);
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.White;
            this.apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.Color.Black;
            this.apagar.Location = new System.Drawing.Point(299, 149);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(62, 50);
            this.apagar.TabIndex = 4;
            this.apagar.Text = "AC";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.Delete_All);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.White;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.ForeColor = System.Drawing.Color.Black;
            this.division.Location = new System.Drawing.Point(299, 205);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(62, 50);
            this.division.TabIndex = 9;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.operador_boton);
            // 
            // multiplicacion
            // 
            this.multiplicacion.BackColor = System.Drawing.Color.White;
            this.multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.ForeColor = System.Drawing.Color.Black;
            this.multiplicacion.Location = new System.Drawing.Point(231, 205);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(62, 50);
            this.multiplicacion.TabIndex = 8;
            this.multiplicacion.Text = "*";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.operador_boton);
            // 
            // numero6
            // 
            this.numero6.BackColor = System.Drawing.Color.White;
            this.numero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero6.ForeColor = System.Drawing.Color.Black;
            this.numero6.Location = new System.Drawing.Point(163, 205);
            this.numero6.Name = "numero6";
            this.numero6.Size = new System.Drawing.Size(62, 50);
            this.numero6.TabIndex = 7;
            this.numero6.Text = "6";
            this.numero6.UseVisualStyleBackColor = false;
            this.numero6.Click += new System.EventHandler(this.click_boton);
            // 
            // numero5
            // 
            this.numero5.BackColor = System.Drawing.Color.White;
            this.numero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero5.ForeColor = System.Drawing.Color.Black;
            this.numero5.Location = new System.Drawing.Point(95, 205);
            this.numero5.Name = "numero5";
            this.numero5.Size = new System.Drawing.Size(62, 50);
            this.numero5.TabIndex = 6;
            this.numero5.Text = "5";
            this.numero5.UseVisualStyleBackColor = false;
            this.numero5.Click += new System.EventHandler(this.click_boton);
            // 
            // numero4
            // 
            this.numero4.BackColor = System.Drawing.Color.White;
            this.numero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero4.ForeColor = System.Drawing.Color.Black;
            this.numero4.Location = new System.Drawing.Point(27, 205);
            this.numero4.Name = "numero4";
            this.numero4.Size = new System.Drawing.Size(62, 50);
            this.numero4.TabIndex = 5;
            this.numero4.Text = "4";
            this.numero4.UseVisualStyleBackColor = false;
            this.numero4.Click += new System.EventHandler(this.click_boton);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.White;
            this.resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.ForeColor = System.Drawing.Color.Black;
            this.resta.Location = new System.Drawing.Point(299, 261);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(62, 50);
            this.resta.TabIndex = 14;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.operador_boton);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.White;
            this.suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.ForeColor = System.Drawing.Color.Black;
            this.suma.Location = new System.Drawing.Point(231, 261);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(62, 50);
            this.suma.TabIndex = 13;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.operador_boton);
            // 
            // numero3
            // 
            this.numero3.BackColor = System.Drawing.Color.White;
            this.numero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero3.ForeColor = System.Drawing.Color.Black;
            this.numero3.Location = new System.Drawing.Point(163, 261);
            this.numero3.Name = "numero3";
            this.numero3.Size = new System.Drawing.Size(62, 50);
            this.numero3.TabIndex = 12;
            this.numero3.Text = "3";
            this.numero3.UseVisualStyleBackColor = false;
            this.numero3.Click += new System.EventHandler(this.click_boton);
            // 
            // numero2
            // 
            this.numero2.BackColor = System.Drawing.Color.White;
            this.numero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero2.ForeColor = System.Drawing.Color.Black;
            this.numero2.Location = new System.Drawing.Point(95, 261);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(62, 50);
            this.numero2.TabIndex = 11;
            this.numero2.Text = "2";
            this.numero2.UseVisualStyleBackColor = false;
            this.numero2.Click += new System.EventHandler(this.click_boton);
            // 
            // numero1
            // 
            this.numero1.BackColor = System.Drawing.Color.White;
            this.numero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero1.ForeColor = System.Drawing.Color.Black;
            this.numero1.Location = new System.Drawing.Point(27, 261);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(62, 50);
            this.numero1.TabIndex = 10;
            this.numero1.Text = "1";
            this.numero1.UseVisualStyleBackColor = false;
            this.numero1.Click += new System.EventHandler(this.click_boton);
            // 
            // respuesta
            // 
            this.respuesta.BackColor = System.Drawing.Color.White;
            this.respuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.Color.Black;
            this.respuesta.Location = new System.Drawing.Point(299, 317);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(62, 50);
            this.respuesta.TabIndex = 19;
            this.respuesta.Text = "=";
            this.respuesta.UseVisualStyleBackColor = false;
            this.respuesta.Click += new System.EventHandler(this.Equal_boton);
            // 
            // ansant
            // 
            this.ansant.BackColor = System.Drawing.Color.White;
            this.ansant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansant.ForeColor = System.Drawing.Color.Black;
            this.ansant.Location = new System.Drawing.Point(231, 317);
            this.ansant.Name = "ansant";
            this.ansant.Size = new System.Drawing.Size(62, 50);
            this.ansant.TabIndex = 18;
            this.ansant.Text = "Ans";
            this.ansant.UseVisualStyleBackColor = false;
            this.ansant.Click += new System.EventHandler(this.Answerd_boton);
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.Color.White;
            this.punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.ForeColor = System.Drawing.Color.Black;
            this.punto.Location = new System.Drawing.Point(163, 317);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(62, 50);
            this.punto.TabIndex = 16;
            this.punto.Text = ",";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.click_boton);
            // 
            // numero0
            // 
            this.numero0.BackColor = System.Drawing.Color.White;
            this.numero0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero0.ForeColor = System.Drawing.Color.Black;
            this.numero0.Location = new System.Drawing.Point(27, 317);
            this.numero0.Name = "numero0";
            this.numero0.Size = new System.Drawing.Size(130, 50);
            this.numero0.TabIndex = 15;
            this.numero0.Text = "0";
            this.numero0.UseVisualStyleBackColor = false;
            this.numero0.Click += new System.EventHandler(this.click_boton);
            // 
            // TEXTresultado
            // 
            this.TEXTresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTresultado.Location = new System.Drawing.Point(27, 84);
            this.TEXTresultado.Name = "TEXTresultado";
            this.TEXTresultado.Size = new System.Drawing.Size(334, 47);
            this.TEXTresultado.TabIndex = 20;
            this.TEXTresultado.Text = "0";
            this.TEXTresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_text.Location = new System.Drawing.Point(30, 43);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(0, 39);
            this.label_text.TabIndex = 21;
            // 
            // Numero7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(384, 387);
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.TEXTresultado);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.ansant);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.numero0);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.numero3);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.numero6);
            this.Controls.Add(this.numero5);
            this.Controls.Add(this.numero4);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.Numero9);
            this.Controls.Add(this.Numero8);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Numero7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Numero8;
        private System.Windows.Forms.Button Numero9;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.Button numero6;
        private System.Windows.Forms.Button numero5;
        private System.Windows.Forms.Button numero4;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button numero3;
        private System.Windows.Forms.Button numero2;
        private System.Windows.Forms.Button numero1;
        private System.Windows.Forms.Button respuesta;
        private System.Windows.Forms.Button ansant;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button numero0;
        private System.Windows.Forms.TextBox TEXTresultado;
        private System.Windows.Forms.Label label_text;
    }
}

