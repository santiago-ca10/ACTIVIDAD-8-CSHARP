using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    // Clase principal de la aplicación.
    static class Program
    {
        // Punto de entrada principal de la aplicación.
        [STAThread] // Indica que se usa el modelo de subprocesamiento de un solo hilo para Windows Forms (requerido).
        static void Main()
        {
            // Habilita la compatibilidad con pantallas de alta resolución (DPI).
            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            // Habilita los estilos visuales modernos del sistema operativo para los controles de la UI.
            Application.EnableVisualStyles();

            // Usa el motor de renderizado de texto compatible con versiones anteriores (por rendimiento y compatibilidad).
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicia el formulario principal de la aplicación.
            Application.Run(new Form1());
        }
    }
}

