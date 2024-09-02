namespace Practico2_Ejercicio4
{
    using Dominio;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Probemos");
            Cuentas unaCuenta = new Cuentas("Cesar Martinez", 1500, 1234, Enums.Moneda.Dolar, Enums.TipoDeCuenta.CajaDeAhorros);
            Console.WriteLine($"{unaCuenta}");
            try
            {
                Console.WriteLine($"{(unaCuenta.Deposito(2000, Enums.Moneda.Peso) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Deposito(500, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            try
            {
                Console.WriteLine($"{(unaCuenta.Retiro(100, Enums.Moneda.Dolar) ? "La operacion se realizo con exito" : "")}");
                Console.WriteLine($"{unaCuenta}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
