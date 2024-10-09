//1

int idade = 98;
string nome = "Bartolomeu";

Console.WriteLine($"Olá, meu nome é {nome} e eu tenho " + idade + " anos.");
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 2

int Nascimento = 1926;
int anoAtual = 2024;

int idadeCalculo = anoAtual - Nascimento;
Console.WriteLine($"alguém que nasceu no ano de {Nascimento} e vive até o ano de " + anoAtual + $", tem {idadeCalculo} anos.");
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 3

int n1 = 14;
int n2 = 16;
int n3 = 3;

int simples = (n1 + n2 + n3) / 3;
Console.WriteLine($"A média simples dos números {n1}, {n2} e {n3} é: {simples}.");
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 4

int n4 = 8;
int n5 = 7;
int n6 = 5;
int p1 = 3;
int p2 = 4;
int p3 = 5;
double ponderada = (n4 * p1 + n5 * p2 + n6 * p3) / (p1 + p2 + p3);
Console.WriteLine($"A média ponderada dos números {n4}, {n5}, {n6} com os pesos {p1}, {p2}, {p3} é: " + ponderada);
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();


// 5

Console.Write("Informe o tamanho em metros quadrados da área a ser pintada: ");
double area = Convert.ToDouble(Console.ReadLine());

double litros = area / 3;
double latas = Math.Ceiling(litros / 18);
double preco = latas * 80;

Console.WriteLine($"Você precisará de {latas} latas de tinta.");
Console.WriteLine($"O preço total será de R$ {preco:F2}.");
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 6

Console.WriteLine("Olá, qual turno que você estuda?");
Console.WriteLine("M - Matutino");
Console.WriteLine("V - Vespertino");
Console.WriteLine("N - Noturno");
string escolha = Console.ReadLine();

switch (escolha)
{
    case "m":
        Console.WriteLine("Bom dia!");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
        break;

    case "v":
        Console.WriteLine("Boa tarde!");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
        break;

    case "n":
        Console.WriteLine("Boa noite!");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
        break;

    default:
        Console.WriteLine("inválido.");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
        break;
}

// 7
try
{
    Console.WriteLine("Digite sua idade.");
    int suaIdade = int.Parse(Console.ReadLine());

    if (suaIdade >= 18)
    {
        Console.WriteLine("Você é maior de idade.");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
    }
    if (suaIdade < 18)
    {
        Console.WriteLine("Você é menor de idade.");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
    }
}
catch (FormatException)
{
    Console.WriteLine("Idade inválida. Digite uma idade válida.");
    Console.WriteLine("Para continuar aperte 'ENTER'");
    Console.ReadLine();
}

// 8

Console.WriteLine("Digite um ano para verificar se é bissexto.");
int ano = int.Parse(Console.ReadLine());

bool Bissexto = (ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0;
if (Bissexto)
{
    Console.WriteLine("é bissexto.");
    Console.WriteLine("Para continuar aperte 'ENTER'");
    Console.ReadLine();
}
else
{
    Console.WriteLine("não é bissexto.");
    Console.WriteLine("Para continuar aperte 'ENTER'");
    Console.ReadLine();
}

// 9

for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 10

int soma = 0;
for (int i = 0; i <= 100; i++)
{
    soma += i;
}
Console.WriteLine("A soma dos números de 0 a 100 é: " + soma);
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 11

long fatorial = 1;
for (int i = 1; i <= 100; i++)
{
    fatorial *= i;
}
Console.WriteLine("O fatorial de 100 é: " + fatorial);
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

// 12

string teuNome;
string senha;

while (true)
{
    Console.Write("Informe seu nome de usuário: ");
    teuNome = Console.ReadLine();

    Console.Write("Informe sua senha: ");
    senha = Console.ReadLine();

    if (teuNome == senha)
    {
        Console.WriteLine("Erro: A senha não pode ser igual ao nome de usuário.");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Cadastro realizado com sucesso!");
        Console.WriteLine("Para continuar aperte 'ENTER'");
        Console.ReadLine();
        break;
    }
}

// Exercicio 13

for (int i = 1; i <= 50; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
Console.WriteLine("Para continuar aperte 'ENTER'");
Console.ReadLine();

Console.WriteLine("FIM...");