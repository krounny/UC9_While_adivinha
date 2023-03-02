
string palavrasecreta, palavrausuario;
int tentativas;

palavrasecreta = "fedida";
tentativas = 3;

while (tentativas > 0)
{
    Console.Clear();
    Console.WriteLine("A Luisa é: \n " + "Você ainda tem " + tentativas + " tentativas! \n\n");

    Console.WriteLine("Digite a palavra: ");
    palavrausuario = Console.ReadLine();

    if (palavrausuario == palavrasecreta)
    {
        Console.WriteLine("Ela é mesmo!!!");
        tentativas = 0;
    }
    else
    {
        tentativas--;
    }
}
