using CapaNegocio;

namespace CapaNegocios
{
    // Clase derivada para cuentas de ahorro
    public class CuentaAhorro : Cuenta
    {
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

        // Implementación del resumen
        public override string ObtenerResumenCuenta()
        {
            return $"Cuenta de Ahorros Nro: {NumCuenta} a nombre de {Nombre}.";
        }
    }
}
