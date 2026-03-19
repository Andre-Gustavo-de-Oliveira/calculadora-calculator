using System.Net;

string[] historicoOperacoes = new string[100];

int operacoes = 0;

while (true == true)
{
    Console.Clear();

    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Bem vindo a Calculadora 2026");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("Digite alguma das opções válidas!");
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - TABUADA");
    Console.WriteLine("6 - Histórico de Operações");
    Console.WriteLine("S - Sair");

    string opcao = Console.ReadLine();

    if (opcao == "S" || opcao == "s")

        break;

    if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5" && opcao != "6")
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Opção Inválida!!!");
        Console.WriteLine("-------------------------------------------------");

        Console.WriteLine("Digite ENTER para sair...");
        Console.ReadLine();
        continue;
    }

    if (opcao == "5")
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Bem vindo a TABUADA");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Digite o número que deseja saber a tabuada!");

        string strNumeroInserido = Console.ReadLine();

        int numeroInserido = Convert.ToInt32(strNumeroInserido);

        Console.WriteLine("Entao você deseja saber a TABUADA do número: " + numeroInserido);

        Console.WriteLine("Digite o valor que você deseja que seja o início da sua multiplicação");

        string strInicioMultiplicacao = Console.ReadLine();

        int inicioTabuada = Convert.ToInt32(strInicioMultiplicacao);

        Console.WriteLine("Agora insira o número em que deseja parar a TABUADA!");

        string strFimMultiplicacao = Console.ReadLine();

        int fimTabuada = Convert.ToInt32(strFimMultiplicacao);

        for (int escolhaUsuario = inicioTabuada; escolhaUsuario <= fimTabuada; escolhaUsuario = escolhaUsuario++)
        {
            Console.WriteLine($"{numeroInserido} x {escolhaUsuario} = {numeroInserido * escolhaUsuario} ");
        }

        Console.WriteLine("Pressione ENTER para voltar ao menu principal!");

        Console.ReadLine();
        continue;
    }

    if (opcao == "6")
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Bem vindo ao Histórico de Operações");
        Console.WriteLine("-------------------------------------------------");

        for (int operacoesNumerico = 0; operacoesNumerico < historicoOperacoes.Length; operacoesNumerico++)

            if (historicoOperacoes[operacoesNumerico] != null)
            {
                Console.WriteLine(historicoOperacoes[operacoesNumerico]);
            }

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Pressione ENTER para voltar ao menu Principal!");
        Console.WriteLine("-------------------------------------------------");
        Console.ReadLine();
        continue;
    }

    Console.WriteLine("Digite o Primeiro número");
    string strPrimeiroNumero = Console.ReadLine();
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);


    Console.WriteLine("Digite o segundo número!");
    string strSegundoNumero = Console.ReadLine();
    int segundoNumero = Convert.ToInt32(strSegundoNumero);


    int resultado;

    string posicaoOperacao;

    if (opcao == "1")
    {
        resultado = primeiroNumero + segundoNumero;
        posicaoOperacao = $"{primeiroNumero} + {segundoNumero} = {resultado}";
    }

    else if (opcao == "2")
    {
        resultado = primeiroNumero - segundoNumero;
        posicaoOperacao = $"{primeiroNumero} - {segundoNumero} = {resultado}";
    }

    else if (opcao == "3")
    {
        resultado = primeiroNumero * segundoNumero;
        posicaoOperacao = $"{primeiroNumero} * {segundoNumero} = {resultado}";
    }

    else
    {
        resultado = primeiroNumero / segundoNumero;
        posicaoOperacao = $"{primeiroNumero} / {segundoNumero} = {resultado}";
    }

    if (operacoes < historicoOperacoes.Length)
    {
        historicoOperacoes[operacoes] = posicaoOperacao;
        operacoes++;
    }

    else
    {
        historicoOperacoes = new string[100];
        operacoes = 0;

        historicoOperacoes[operacoes] = posicaoOperacao;
        operacoes++;
    }

    Console.WriteLine("O resultado é: " + resultado);

    Console.ReadLine();
}
