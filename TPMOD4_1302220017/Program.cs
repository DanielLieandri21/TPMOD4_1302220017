using tpmod4_1302220017;
using static tpmod4_1302220017.KodePos;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nomor 3 A-C : \n");
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode pos Antapani Kidul\t: " + kodePos.GetKodePos(Kelurahan.Antapani_Kidul));
        Console.WriteLine("Kode pos Antapani Kulon\t: " + kodePos.GetKodePos(Kelurahan.Antapani_Kulon));
        Console.WriteLine("Kode pos Antapani Tengah\t: " + kodePos.GetKodePos(Kelurahan.Antapani_Tengah));
        Console.WriteLine("Kode pos Antapani Wetan\t\t: " + kodePos.GetKodePos(Kelurahan.Antapani_Wetan));
        Console.WriteLine("Kode pos Cibaduyut Kidul\t: " + kodePos.GetKodePos(Kelurahan.Cibaduyut_Kidul));
        Console.WriteLine("Kode pos ibaduyut Wetan\t: " + kodePos.GetKodePos(Kelurahan.Cibaduyut_Wetan));
        Console.WriteLine("Kode pos Cibaduyut\t: " + kodePos.GetKodePos(Kelurahan.Cibaduyut));
        Console.WriteLine("Kode pos Kebon_Lega\t: " + kodePos.GetKodePos(Kelurahan.Kebon_lega));
        Console.WriteLine("Kode pos Mekarwangi\t: " + kodePos.GetKodePos(Kelurahan.Mekarwangi));
        Console.WriteLine("Kode pos Situsaeur\t\t: " + kodePos.GetKodePos(Kelurahan.Situsaeur));
        Console.WriteLine("Kode pos Kopo\t\t: " + kodePos.GetKodePos(Kelurahan.Kopo));

        // Commit "menambahkan implementasi dengan table-driven"

        Console.WriteLine("\n\n\nNomor 5 A-E : \n");

        DoorMachine door = new DoorMachine();
        door.DoAction(Action.BukaPintu);
        door.DoAction(Action.KunciPintu);
        door.DoAction(Action.KunciPintu); // Kunci lagi, tidak akan terjadi apa-apa karena pintu sudah terkunci
        door.DoAction(Action.BukaPintu);

        // Commit "menambahkan implementasi dengan state-based construction"
    }
}
