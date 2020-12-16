using System;

namespace AppCalculadora
{
    class Calculadora
    {
        private double Numero1 { get; set; }
        private double Numero2 { get; set; }
        public double Resultado { get; set; }
        public char Operacao { get; set; }

        public Calculadora() {}

        public Calculadora(double numero1, double numero2)
        {
            this.Numero1 = numero1;
            this.Numero2 = numero2;
        }

        public void LerDados()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("                  Calculadora               ");
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
            Console.Write("Entre com os valores a serem calculados: \n>>>  N1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write(">>>  N2: ");
            double n2 = double.Parse(Console.ReadLine());
            Numero1 = n1;
            Numero2 = n2;
            Console.WriteLine();
            DefinirOperacao();

        }
        public void DefinirOperacao()
        {
            try
            {
                Console.Write("Escolha a operação que deseja usar no cálculo: \n>>>  Operação: ");
                char op = char.Parse(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Soma();                  
                        break;
                    case '-':
                        Subtrai();
                        break;
                    case '*':
                        Multiplica();
                        break;
                    case '/':
                        if(Numero2 != 0) { Divide(); }
                        else { 
                            Console.WriteLine("Valor para divisão deve ser diferente de zero");
                            LerDados();
                        }
                        break;

                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Operador inválido, escolha novamente " + e.Message);
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(ToString());
            Console.WriteLine("--------------------------------------------");
            Console.ResetColor();
        }



        public void Soma()
        {
            Resultado = Numero1 + Numero2;       
        }

        public void Subtrai()
        {
            Resultado = Numero1 - Numero2;
        }

        public void Multiplica()
        {
            Resultado = Numero1 * Numero2;
        }

        public void Divide()
        {
            Resultado =  Numero1 / Numero2;
        }

        public override string ToString() {
            return "Resultado: "+Resultado;
        }   
    }

}
