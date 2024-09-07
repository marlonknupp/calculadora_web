namespace CalculadoraWeb.Models
{
    public class Calculadora
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operacao { get; set; }
        public double Resultado { get; set; }

        public double Calcular()
        {
            switch (Operacao)
            {
                case "Adicao":
                    Resultado = Num1 + Num2;
                    break;
                case "Subtracao":
                    Resultado = Num1 - Num2;
                    break;
                case "Multiplicacao":
                    Resultado = Num1 * Num2;
                    break;
                case "Divisao":
                    Resultado = Num1 / Num2;
                    break;
                default:
                    Resultado = 0;
                    break;
            }
            return Resultado;
        }
    }
}