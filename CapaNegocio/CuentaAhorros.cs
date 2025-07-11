using CapaNegocio;

namespace CapaNegocios
{
    // --- REQUISITO CUMPLIDO: Creación y uso de herencia ---
    // La clase 'CuentaAhorro' hereda de 'Cuenta', lo que significa que
    // automáticamente tiene todas las propiedades y métodos de una Cuenta.
    public class CuentaAhorro : Cuenta
    {
        // --- REQUISITO CUMPLIDO: Uso de constructores ---
        public CuentaAhorro(string numCuenta, string nombre) : base(numCuenta, nombre)
        {
            TipoCuenta = "Ahorros";
        }

        // Reescribe el método Retirar para aplicar validaciones específicas
        public override string Retirar(decimal monto)
        {
            if (monto <= 0) return "El monto a retirar debe ser positivo.";
            if (SaldoCuenta < monto)
                return "Fondos insuficientes en su cuenta de ahorro.";

            return base.Retirar(monto);
        }

        // Implementación del método abstracto de la clase base.
        public override string ObtenerResumenCuenta()
        {
            return $"Cuenta de Ahorros Nro: {NumCuenta} a nombre de {Nombre}.";
        }
    }
}
