{
    Console.Write("Informe a primeira nota: ");
    double n1 = double.Parse(Console.ReadLine());
    Console.Write("Informe a segunda nota: ");
    double n2 = double.Parse(Console.ReadLine());
    Console.Write("informe a terceira nota: ");
    double n3 = double.Parse(Console.ReadLine());
    Console.Write("Informe a quarta nota: ");
    double n4 = double.Parse(Console.ReadLine());
    double média = (n1 + n2 + n3 + n4) / 4;
    
    if(média >= 0 && média <= 3)
    {
        Console.Write("Sua média é " + média + ", você foi reprovado!");
    }
    if(média >= 4 && média <= 6)
    {
        Console.Write("Sua média é " + média + ", você está de recuperação!");
    }
    if(média >= 7 && média <= 10)
    {
        Console.Write("Sua média é " + média + ", você foi aprovado!");
    }
}