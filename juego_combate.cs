using System;

class Personaje
{
    private string nombre;
    private string arma;
    private string tipo;

    public string Nombre
    {
        get { return nombre; }
    }

    public string Arma
    {
        get { return arma; }
    }

    public string Tipo
    {
        get { return tipo; }
    }

    public Personaje(string nombre, string arma, string tipo)
    {
        this.nombre = nombre;
        this.arma = arma;
        this.tipo = tipo;
    }

    public void Atacar()
    {
        Console.WriteLine("El personaje {0} ataca con {1}!", Nombre, Arma);
    }

    public void Correr()
    {
        Console.WriteLine("El personaje {0} griata aaaa y tira el primer ataque!", Nombre);
    }
    public void Tumba()
    {
        Console.WriteLine("El personaje {0} Tumba a su oponente Can!", Nombre);

    }
    public void defender()
    {
        Console.WriteLine("El personaje {0} se está defendiendo!", Nombre); 
    }
             public void bloquear()
    {
        Console.WriteLine("El personaje {0} bloquea el ataque!", Nombre);
             }
              public void cae()
              {
               Console.WriteLine("El personaje {0} Cae al piso!", Nombre);
              }
              public void Sonrrie()
              {
                  Console.WriteLine("El personaje {0} Sonrrie maleficamente por tumbar a su oponente Can!", Nombre);
                   }
              public void Levanta()
              {
                  Console.WriteLine("El personaje {0} Se levanta asombrosamente!", Nombre);
                   }
              public void Asombrado()
              {
                  Console.WriteLine("El personaje {0} Se asombra por la recuperacion de Can!", Nombre);
                   }
              public void Ataca()
              {
                  Console.WriteLine("El personaje {0} Ataca y clava su espada mortal en el corazón de Zeus !", Nombre);
                  }
              public void Cae()
              {
                  Console.WriteLine("El personaje {0} Cae derrotado!", Nombre);
                   }
              public void Logra()
              {
                  Console.WriteLine("El personaje {0} Logra derrotar a Zeus!", Nombre);
                  }
              public void Ganador()
              {
                  Console.WriteLine("El personaje {0} Es el ganador !", Nombre);


    }
}

class Program
{
    static void Main(string[] args)
    {
        Personaje Zeus = new Personaje("Zeus", "Hacha gigante", "Tanque");

        Console.WriteLine("Informacion del personaje 1");
        Console.WriteLine("Nombre: {0}", Zeus.Nombre);
        Console.WriteLine("Arma: {0}", Zeus.Arma);
        Console.WriteLine("Tipo: {0}", Zeus.Tipo);
        Zeus.Atacar();
        Zeus.Correr();
        Zeus.Tumba();
        Zeus.Sonrrie();
        Zeus.Asombrado();
        Zeus.Cae();
       
        Console.WriteLine();

        Personaje Can = new Personaje("Can", "Espada doble", "Filo mortal");

        Console.WriteLine("Informacion del personaje 2");
        Console.WriteLine("Nombre: {0}", Can.Nombre);
        Console.WriteLine("Arma: {0}", Can.Arma);
        Console.WriteLine("Tipo: {0}", Can.Tipo);
        Console.WriteLine("Acciones del personaje");
        Can.defender();
        Can.bloquear();
        Can.cae();
        Can.Levanta();
        Can.Ataca();
        Can.Logra();
        Console.WriteLine();
        Console.WriteLine();
        Can.Ganador();

        Console.ReadLine();
    }
}

