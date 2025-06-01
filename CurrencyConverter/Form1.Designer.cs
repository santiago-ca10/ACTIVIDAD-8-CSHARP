namespace CurrencyConverter
{
    partial class Form1
    {
        // Contenedor para los componentes del formulario.
        private System.ComponentModel.IContainer components = null;

        // Definimos los controles visuales que se usan en el formulario.
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelResult;

        // Método que libera los recursos usados por el formulario.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // Libera los recursos de los componentes.
            }
            base.Dispose(disposing);
        }

        // Método que inicializa y configura los componentes visuales.
        private void InitializeComponent()
        {
            // Caja de texto donde el usuario ingresa la cantidad a convertir.
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxAmount.Location = new System.Drawing.Point(30, 30);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 0;

            // ComboBox que permite seleccionar la moneda de destino.
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Location = new System.Drawing.Point(150, 30);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(100, 23);
            this.comboBoxCurrency.TabIndex = 1;

            // Botón para ejecutar la conversión.
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonConvert.Location = new System.Drawing.Point(30, 70);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(220, 30);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convertir";
            this.buttonConvert.UseVisualStyleBackColor = true;

            // Evento que se ejecuta al hacer clic en el botón.
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);

            // Etiqueta donde se muestra el resultado de la conversión.
            this.labelResult = new System.Windows.Forms.Label();
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(30, 120);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(60, 15);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Resultado:";

            // Configuración general del formulario (ventana).
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161); // Tamaño de la ventana.
            this.Controls.Add(this.labelResult);      // Agregamos la etiqueta al formulario.
            this.Controls.Add(this.buttonConvert);    // Agregamos el botón.
            this.Controls.Add(this.comboBoxCurrency); // Agregamos el ComboBox.
            this.Controls.Add(this.textBoxAmount);    // Agregamos la caja de texto.
            this.Name = "Form1";                      // Nombre interno del formulario.
            this.Text = "Conversor de Monedas";       // Título de la ventana.
            this.ResumeLayout(false);
            this.PerformLayout(); // Aplica el layout automático.
        }
    }
}
