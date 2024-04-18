int n1, n2;
int media;

Console.WriteLine("Digite a primeira nota: ");
n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
n2 = int.Parse(Console.ReadLine());

if (n1 < 0 || n2 < 0)
{
    Console.WriteLine("Valores negativos não podem ser atribuídos as notas!");
}

else
{
    media = (n1 + n2) / 2;
    Console.WriteLine("A media do aluno é: {0}", media);


    if (media <= 3)
    {
        Console.WriteLine("O aluno está reprovado.");
    }
        
    else if (media > 3 && media <= 5)
    {
        Console.WriteLine("O aluno está de exame.");
    }
    

    else
    {
        Console.WriteLine("O aluno está aprovado.");
    }

}

Console.ReadKey();