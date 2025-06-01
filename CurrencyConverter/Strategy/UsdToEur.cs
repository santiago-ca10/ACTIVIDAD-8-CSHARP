// Declaramos el namespace que agrupa todas las estrategias de conversión.
// Esto ayuda a mantener el proyecto organizado.
namespace CurrencyConverter.Strategy
{
    // La clase UsdToEur implementa la interfaz IConversionStrategy.
    // Representa una estrategia específica para convertir de dólares estadounidenses (USD) a euros (EUR).
    public class UsdToEur : IConversionStrategy
    {
        // Implementación del método Convert definido en la interfaz.
        // Recibe un monto en USD y lo multiplica por la tasa de conversión a EUR (0.92).
        // Se usa el sufijo 'm' para indicar que es un número decimal (decimal literal).
        public decimal Convert(decimal amount) => amount * 0.92m;

        // Implementación de la propiedad TargetCurrency definida en la interfaz.
        // Retorna el código de la moneda objetivo: "EUR".
        public string TargetCurrency => "EUR";
    }
}

