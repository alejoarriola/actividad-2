using System;
					
public class Program
{
	public static void Main(string[] args)
	{
		string c ="";
            int e = 0;
            double a = 0.0;
            
            
            Console.WriteLine("ingrese su edad:");
            c = Console.ReadLine();
            e = Convert.ToInt32(c);
		if(e < 5 ) 
            {
                Console.WriteLine("Disculpe, usted es muy pequeño para entrar al  parque.");
            }
            else
             {
				if(e>40)
				{
					Console.WriteLine("usted es muy mayor para entrar al parque.");
				}
            
                else
				{
					Console.WriteLine ("Bienvenido");
                
                Console.WriteLine("ingrese su altura:");
                c = Console.ReadLine();
                a = Convert.ToDouble(c);
                
                if(a < 1.6)
                {
                Console.WriteLine("puede jugar en todas las atracciones menos  las montañas rusas y el barco");    
                }
                else
                {
                    Console.WriteLine("tiene acceso a todas las atracciones");
                
                }
				}
                
            
            }
            
            
            
	}
}