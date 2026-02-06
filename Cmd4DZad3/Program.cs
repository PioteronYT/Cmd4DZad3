using Cmd4DZad3;

List<Pojazd> pojazdy = new List<Pojazd>();

Console.Write("Podaj nazwę samochodu: ");
string nazwaAuta = Console.ReadLine();

Console.Write("Podaj rokProdukcji samochodu: ");
UInt16 rokProdukcjiAuta = UInt16.Parse(Console.ReadLine());

Console.Write("Podaj liczbę drzwi samochodu: ");
int liczbaDrzwi = int.Parse(Console.ReadLine());

pojazdy.Add(new Samochod(nazwaAuta, rokProdukcjiAuta, liczbaDrzwi));


Console.Write("\nPodaj nazwę motocykla: ");
string nazwaMotocykla = Console.ReadLine();

Console.Write("Podaj rokProdukcji motocykla: ");
UInt16 rokProdukcjiMotocykla = UInt16.Parse(Console.ReadLine());

Console.Write("Podaj czy motocykl jest zabytkiem: ");
bool czyZabytek = bool.Parse(Console.ReadLine());

pojazdy.Add(new Motocykl(nazwaMotocykla, rokProdukcjiMotocykla, czyZabytek));


foreach (Pojazd pojazd in pojazdy)
{
    string[] opis = pojazd.Opis().Split(" ");
    string dodatkoweInfo = pojazd.GetType() == typeof(Samochod) ? "Liczba drzwi: " : "Czy zabytkowy: ";


    Console.WriteLine($"\nOpis:\n-Nazwa: {opis[0]}\n-Rok Produkcji: {opis[1]}\n-{dodatkoweInfo + opis[2]}");
    Console.WriteLine("Koszt wynajmu za 5 dni: " + pojazd.ObliczKosztWynajmu(5) + "zł");
}