using System.Security.AccessControl;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List<string> listaDasBandas = new List<string>();

Console.WriteLine(mensagemDeBoasVindas);

ExibirOpcoesDoMenu();
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            AvaliarBandas();
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Tchau tchau :)");
            break;
        default:
            OpcaoInvalida();
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.Write("Digite qual banda ou artista você deseja registrar: ");
    string bandaRegistrada = Console.ReadLine()!;
    listaDasBandas.Add(bandaRegistrada);
    Console.WriteLine($"Você registrou a banda ou artista {bandaRegistrada}!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirBandas ()
{
    Console.WriteLine(string.Empty);
    foreach(string banda in listaDasBandas)
    {
        Console.WriteLine(banda);
    }

    Console.WriteLine($"Total de artistas e bandas registradas: {listaDasBandas.Count}");
    Console.WriteLine(string.Empty);

    Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
    Console.ReadKey();
    Console.Clear();
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void OpcaoInvalida ()
{
    Console.WriteLine("Opção inválida, tente novamente!");
    Thread.Sleep(2000);
    Console.Clear ();
    ExibirOpcoesDoMenu();
}

void AvaliarBandas ()
{
    Console.WriteLine (string.Empty);
    Console.WriteLine("Qual banda ou artista você deseja avaliar?");
    for(int i=0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine(i + "- " + listaDasBandas[i]);
    }
}