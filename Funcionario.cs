public class Funcionario
{
    private string _nome;
    private string _cargo;
    private decimal _salario;

    public Funcionario(string nome, string cargo, decimal salario)
    {
        _nome = nome;
        _cargo = cargo;
        _salario = salario;
    }

    public string Nome
    {
        get { return _nome; }
        private set { _nome = value; }
    }

    public string Cargo
    {
        get { return _cargo; }
        private set { _cargo = value; }
    }

    
    public decimal Salario
    {
        get { return _salario; }
        private set
        {
            if (value > 0)
            {
                _salario = value;
            }
        }
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }

    public void SetCargo(string cargo)
    {
        Cargo = cargo;
    }

    public void SetSalario(decimal salario)
    {
        Salario = salario;
    }


    public void AumentarSalario(decimal porcentagem)
    {
        if (porcentagem > 0)
        {
            _salario += _salario * porcentagem / 100;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");
        Console.WriteLine($"Salário: {_salario:C}");
    }
}
