using System;

class Program
{
    static void Main()
    {
        // Exibe o menu para o usuário escolher a questão
        Console.WriteLine("Escolha a questão que deseja executar:");
        Console.WriteLine("1 - Média aritmética de dois números");
        Console.WriteLine("2 - Acrescentar 10% ao preço de um produto");
        Console.WriteLine("3 - Converter temperatura de Fahrenheit para Celsius");
        Console.WriteLine("4 - Calcular juros compostos");
        Console.WriteLine("5 - Calcular salário bruto");
        Console.WriteLine("6 - Calcular logaritmo de um número");
        Console.WriteLine("7 - Calcular salário total de um vendedor");
        Console.WriteLine("8 - Determinar quantos carros e motos no estacionamento");
        Console.WriteLine("9 - Converter segundos para horas, minutos e segundos");
        Console.WriteLine("10 - Calcular médias aritmética, harmônica e geométrica");
        Console.Write("Digite o número da questão (1-10): ");
        
        int escolha = int.Parse(Console.ReadLine());  // Lê a escolha do usuário
        
        switch (escolha)
        {
            case 1:
                // Questão 1: Média aritmética de dois números
                Console.Write("Digite o primeiro número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número: ");
                double num2 = double.Parse(Console.ReadLine());
                
                double media = (num1 + num2) / 2;
                Console.WriteLine("A média aritmética é: " + media);
                break;

            case 2:
                // Questão 2: Acrescentar 10% ao preço de um produto
                Console.Write("Informe o valor do produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                
                double novoPreco = precoProduto * 1.10;  // Acrescenta 10% ao preço
                Console.WriteLine("Novo valor do produto: " + novoPreco);
                break;

            case 3:
                // Questão 3: Converter temperatura de Fahrenheit para Celsius
                Console.Write("Informe a temperatura em Fahrenheit: ");
                double tempFahrenheit = double.Parse(Console.ReadLine());
                
                double tempCelsius = (tempFahrenheit - 32) / 1.8;  // Conversão de Fahrenheit para Celsius
                Console.WriteLine("Temperatura em Celsius: " + tempCelsius);
                break;

            case 4:
                // Questão 4: Calcular juros compostos
                Console.Write("Digite o valor do capital (C): ");
                double capital = double.Parse(Console.ReadLine());
                Console.Write("Digite a taxa de juros mensal (i) em decimal: ");
                double taxaJuros = double.Parse(Console.ReadLine());
                Console.Write("Digite o prazo da aplicação em meses (n): ");
                int prazoMeses = int.Parse(Console.ReadLine());
                
                double montante = capital * Math.Pow(1 + taxaJuros, prazoMeses);  // Fórmula de juros compostos
                Console.WriteLine("O montante a ser recebido é: " + montante);
                break;

            case 5:
                // Questão 5: Calcular salário bruto
                Console.Write("Digite o número de horas trabalhadas no mês: ");
                double horasTrabalhadas = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor recebido por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor do salário família: ");
                double salarioFamilia = double.Parse(Console.ReadLine());
                Console.Write("Digite o número de filhos com menos de 14 anos: ");
                int filhos = int.Parse(Console.ReadLine());
                
                double salarioBruto = (horasTrabalhadas * valorHora) + (salarioFamilia * filhos);  // Salário bruto
                Console.WriteLine("O salário bruto é: " + salarioBruto);
                break;

            case 6:
                // Questão 6: Calcular logaritmo de um número na base de outro número
                Console.Write("Digite o primeiro número (valor a ser logaritmado): ");
                double numero = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo número (base): ");
                double baseLogaritmo = double.Parse(Console.ReadLine());
                
                double logaritmo = Math.Log(numero, baseLogaritmo);  // Calcula o logaritmo
                Console.WriteLine("O logaritmo de " + numero + " na base " + baseLogaritmo + " é: " + logaritmo);
                break;

            case 7:
                // Questão 7: Calcular salário total de um vendedor
                Console.Write("Digite o salário fixo do vendedor: ");
                double salarioFixo = double.Parse(Console.ReadLine());
                Console.Write("Digite o valor total das vendas realizadas no mês: ");
                double vendas = double.Parse(Console.ReadLine());
                Console.Write("Digite o percentual de comissão sobre as vendas (em decimal): ");
                double percentualComissao = double.Parse(Console.ReadLine());
                
                double salarioTotal = salarioFixo + (vendas * percentualComissao);  // Calcula o salário total
                Console.WriteLine("O salário total do vendedor é: " + salarioTotal);
                break;

            case 8:
                // Questão 8: Determinar quantos carros e motos no estacionamento
                Console.Write("Digite o total de veículos no estacionamento: ");
                int totalVeiculos = int.Parse(Console.ReadLine());
                Console.Write("Digite o total de rodas no estacionamento: ");
                int totalRodas = int.Parse(Console.ReadLine());
                
                // Supondo que cada carro tenha 4 rodas e cada moto tenha 2 rodas
                int carros = (totalRodas - (totalVeiculos * 2)) / 2;
                int motos = totalVeiculos - carros;
                
                Console.WriteLine("Total de carros: " + carros);
                Console.WriteLine("Total de motos: " + motos);
                break;

            case 9:
                // Questão 9: Converter segundos para horas, minutos e segundos
                Console.Write("Digite o número de segundos: ");
                int segundos = int.Parse(Console.ReadLine());
                
                int horas = segundos / 3600;  // Calcula as horas
                segundos %= 3600;
                int minutos = segundos / 60;  // Calcula os minutos
                segundos %= 60;
                
                Console.WriteLine($"{horas} horas, {minutos} minutos e {segundos} segundos.");
                break;

            case 10:
                // Questão 10: Calcular médias aritmética, harmônica e geométrica
                Console.Write("Digite o primeiro valor: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                double c = double.Parse(Console.ReadLine());
                
                // Média aritmética
                double mediaAritmetica = (a + b + c) / 3;
                
                // Média harmônica
                double mediaHarmonica = 3 / (1/a + 1/b + 1/c);
                
                // Média geométrica
                double mediaGeometrica = Math.Pow(a * b * c, 1.0 / 3);
                
                Console.WriteLine("Média aritmética: " + mediaAritmetica);
                Console.WriteLine("Média harmônica: " + mediaHarmonica);
                Console.WriteLine("Média geométrica: " + mediaGeometrica);
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
