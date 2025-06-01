// Importamos el namespace donde está definida la interfaz IConversionStrategy
// y sus distintas implementaciones (UsdToEur, UsdToCop, IdentityConversion, etc.).
using CurrencyConverter.Strategy;

namespace CurrencyConverter
{
    // Esta clase representa el "contexto" del patrón Strategy.
    // Se encarga de almacenar y usar la estrategia de conversión seleccionada.
    public class ConverterContext
    {
        // Campo privado que almacena la estrategia de conversión activa.
        private IConversionStrategy _strategy;

        // Constructor que recibe una estrategia al crear el contexto.
        // Esto permite inicializar el contexto con una estrategia específica.
        public ConverterContext(IConversionStrategy strategy)
        {
            _strategy = strategy;
        }

        // Método para cambiar la estrategia en tiempo de ejecución.
        // Esto permite que el usuario seleccione una nueva moneda sin reiniciar la aplicación.
        public void SetStrategy(IConversionStrategy strategy)
        {
            _strategy = strategy;
        }

        // Método que realiza la conversión del monto utilizando la estrategia actual.
        public decimal Convert(decimal amount)
        {
            return _strategy.Convert(amount);
        }

        // Propiedad que expone la moneda de destino de la estrategia actual.
        // Útil para mostrar al usuario en qué moneda se ha convertido el monto.
        public string TargetCurrency => _strategy.TargetCurrency;
    }
}

