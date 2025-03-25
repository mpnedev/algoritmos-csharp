using System;

class Program
{
    static void Main()
    {
        // Exibe o menu para o usuário escolher a questão
        Console.WriteLine("Escolha a questão que deseja executar:");
        Console.WriteLine("1 - Perguntar um número e mostrar a mensagem");
        Console.WriteLine("2 - Pedir dois números e mostrar soma, subtração e multiplicação");
        Console.WriteLine("3 - Pedir 4 notas e mostrar a média");
        Console.WriteLine("4 - Pedir preço da gasolina e quantidade de litros vendidos");
        Console.WriteLine("5 - Pedir preço das viagens e número de pessoas para 3 destinos");
        Console.Write("Digite o número da questão (1-5): ");
        
        int escolha = int.Parse(Console.ReadLine());  // Lê a escolha do usuário
        
        switch (escolha)
        {
            case 1:
                // Questão 1: Pedir um número e mostrar a mensagem
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número informado foi " + numero);
                break;

            case 2:
                // Questão 2: Pedir dois números e mostrar soma, subtração e multiplicação
                Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Soma: " + (num1 + num2));
                Console.WriteLine("Subtração: " + (num1 - num2));
                Console.WriteLine("Multiplicação: " + (num1 * num2));
                break;

            case 3:
                // Questão 3: Pedir 4 notas e mostrar a média
                Console.Write("Digite a primeira nota: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Digite a segunda nota: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.Write("Digite a terceira nota: ");
                double nota3 = double.Parse(Console.ReadLine());
                Console.Write("Digite a quarta nota: ");
                double nota4 = double.Parse(Console.ReadLine());
                
                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                Console.WriteLine("A média é: " + media);
                break;

            case 4:
                // Questão 4: Pedir preço da gasolina e quantidade de litros vendidos
                Console.Write("Digite o preço do litro da gasolina: ");
                double precoGasolina = double.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade de litros vendidos: ");
                double litros = double.Parse(Console.ReadLine());
                
                double total = precoGasolina * litros;
                Console.WriteLine("O total a pagar é: " + total);
                break;

            case 5:
                // Questão 5: Pedir preço das viagens e número de pessoas para 3 destinos
                Console.Write("Digite o preço da viagem para Alemanha: ");
                double precoAlemanha = double.Parse(Console.ReadLine());
                Console.Write("Digite o número de pessoas para Alemanha: ");
                int pessoasAlemanha = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o preço da viagem para Portugal: ");
                double precoPortugal = double.Parse(Console.ReadLine());
                Console.Write("Digite o número de pessoas para Portugal: ");
                int pessoasPortugal = int.Parse(Console.ReadLine());
                
                Console.Write("Digite o preço da viagem para Itália: ");
                double precoItalia = double.Parse(Console.ReadLine());
                Console.Write("Digite o número de pessoas para Itália: ");
                int pessoasItalia = int.Parse(Console.ReadLine());
                
                double totalViagem = (precoAlemanha * pessoasAlemanha) + (precoPortugal * pessoasPortugal) + (precoItalia * pessoasItalia);
                Console.WriteLine("O valor total da viagem é: " + totalViagem);
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
