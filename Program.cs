using Karakter;
using musuh;

namespace Karakter
{
    public interface Syarat_Karakter
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Kekuatan { get; set; }
        public int pengurangan_MN_basic { get; set; }
        public int pengurangan_MN_skill { get; set; }



        int serang();
        int gunakanSkill(int skill);
        void cetakInformasi();

    }
    public abstract class Method : Syarat_Karakter
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Kekuatan { get; set; }
        public int pengurangan_MN_basic { get; set; }
        public int pengurangan_MN_skill { get; set; }

        public abstract int serang();
        public abstract int gunakanSkill(int skill);
        public abstract void cetakInformasi();


    }

    public class Pemain : Method
    {
        public override int serang()
        {
            if (MP > pengurangan_MN_basic)
            {
                MP = MP - pengurangan_MN_basic;
                return Kekuatan;
            }
            else
            {
                return 0;
            }
        }


        public override int gunakanSkill(int skill)
        {
            if (skill == 1)
            {
                if (MP > pengurangan_MN_skill)
                {
                    MP -= pengurangan_MN_skill;
                    return Kekuatan * 2;
                }
                else
                {
                    return 0;
                }
                
            }
            else if (skill == 2) // Ice Blast
            {
                if (MP > pengurangan_MN_skill)
                {
                    MP -= pengurangan_MN_skill;
                    return Kekuatan * 3;
                }
                else
                {
                    return 0;
                }
            }
            else // Healing
            {
                HP += 200;
                MP += 30;
                return 0;
            }
            
        }

        public override void cetakInformasi()
        {
            Console.WriteLine($"karakter           : {nama_karakter}");
            Console.WriteLine($"HP Tersisa         : {HP}");
            Console.WriteLine($"Mana Power tersisa : {MP}");
        }
    }
}

namespace musuh
{
    public interface Syarat_Musuh
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int Kekuatan { get; set; }

        int diserang(int skill);
        void mati();
       

    }
    public abstract class Method : Syarat_Musuh
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int Kekuatan { get; set; }
        public abstract int diserang(int skill);
        public abstract void mati();

    }

    public class Musuh : Method
    {
        public override int diserang(int skill)
        {
            HP = HP - skill;
            return HP;
        }
        public override void mati()
        {
            Console.WriteLine($"{nama_karakter} telah mati.....");
        }
    }

}





public class Program
{
    static void Main(string[] args)
    {
        Pemain Karakter = new Pemain();
        Karakter.nama_karakter = "Edwin";
        Karakter.HP = 6700;
        Karakter.MP = 350;
        Karakter.Kekuatan = 250;
        Karakter.pengurangan_MN_basic = 20;
        Karakter.pengurangan_MN_skill = 50;

        Musuh Musuh1 = new Musuh();
        Musuh1.nama_karakter = "Eka";
        Musuh1.HP = 6500;
        Musuh1.Kekuatan = 240;

        Console.WriteLine("Enter Untuk Mengadu Edwin dan Eka!!");
        Console.ReadLine();

        while (Musuh1.HP > 0)
        {
            Console.WriteLine("--------------------------------------------------------------------------");
            Karakter.cetakInformasi();
            Console.WriteLine($"HP {Musuh1.nama_karakter} saat ini : {Musuh1.HP}");
            Console.WriteLine($"Ayo {Karakter.nama_karakter} serangg!!! , jumlah mana {Karakter.MP}, Kekuatan {Karakter.Kekuatan}");
            Console.WriteLine("1.Basic Attack");
            Console.WriteLine("2.Fireball");
            Console.WriteLine("3.Ice Blast");
            Console.WriteLine("4.Heal");
            Console.WriteLine("--------------------------------------------------------------------------");
            string pilihan = Console.ReadLine();

            if (pilihan == "1") // Basic Attact/ serangan biasa
            {
                Console.WriteLine("Menyerang lawan dengan basic attack");
                Musuh1.diserang(Karakter.serang());
                Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh1.HP}");
            }
            else if (pilihan == "2")// FIreball
            {
                Console.WriteLine("Menyerang lawan dengan Fireball!!");
                Musuh1.diserang(Karakter.gunakanSkill(1));
                Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh1.HP}");
            }
            else if (pilihan == "3")// Ice Blast
            {
                Console.WriteLine("Menyerang lawan dengan Ice Blast!!");
                Musuh1.diserang(Karakter.gunakanSkill(2));
                Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh1.HP}");
                Console.WriteLine($"{Musuh1.nama_karakter} Melambattt !!!");
            }
            else // Healing 
            {
                Console.WriteLine("Healing"); 
                Karakter.gunakanSkill(3);
                Console.WriteLine($"Healing... HP mu saat ini {Karakter.HP}");
            }
        }
        Musuh1.mati(); // Method Mati Musuh
        Console.WriteLine("Horee Kamu Menang!!!!");
        Thread.Sleep(2500);

    }
}


