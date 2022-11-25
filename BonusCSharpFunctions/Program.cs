// See https://aka.ms/new-console-template for more information

/*
BONUS:
Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile,
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. 
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. 
Rieseguire il programma con l’input preso esternamente dall’utente.
*/

//------------------bonus-----------
//chiedere all’utente quanti numeri voglia inserire
//correzione mattina senza Method
Console.Write("Quanti numeri vuoi inserire? ");
int lunghezzaArray = int.Parse(Console.ReadLine());
int[] arrayNumeriSceltiDaUtente = new int[lunghezzaArray];
for (int i = 0; i < lunghezzaArray; i++)
{
    Console.Write("Inserisci un numero: ");
    arrayNumeriSceltiDaUtente[i] = int.Parse(Console.ReadLine());
}


//StampaArrayInteri(array);
Console.Write("L'array selezionato è: ");
StampaArrayInteri(arrayNumeriSceltiDaUtente);

//stampa array con numeri elevati al quadrato
int[] arrayNumeriScetiDaUtenteAlQuadrato = ElevaArrayAlQuadrato(arrayNumeriSceltiDaUtente);
Console.Write("L'array di numeri scelti dall'utente elevati al quadrato è: ");
StampaArrayInteri(arrayNumeriScetiDaUtenteAlQuadrato);

Console.Write("L'array di numeri originali scelti dall'utente è: ");
StampaArrayInteri(arrayNumeriSceltiDaUtente);

//stampa somma di tutti i numeri
int sommaNumeriSceltiDaUtente = SommaElementiArray(arrayNumeriSceltiDaUtente);
Console.WriteLine("La somma di tutti i numeri scelti dall'utente è: " + sommaNumeriSceltiDaUtente);

//stampa somma di tutti i numeri elevati al quadrati
int sommaNumeriSceltiDaUtenteAlQuadrato = SommaElementiArray(arrayNumeriScetiDaUtenteAlQuadrato);
Console.WriteLine("La somma di tutti i numeri scelti dall'utente elevati al quadrato è: " + sommaNumeriSceltiDaUtenteAlQuadrato);


//----------------------------------------------------------------//



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

    for (int i = 0; i < array.Length; i++)
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





/*
 ESERCIZIO DI BASE

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

/*

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

    for (int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
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
*/












//------------------------PROVE-------------
/*

int[] arrayUtente = { };
Console.Write("Quanti numeri vuoi inserire? ");
int lunghezzaArray = int.Parse(Console.ReadLine());
Array.Resize(ref arrayUtente, lunghezzaArray);


for (int i = 0; i < lunghezzaArray; i++)
{
    Console.Write("Inserisci un numero: ");
    int numeroScelto = int.Parse(Console.ReadLine());
    numeroScelto = arrayUtente[i];
}

//--------------------------funzione------------------//
//stampa array selezionato dall'utente
void StampaArrayUtente(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < lunghezzaArray; i++)
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

//eleva al quadrato utente
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < array.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * copiaArray[i];
    }
    return copiaArray;
}
*/

/*
//uso di Array.Resize Method

int[] arrayNumeriSceltiDaUtente = { };

Console.Write("Quanti numeri vuoi inserire? ");
int lunghezzaArray = int.Parse(Console.ReadLine());
Array.Resize(ref arrayNumeriSceltiDaUtente, lunghezzaArray); // ---> Array.Resize Method

for (int i = 0; i < lunghezzaArray; i++)
{
    Console.Write("Inserisci un numero: ");
    arrayNumeriSceltiDaUtente[i] = int.Parse(Console.ReadLine());
}
*/