using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraOrientadaObjeto
{
    public class CalculadoraOO
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = "";
                Operacoes operacoes = new Operacoes();
                operacoes.MostrarMenu();
                opcao = Console.ReadLine();
                operacoes.ObterNumeros();
               
                //double resultado = 0;

                switch (opcao)
                {
                    case "1": operacoes.soma(); break;
                    case "2": operacoes.subtracao(); break;
                    case "3": operacoes.multiplicacao(); break;
                    case "4": operacoes.divisao(); break;
                   
                    default:
                        Environment.Exit(1);
                        break;
                }


            }
        }
    }

    public class Operacoes : MENU
    {
        public double primeiroNumero, segundoNumero;
        public string[] operacoesRealizadas = new string[100];
        int contadorOperacoesRealizadas = 0;
        public void ObterNumeros()
        {
            Console.WriteLine("Digite o Primeiro Valor: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
            
            contadorOperacoesRealizadas++;

        }
        public void soma()
        {
            string simboloOperacao = "+";
            double resultado = primeiroNumero + segundoNumero;
            string conta = $"{primeiroNumero} {simboloOperacao } {segundoNumero} = {resultado}";
            Console.WriteLine(conta);
            Console.WriteLine();
        }
         
        public void subtracao()
        {
            string simboloOperacao = "-";
            double resultado = primeiroNumero - segundoNumero;
            string conta = $"{primeiroNumero} {simboloOperacao } {segundoNumero} = {resultado}";
            Console.WriteLine(conta);
            Console.WriteLine();
        }

        public void multiplicacao()
        {
            string simboloOperacao = "*";
            double resultado = primeiroNumero * segundoNumero;
            string conta = $"{primeiroNumero} {simboloOperacao } {segundoNumero} = {resultado}";
            Console.WriteLine(conta);
            Console.WriteLine();
        }

        public void divisao()
        {
            if (segundoNumero == 0)
            {
                Console.WriteLine("Segundo número inválido! Tente novamente");

            }
            else if(segundoNumero!= 0)
                    { string simboloOperacao = "/";
                double resultado = primeiroNumero / segundoNumero;
                string conta = $"{primeiroNumero} {simboloOperacao } {segundoNumero} = {resultado}";
                Console.WriteLine(conta);
                Console.WriteLine();
            }
        }

       
       
       
    }
}
 