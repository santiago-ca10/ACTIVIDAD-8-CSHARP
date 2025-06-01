// Namespace donde se agrupan todas las estrategias de conversión de divisas.
namespace CurrencyConverter.Strategy
{
    // Clase que implementa la estrategia de conversión de dólares estadounidenses (USD) a pesos colombianos (COP).
    public class UsdToCop : IConversionStrategy
    {
        // Método que convierte el monto recibido en USD a COP.
        // Tasa de conversión aproximada: 1 USD = 3900 COP (puedes actualizarla según el valor actual).
        public decimal Convert(decimal amount) => amount * 3900m;

        // Propiedad que indica la moneda de destino: "COP" (pesos colombianos).
        public string TargetCurrency => "COP";
    }
}
