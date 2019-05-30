using System;

namespace Division
{
    class Program
    {
        static void Division(int dividendo, int divisor)
        {
           int resultado =0;
           int resto =0;
           int producto =0;
           int restoDec = 0;
           int productoDec =0;
           int restoDec2 =0;
           int resultDec =0;
     
           for(int i= 0;i<=dividendo;i++)
           {
               producto = i * divisor ;
               resto = dividendo%divisor;
               restoDec = resto * 10;
               for (int j=0;j<restoDec;j++)
               {
                  productoDec = j * divisor;
                  restoDec2 = restoDec%divisor;                                                     
                  productoDec = productoDec +                   
                  restoDec2;
                if (productoDec == restoDec)
                {
                    resultDec = j;
                    break;
                }
               }  
               producto = producto + resto;
               if (producto == dividendo)
               {
                   resultado = i;
                   break;
               }
           } 
            
            
            Console.WriteLine("{0} dividido {1} es {2}.{3}",dividendo ,divisor,resultado,resultDec);
        }
                static void Main(string[] args)
        {
            string DividendoString, DivisorString;
            int DividendoUser, DivisorUser = 1;
            int GetDividendo()
            {
            Console.WriteLine("Ingrese Numero a dividir:");
            DividendoString = Console.ReadLine();
            DividendoUser = Convert.ToInt32(DividendoString);
            return DividendoUser;
            }
            int GetDivisor()
            {
            Console.WriteLine("Ingrese Divisor:");
            DivisorString = Console.ReadLine();
            DivisorUser = Convert.ToInt32(DivisorString);
            return DivisorUser;
            }
            
            GetDividendo();
            GetDivisor();
            //VALIDACION - SI EL NUMERO ASIGNADO AL DIVISOR ES 0, VOLVEMOS A LLAMAR EL METODO
            if(DivisorUser == 0)
            {
                Console.WriteLine("No es posible dividir por 0, Ingrese otro numero.");
                GetDivisor();
            }

            Division(DividendoUser,DivisorUser);
                 

         }
    }
}
