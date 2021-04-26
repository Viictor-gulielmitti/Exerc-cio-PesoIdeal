using System;

namespace Exerc_cio_PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            string  Sexo ;
            duplo  numero , resposta ;

            
        Console.WriteLine ("Peso ideal");
        Console.Write ("Digite sua altura em m ...: " );
        
        numero  =  Convert.ToDouble(Console.ReadLine());
        Console.Write ("Sexo [m] asculino / [f] eminino ..." );
         Sexo =  Console . ReadLine ();

        if ( Sexo  ==  " m " ) {
        resposta  = ( numero  *  72,7 ) - 58;
        Console . WriteLine ($"Seu peso ideal é { resposta } kg " );

        }
        else  if ( Sexo  ==  " f " ) {
        
        resposta  = ( numero  *  62,1 ) -  44 ;
        
        Console . WriteLine ($" Seu peso ideal é { resposta } kg " );
        
    }

    
        }
    }
}

