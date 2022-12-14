// See https://aka.ms/new-console-template for more information

/*
Funzioni di base:
- void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.
- int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
- int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
- int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

Completate funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel codice, si vogliono utilizzare le funzioni per:
- Stampare l’array di numeri fornito a video
- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato 
(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
- Stampare la somma di tutti i numeri
- Stampare la somma di tutti i numeri elevati al quadrati
*/



//-----------------------MAIN---------------------------------//
//array di numeri interi
int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };

//stampa array
Console.Write("L'array di numeri è: ");
StampaArrayInteri(arrayNumeri);

//stampa array con numeri elevati al quadrato
int[] arrayNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayNumeri);
Console.Write("L'array di numeri elevati al quadrato è: ");
StampaArrayInteri(arrayNumeriAlQuadrato);

Console.Write("L'array di numeri originali è: ");
StampaArrayInteri(arrayNumeri);

//stampa somma di tutti i numeri
int sommaNumeriArray = SommaElementiArray(arrayNumeri);
Console.WriteLine("La somma di tutti i numeri è: " + sommaNumeriArray);

//stampa somma di tutti i numeri elevati al quadrati
int sommaNumeriAlQuadratoArray = SommaElementiArray(arrayNumeriAlQuadrato);
Console.WriteLine("La somma di tutti i numeri elevati al quadrato è: " + sommaNumeriAlQuadratoArray);


//------------------------------------------------------------//



//-------------------------FUNZIONI----------------------------//
//stampa a video il contenuto dell’array
void StampaArrayInteri(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}


//stampa quadrato del numero passato come parametro
int Quadrato(int numero)
{
    numero = numero * numero;
    return numero;
}


//array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato ---> copiaArray = array copiato per modifica
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for(int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;
}


//array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array
int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}


//------------------------------------------------------------//
