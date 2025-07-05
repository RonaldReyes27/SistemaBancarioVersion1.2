using CapaNegocio;

namespace CapaNegocios
{
    // Clase derivada para cuentas corrientes
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(string numCuenta, string nombre) : base(numCuenta, nombre)
        {
            TipoCuenta = "Corriente";
        }

        // Reescribe el método Retirar con lógica personalizada
        public override string Retirar(decimal monto)
        {
            if (monto <= 0) return "El monto a retirar debe ser positivo.";
            if (SaldoCuenta < monto)
                return "Fondos insuficientes en su cuenta corriente.";

            return base.Retirar(monto);
        }

        // Implementación del resumen
        public override string ObtenerResumenCuenta()
        {
            return $"Cuenta Corriente Nro: {NumCuenta} a nombre de {Nombre}.";
        }
    }
}
