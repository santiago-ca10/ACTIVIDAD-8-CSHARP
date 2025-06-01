// Declar el namespace para organizar el código y evitar conflictos de nombres.
// Este namespace agrupa todas las estrategias de conversión de moneda.
namespace CurrencyConverter.Strategy
{
    // Esta interfaz define el contrato que deben seguir todas las estrategias de conversión de divisas.
    public interface IConversionStrategy
    {
        // Método que se debe implementar para convertir un monto dado (amount) a otra moneda.
        // Parám.: amount → cantidad en la moneda base (por ejemplo, USD).
        // Retorna: el monto convertido a la moneda de destino.
        decimal Convert(decimal amount);

        // Propiedad que representa el nombre o código de la moneda objetivo (por ejemplo, "EUR" o "GBP").
        // Esto permite identificar fácilmente a qué moneda se convierte.
        string TargetCurrency { get; }
    }
}
