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
      Program program = new Program();
      Console.WriteLine("Mensaje cifrado: ");
      Console.WriteLine(program.Cifrar(msj1));

      // -------------------------------------------------
    
      Console.WriteLine("Ingrese la frase a descifrar");

      string msj2 = Console.ReadLine();
      while (string.IsNullOrEmpty(msj2))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj2 = Console.ReadLine();
      }
      Console.WriteLine("Mensaje descifrado: ");
      Console.WriteLine(program.Descifrar(msj2));
  }

  private string Cifrar(string msj) {
      string aux = "";

      foreach (char c in msj) {
          int posicion = alfabeto.IndexOf(c);
          if (posicion != -1) {
              posicion = (posicion + 7) % alfabeto.Length;
              aux += alfabeto[posicion];
        }
        else {
            aux += c;
        }
      }
    return aux;
  }

  private string Descifrar(string msj){
    string aux = "";
    foreach(char c in msj){
        int posicion = alfabeto.IndexOf(c);
        if(posicion == -1){
            aux += c;
    }
    else{
      posicion = (posicion - 7) % alfabeto.Length;
      aux += alfabeto[posicion];
    }
    
  }
    return aux;
    }
    
}