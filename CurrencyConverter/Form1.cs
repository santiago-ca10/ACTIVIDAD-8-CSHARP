// Importamos los espacios de nombres necesarios.
using System;
using System.Windows.Forms;
using CurrencyConverter.Strategy; // Importamos las estrategias de conversión.

namespace CurrencyConverter
{
    // Form1 representa la interfaz gráfica del usuario (GUI).
    public partial class Form1 : Form
    {
        // Instancia del contexto que gestiona la estrategia de conversión actual.
        private ConverterContext _context;

        // Constructor del formulario.
        public Form1()
        {
            InitializeComponent();

            // Agregamos las opciones de moneda al ComboBox (desplegable).
            // Aquí cambiamos "GBP" por "COP".
            comboBoxCurrency.Items.AddRange(new string[] { "USD", "EUR", "COP" });

            // Establecemos la opción seleccionada por defecto.
            comboBoxCurrency.SelectedIndex = 0;

            // Inicializamos el contexto con la estrategia por defecto (sin conversión).
            _context = new ConverterContext(new IdentityConversion());
        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón "Convertir".
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // Intentamos convertir el texto ingresado a decimal.
            if (!decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                // Mostramos un mensaje de error si no es un número válido.
                MessageBox.Show("Ingrese un número válido.");
                return;
            }

            // Elegimos la estrategia según la opción seleccionada en el ComboBox.
            switch (comboBoxCurrency!.SelectedItem!.ToString())
            {
                case "EUR":
                    _context.SetStrategy(new UsdToEur());
                    break;
                case "COP":
                    _context.SetStrategy(new UsdToCop()); // Usamos pesos colombianos.
                    break;
                default:
                    _context.SetStrategy(new IdentityConversion());
                    break;
            }

            // Realizamos la conversión.
            decimal result = _context.Convert(amount);

            // Mostramos el resultado en el label.
            labelResult.Text = $"Resultado: {result:F2} {_context.TargetCurrency}";
        }
    }
}
