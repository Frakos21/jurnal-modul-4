// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;



public class KodeBuah{
    public enum Buah
    {
        apel,aprikot, alpukat, pisang, paprika, blackberry, ceri, kelapa, jagung
    } 
    public static String getKodeBuah(Buah input)
    {
        String[] KodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00" };
        return KodeBuah[(int)input];
    }
    public static void Main(String[] args)
    {
        Buah inputBuah = Buah.alpukat;
        String result = getKodeBuah(inputBuah);
        Console.WriteLine("Nama Buah: "+inputBuah+"\nKode Buah: "+result);
    }
}
