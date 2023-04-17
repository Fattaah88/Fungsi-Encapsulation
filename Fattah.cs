using System;

public class Mahasiswa
{
    private string nama;
	private string kelas;
	private string tempat_tinggal;
    private string nim;
    private int umur;
    
    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }
	 public string Kelas
    {
        get { return kelas; }
        set { kelas = value; }
    }
	 public string Tempat_Tinggal
    {
        get { return tempat_tinggal; }
        set { tempat_tinggal = value; }
    }
    
    public string Nim
    {
        get { return nim; }
        set { nim = value; }
    }
    
    public int Umur
    {
        get { return umur; }
        set { umur = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa();
        mhs1.Nama = "Fattah Herdansyah Alhammid";
		mhs1.Kelas = "INFORMATIKA 5";
		mhs1.tempat_tinggal = "Karanganyar";
        mhs1.Nim = "22114814";
        mhs1.Umur = 19;

        Console.WriteLine("Nama Mahasiswa: " + mhs1.Nama);
		Console.WriteLine("Kelas Mahasiswa: " + mhs1.Kelas);
		Console.WriteLine("Tempat tinggal Mahasiswa: " + mhs1.Tempat_Tinggal);
        Console.WriteLine("NIM Mahasiswa: " + mhs1.Nim);
        Console.WriteLine("Umur Mahasiswa: " + mhs1.Umur);
        Console.ReadLine();
    }
}
