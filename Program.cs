// See https://aka.ms/new-console-template for more information
using System;
class Program {

public abstract class Animal
{
private string cor;

private Acessorio a;

public Animal(string cor){
    this.cor = cor;
}

public void setAcessorio(Acessorio a){
    this.a = a;
}

public string setCor()
{
return this.cor;
}

public string getCor()
{
return this.cor;
}
}

public class Gato : Animal
{
public Gato(string a) : base(a)
{
}
}

public class Cachorro : Animal
{
public Cachorro(string c) : base(c)
{
}
}

public class Acessorio
{
private string cor;

public Acessorio(string cor)
{
this.cor = cor;
}

public string getCor()
{
return this.cor;
}
}

static void Main(string[] args)
{
//Animal a = new Animal("vermelho", 10.5);

Acessorio coleira = new Acessorio("Amarelo");
//g.Acessorio(coleira.getCor());
Console.WriteLine(coleira.getCor());
Console.ReadLine();
}
}