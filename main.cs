using System;

class Program {
  static string alfabeto = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj1 = Console.ReadLine();
      while (string.IsNullOrEmpty(msj1))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj1 = Console.ReadLine();
      }
      Console.WriteLine("Ingrese la distancia de cifrado");
      int distancia = int.Parse(Console.ReadLine());
      Program program = new Program();
      Console.WriteLine("Mensaje cifrado: ");
      Console.WriteLine(program.Cifrar(msj1, distancia));

      // -------------------------------------------------

      Console.WriteLine("Ingrese la frase a descifrar");

      string msj2 = Console.ReadLine();
      while (string.IsNullOrEmpty(msj2))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj2 = Console.ReadLine();
      }
      Console.WriteLine("Ingrese la distancia de cifrado");
      int distancia2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Mensaje descifrado: ");
      Console.WriteLine(program.Descifrar(msj2,distancia2));
  }

  private string Cifrar(string msj, int distancia) {
      string aux = "";

      foreach (char c in msj) {
          int posicion = alfabeto.IndexOf(c);
          if (posicion != -1) {
              posicion = (posicion + distancia) % alfabeto.Length;
              aux += alfabeto[posicion];
        }
        else {
            aux += c;
        }
      }
    return aux;
  }

  private string Descifrar(string msj, int distancia){
    string aux = "";
    foreach(char c in msj){
        int posicion = alfabeto.IndexOf(c);
        if(posicion == -1){
            aux += c;
    }
    else{
      posicion = (posicion - distancia) % alfabeto.Length;
      aux += alfabeto[posicion];
    }

  }
    return aux;
    }

}