using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Digite o nome do funcionario: ");
        string nomeFuncionario = Console.ReadLine();
        Console.Write("Digite o cargo do funcionario: ");
        string cargoFuncionario = Console.ReadLine();
        Console.Write("Digite o salário do funcionario: ");
        decimal salarioFuncionario = decimal.Parse(Console.ReadLine());
        Funcionario funcionario = new Funcionario(nomeFuncionario, cargoFuncionario, salarioFuncionario);

        Console.Write("Deseja alterar algum dado do funcionario: ");
        char dec = char.Parse(Console.ReadLine());
        if (dec == 'S' || dec == 's')
        {
            Console.Write("Digite o novo nome do funcionario: ");
            string nomeAlterado = Console.ReadLine();
            funcionario.SetNome(nomeAlterado);
            Console.Write("Digite o novo cargo do funcionario: ");
            string cargoAlterado= Console.ReadLine();
            funcionario.SetCargo(cargoAlterado);
            Console.Write("Digite em quantos porcento deseja aumentar o salário do funcionario: ");
            decimal salarioAlterado = decimal.Parse(Console.ReadLine());
            funcionario.AumentarSalario(salarioAlterado);
            funcionario.ExibirDetalhes();
        }
        else if (dec == 'N' || dec == 'n')
        {
            Console.WriteLine("Exibindo os detalhges do funcionario");
            funcionario.ExibirDetalhes();
        }
    }
}