using Geometria;

Console.WriteLine("BENVENUTO NEL MIO PROGRAMMA!\n");

Console.WriteLine("Inserire la base del rettangolo: ");
int larghezza = Convert.ToInt32(Console.ReadLine()); //larghezza = base
Console.WriteLine("Inserire l'altezza del rettangolo: ");
int altezza = Convert.ToInt32(Console.ReadLine());

Rettangolo rettangolo = new Rettangolo(larghezza, altezza);

rettangolo.stampaRettangolo();
