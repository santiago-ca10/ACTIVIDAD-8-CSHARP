# CurrencyConverter 💱

Este es un pequeño conversor de monedas desarrollado en C# con Windows Forms.
Aplica el Patrón de Diseño Estrategia (Strategy Pattern) para seleccionar dinámicamente la conversión entre divisas.

## 🧠 Funcionalidad

Convierte dólares (USD) a:
- Euros (EUR)
- Pesos Colombianos (COP)

## 🛠️ Estructura del proyecto

- `Form1.cs` - Interfaz gráfica y lógica de interacción.
- `Strategy/` - Contiene las estrategias de conversión (`UsdToEur`, `UsdToGbp`, etc.).
- `ConverterContext.cs` - Aplica la estrategia de conversión seleccionada.

## 📐 Patrón de diseño aplicado

Se usa Strategy Pattern para separar la lógica de conversión en clases distintas, permitiendo añadir nuevas monedas sin modificar el código existente.

## ✅ Requisitos

- .NET Core o .NET Framework
- Visual Studio o VS Code con extensiones de C#
