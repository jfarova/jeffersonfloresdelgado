internal class Program
{
    private static void Main(string[] args)
    
    {
        
   int numeros; 
  int total=0;
  int i;
  
  Console.WriteLine("Introduzca 8 números: ");
  for (i=0; i<8; i++){
    numeros=int.Parse(Console.ReadLine());
    total=total + numeros;
  }

  Console.WriteLine("La suma de los números es "+total);

        }
        
    }

