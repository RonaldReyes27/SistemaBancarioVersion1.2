using System;

namespace CapaNegocio
{

    // --- REQUISITO CUMPLIDO: Uso de clases abstractas ---
    // Clase abstracta base para representar una cuenta bancaria
    public abstract class Cuenta
    {
        public int Id { get; set; }
        public string NumCuenta { get; set; }
        public string Nombre { get; set; }
        public string TipoCuenta { get; set; }
        public decimal SaldoCuenta { get; protected set; }


        //--- REQUISITO CUMPLIDO: Uso de constructores ---
        // Constructor base con parámetros obligatorios
        public Cuenta(string numCuenta, string nombre)
        {
            NumCuenta = numCuenta;
            Nombre = nombre;
            SaldoCuenta = 0;
        }

        //--- REQUISITO CUMPLIDO: Uso de metodos abstractos ---
        // Método abstracto que se implementará en clases hijas
        public abstract string ObtenerResumenCuenta();


        // --- REQUISITO CUMPLIDO: Uso de metodos virtuales --
        // Método virtual para depositar dinero en la cuenta
        public virtual string Depositar(decimal monto)
        {
            if (monto <= 0) return "El monto a depositar debe ser positivo.";
            SaldoCuenta += monto;
            return $"Depósito exitoso. Nuevo Saldo: {SaldoCuenta:C}";
        }

        // Método virtual para retirar dinero de la cuenta
        public virtual string Retirar(decimal monto)
        {
            if (monto <= 0) return "El monto a retirar debe ser positivo.";
            SaldoCuenta -= monto;
            return $"Retiro exitoso. Nuevo saldo: {SaldoCuenta:C}";
        }

        // --- REQUISITO CUMPLIDO: Uso de metodos normales ---
        // Permite establecer el saldo inicial al cargar desde base de datos
        public void AsignarSaldoInicial(decimal saldo)
        {
            if (saldo >= 0) SaldoCuenta = saldo;
        }

        // Método auxiliar para mostrar saldo sin modificarlo
        public string ConsultarSaldo()
        {
            return $"Saldo actual: {SaldoCuenta:C}";
        }
    }
}
