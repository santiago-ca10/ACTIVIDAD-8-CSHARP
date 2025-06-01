// Namespace que contiene todas las estrategias de conversión.
namespace CurrencyConverter.Strategy
{
    // Estrategia que no modifica el valor del monto.
    // Útil cuando la moneda de destino es la misma que la moneda original (USD a USD).
    public class IdentityConversion : IConversionStrategy
    {
        // Implementación del método Convert.
        // Retorna exactamente el mismo valor que se recibe como parámetro.
        public decimal Convert(decimal amount) => amount;

        // Indica que la moneda de destino es "USD".
        public string TargetCurrency => "USD";
    }
}
