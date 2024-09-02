namespace Dominio
{
    public class Cuentas
    {
        string titular;
        decimal saldoActual;
        int numeroDeCuenta;
        Enums.Moneda moneda;
        Enums.TipoDeCuenta tipoDeCuenta;

        public Cuentas()
        {

        }

       

        public string Titular { get => titular;}
        public decimal SaldoActual { get => saldoActual; set => saldoActual = value; }
        public int NumeroDeCuenta { get => numeroDeCuenta;}
        public Enums.Moneda Moneda { get => moneda; }
        public Enums.TipoDeCuenta TipoDeCuenta { get => tipoDeCuenta;}


        public Cuentas(string titular, decimal saldoActual, int numeroDeCuenta, Enums.Moneda moneda, Enums.TipoDeCuenta tipoDeCuenta)
        {
            this.titular = titular;
            this.saldoActual = saldoActual;
            this.numeroDeCuenta = numeroDeCuenta;
            this.moneda = moneda;
            this.tipoDeCuenta = tipoDeCuenta;
        }

        public bool Deposito(decimal montoADepositar, Enums.Moneda monedaDeposito)
        {
            bool seCompletoLaOperacion = false;

            if(monedaDeposito == this.moneda)
            {
                if(monedaDeposito == Enums.Moneda.Peso)
                {
                    if(montoADepositar < 50000)
                    {
                        saldoActual += montoADepositar;
                        seCompletoLaOperacion = true;
                    }
                    else
                    {
                        throw new Exception("El monto a depositar no puede superar los 50000 pesos");
                    }

                }else if(monedaDeposito == Enums.Moneda.Dolar)
                {
                    if (montoADepositar < 1000)
                    {
                        saldoActual += montoADepositar;
                        seCompletoLaOperacion = true;

                    }
                    else
                    {
                        throw new Exception("El monto a depositar no puede superar los 1000 dolares");
                    }
                }
                
            }
            else
            {
                throw new Exception("La moneda del deposito no coincide con la moneda de la cuenta");
            }


            return seCompletoLaOperacion;
        }

        int contadorRetiros = 0;
        public bool Retiro(decimal montoARetirar, Enums.Moneda monedaRetiro)
        {
            bool seCompletoLaOperacion = false;

            if(monedaRetiro == this.moneda)
            {
                if (contadorRetiros < 6)
                {
                    if (montoARetirar <= saldoActual)
                    {
                        saldoActual -= montoARetirar;
                        seCompletoLaOperacion = true;
                        contadorRetiros++;
                    }
                    else
                    {
                        throw new Exception("Usted no tiene suficiente dinero en la cuenta");
                    }
                }
                else
                {
                    if(monedaRetiro == Enums.Moneda.Peso)
                    {
                        if (montoARetirar + 50 <= saldoActual)
                        {
                            saldoActual -= (montoARetirar + 50);
                            seCompletoLaOperacion = true;
                            contadorRetiros++;
                        }
                        else
                        {
                            throw new Exception("Usted no tiene suficiente dinero en la cuenta");
                        }
                    }
                    else if(monedaRetiro == Enums.Moneda.Dolar)
                    {
                        if (montoARetirar + 1 <= saldoActual)
                        {
                            saldoActual -= (montoARetirar + 1);
                            seCompletoLaOperacion = true;
                            contadorRetiros++;
                        }
                        else
                        {
                            throw new Exception("Usted no tiene suficiente dinero en la cuenta");
                        }
                    }
                }

            }
            else
            {
                throw new Exception("La moneda del retiro no coincide con la moneda de la cuenta");

            }

            return seCompletoLaOperacion;
        }

        public override string ToString()
        {
            return $"El titular de la cuenta es {titular} \n Su saldo actual es: {SaldoActual}\n" +
                $"Su numero de cuenta es {numeroDeCuenta} \n La moneda de la cuenta es : {moneda}\n" +
                $"El tipo de cuenta es : {tipoDeCuenta}";   
            
            
        }

    }
}
