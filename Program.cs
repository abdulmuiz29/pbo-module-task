using System;

namespace Tugas_PBO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VGA
            Nvidia nvidia = new Nvidia("Nvidia");
            Amd amd = new Amd("AMD");

            //Processor
            Corei3 corei3 = new Corei3("Corei3");
            Corei5 corei5 = new Corei5("Corei5");
            Corei7 corei7 = new Corei7("Corei7");
            Ryzen ryzen = new Ryzen("Ryzen");

            //Laptop
            //Laptop 1 dengan objek Vivobook (VGA Nvidia dan Processor Core i5)
            Laptop laptop1 = new Vivobook(nvidia, corei5);

            //Laptop 2 dengan objek IdeaPad (VGA AMD dan Processor Ryzen)
            Laptop laptop2 = new IdeaPad(amd, ryzen);

            //predator dengan objek Predator (VGA AMD dan Processor Core i7
            Predator predator = new Predator(amd, corei7);

            //SOAL 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //SOAL 2
            laptop1.Ngoding();

            //SOAL 3
            Console.WriteLine($"Merk VGA = {laptop1.VGA.merk}, processor = {laptop1.Processor.merk}, Tipe = {laptop1.Processor.tipe}");

            //SOAL 4
            predator.BermainGame();

            //SOAL 5
            ACER acer = new Predator(amd, ryzen);
            //acer.BermainGame();
        }
    }
}

//VGA
class VGA
{
    public string merk;
    public VGA(string merk)
    {
        this.merk = merk;
    }
}

class Nvidia : VGA
{
    public Nvidia(string merk) : base(merk)
    {
        merk = "Nvidia";
    }
}

class Amd : VGA
{
    public Amd(string merk) : base(merk)
    {
        merk = "AMD";
    }
}

//PROCESSOR
class Processor
{
    public string merk;
    public string tipe;
    public Processor(string merk, string tipe)
    {
        this.merk = merk;
    }
}

class Intel : Processor
{
    public Intel(string tipe) : base("Intel", tipe)
    {
        this.tipe = tipe;
    }
}

class Corei3 : Intel
{
    public Corei3(string tipe) : base(tipe)
    {
        tipe = "Corei3";
    }
}

class Corei5 : Intel
{
    public Corei5(string tipe) : base(tipe)
    {
        tipe = "Corei5";
    }
}

class Corei7 : Intel
{
    public Corei7(string tipe) : base(tipe)
    {
        tipe = "Corei7";
    }
}

class AMD : Processor
{
    public AMD(string tipe) : base("AMD", tipe)
    {
        this.tipe = tipe;
    }
}

class Ryzen : AMD
{
    public Ryzen(string tipe) : base (tipe)
    {
        tipe = "Ryzen";
    }
}

class Athlon : AMD
{
    public Athlon(string tipe) : base(tipe)
    {
        tipe = "Athlon";
    }
}

//LAPTOP
class Laptop
{
    public string merk;
    public string tipe;
    public VGA VGA;
    public Processor Processor;
    public Laptop(string merk, string tipe, VGA VGA, Processor processor)
    {
        this.merk = merk;
        this.tipe = tipe;
        this.VGA = VGA;
        this.Processor = processor;
    }   

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} menyala");
    }

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} mati");
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!");
    }
}

class ASUS : Laptop
{
    public ASUS(string tipe, VGA VGA, Processor Processor) : base("ASUS", tipe, VGA, Processor)
    {
        this.tipe = tipe;
        this.VGA = VGA;
        this.Processor = Processor;
    }
}

class ROG : ASUS
{
    public ROG(VGA VGA, Processor Processor) : base("ROG", VGA, Processor)
    {
        this.VGA = VGA;
        this.Processor = Processor;
    }
}

class Vivobook : ASUS
{
    public Vivobook(VGA VGA, Processor processor) : base("Vivobook", VGA, processor)
    {
        this.VGA = VGA;
        this.Processor = processor;
    }
}

class ACER : Laptop
{
    public ACER(string tipe, VGA VGA, Processor processor) : base("ACER", tipe, VGA, processor)
    {
        this.tipe = tipe;
        this.VGA = VGA;
        this.Processor = processor;
    }
}

class Swift : ACER
{
    public Swift(VGA VGA, Processor processor) : base("Swift", VGA, processor)
    {
        this.VGA = VGA;
        this.Processor = processor;
    }
}

class Predator : ACER
{
    public Predator(VGA VGA, Processor processor) : base("Predator", VGA, processor)
    {
        this.VGA = VGA;
        this.Processor = processor;
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {this.merk} {this.tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo(string tipe, VGA VGA, Processor processor) : base("","Lenovo", VGA, processor)
    {
        this.tipe = tipe;
        this.VGA = VGA;
        this.Processor = processor;
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad(VGA VGA, Processor processor) : base("IdeaPad", VGA, processor)
    {
        this.VGA = VGA;
        this.Processor = processor;
    }
}

class Legion : Lenovo
{
    public Legion(VGA VGA, Processor processor) : base("Legion", VGA, processor)
    {
        this.VGA = VGA;
        this.Processor = processor;
    }
}

