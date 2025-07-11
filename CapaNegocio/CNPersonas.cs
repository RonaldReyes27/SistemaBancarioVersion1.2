using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using CapaDatos;
using CapaNegocio;

namespace CapaNegocios
{
    public class CNPersonas
    {
        // // Se crea una instancia de la clase de la Capa de Datos.
        private readonly string cadenaConexion = ConexionBD.conexion;

        // Registra un nuevo cliente en la base de datos
        /// Aplica reglas de negocio y luego llama a la Capa de Datos para registrar.
        public void RegistrarCliente(string nombre, string numCuenta, string tipoCuenta, decimal saldoInicial)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new Exception("El nombre del cliente no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(numCuenta))
                throw new Exception("El número de cuenta no puede estar vacío.");

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "INSERT INTO CuentaCliente (NumCuenta, Nombre, TipoCuenta, SaldoCuenta) VALUES (@NumCuenta, @Nombre, @TipoCuenta, @Saldo)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NumCuenta", numCuenta);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@TipoCuenta", tipoCuenta);
                cmd.Parameters.AddWithValue("@Saldo", saldoInicial);
                cmd.ExecuteNonQuery();
            }
        }

        // Método normal: Actualiza el saldo de una cuenta.
        public void ActualizarSaldo(int idCuenta, decimal nuevoSaldo)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                conn.Open();
                string query = "UPDATE CuentaCliente SET SaldoCuenta = @Saldo WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Saldo", nuevoSaldo);
                cmd.Parameters.AddWithValue("@Id", idCuenta);
                cmd.ExecuteNonQuery();
            }
        }
        //  Método normal: obtiene una cuenta de BD y devuelve una instancia de clase hija.
        // Obtiene una cuenta por su ID
        public Cuenta ObtenerCuentaPorId(int idCuenta)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM CuentaCliente WHERE Id = @Id";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", idCuenta);
                adapter.Fill(tabla);
            }

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                string tipoCuenta = fila["TipoCuenta"].ToString();
                Cuenta cuenta = tipoCuenta == "Ahorros"
                    ? new CuentaAhorro(fila["NumCuenta"].ToString(), fila["Nombre"].ToString())
                    : new CuentaCorriente(fila["NumCuenta"].ToString(), fila["Nombre"].ToString());

                cuenta.Id = Convert.ToInt32(fila["Id"]);
                cuenta.AsignarSaldoInicial(Convert.ToDecimal(fila["SaldoCuenta"]));
                return cuenta;
            }

            return null;
        }

        // Devuelve una lista con todas las cuentas de la base de datos
        public List<Cuenta> ObtenerListaDeCuentas()
        {
            List<Cuenta> lista = new List<Cuenta>();
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT * FROM CuentaCliente";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(tabla);
            }

            foreach (DataRow fila in tabla.Rows)
            {
                string tipoCuenta = fila["TipoCuenta"].ToString();
                Cuenta cuenta = tipoCuenta == "Ahorros"
                    ? new CuentaAhorro(fila["NumCuenta"].ToString(), fila["Nombre"].ToString())
                    : new CuentaCorriente(fila["NumCuenta"].ToString(), fila["Nombre"].ToString());

                cuenta.Id = Convert.ToInt32(fila["Id"]);
                cuenta.AsignarSaldoInicial(Convert.ToDecimal(fila["SaldoCuenta"]));
                lista.Add(cuenta);
            }

            return lista;
        }
    }
}
