using CapaNegocio;

namespace CapaNegocios
{
    // --- REQUISITO CUMPLIDO: Creación y uso de herencia ---
    // La clase 'CuentaCorriente' también hereda de 'Cuenta'.
    public class CuentaCorriente : Cuenta
    {

        // --- REQUISITO CUMPLIDO: Uso de constructores ---
        // Constructor que llama al base y define tipo de cuentas
        public CuentaCorriente(string numCuenta, string nombre) : base(numCuenta, nombre)
        {
            TipoCuenta = "Corriente";
        }

        // Sobrescribe el método Retirar para añadir una validación específica para cuentas Corriente.
        public override string Retirar(decimal monto)
        {
            if (monto <= 0) return "El monto a retirar debe ser positivo.";
            if (SaldoCuenta < monto)
                return "Fondos insuficientes en su cuenta corriente.";

            return base.Retirar(monto);
        }
        // Implementación  del método abstracto de la clase base.
        
        public override string ObtenerResumenCuenta()
        {
            return $"Cuenta Corriente Nro: {NumCuenta} a nombre de {Nombre}.";
        }
    }
}
