namespace ConsoleApp1;
class Program
{

    public static void Main()
    {
        Console.Clear();
        //Memanggil Method yang dibuat
        TampilanAwal();
        string input = Console.ReadLine();
        string input_condition = "";
        string[] perhitungan_kalkulator = {
            "1. Pertambahan", "2. Pengurangan", "3. Perkalian", "4. Pembagian", "5. Kembali"};

        switch (input)
        {
            case "1":
            kalkulator:
                Console.Clear();
                Console.WriteLine("====== Kalkulator Matematika Dasar ======");
                Console.WriteLine("\n" + perhitungan_kalkulator[0]);
                Console.WriteLine(perhitungan_kalkulator[1]);
                Console.WriteLine(perhitungan_kalkulator[2]);
                Console.WriteLine(perhitungan_kalkulator[3]);
                Console.WriteLine(perhitungan_kalkulator[4]);
                Console.Write("Masukan Pilihan Anda: ");
                input = Console.ReadLine();

                Kalkulator(input);
                Console.Write("\nApakah Anda Ingin Coba Lagi? (Y/n)");
                input_condition = Console.ReadLine();
                if (input_condition == "Y" || input_condition == "y")
                {
                    goto kalkulator;
                }
                else if (input_condition == "N" || input_condition == "n")
                {
                    Main();
                }
                else
                {
                    WrongInput();
                }
                break;
            case "2":
            segitiga:
                Console.Clear();
                Console.Write("Masukan Jumlah Baris: ");
                input = Console.ReadLine();

                Segitiga(Convert.ToInt32(input));
                Console.Write("\nApakah Anda Ingin Coba Lagi? (Y/n)");
                input_condition = Console.ReadLine();
                if (input_condition == "Y" || input_condition == "y")
                {
                    goto segitiga;
                }
                else if (input_condition == "N" || input_condition == "n")
                {
                    Main();
                }
                else
                {
                    WrongInput();
                }
                break;
            case "3":
                Console.Clear();
                Console.WriteLine("Terima kasih, datang lagi yaaa~~ :D");
                Environment.Exit(1);// exit
                break;
            default:
                WrongInput();
                break;
        }
    }

    // Method Untuk Menampilkan Tampilan Awal
    static void TampilanAwal()
    {
        Console.WriteLine("============ Perhitungan ============");
        Console.WriteLine("\n1. Kalkulator");
        Console.WriteLine("2. Segitiga");
        Console.WriteLine("3. Exit");
        Console.Write("Masukan Pilihan Anda: ");
    }

    // Method Untuk Operasi Kalkulator
    // Apakah bisa menginput angka minus*
    // Dapat memberi jumlah input angka sesuai keinginan *
    static void Kalkulator(string input)
    {
        Console.Clear();

        switch (input)
        {
            // if diganti switch *
            case "1":
                InputNilaiKalkulator(input);
                break;
            case "2":
                InputNilaiKalkulator(input);
                break;
            case "3":
                InputNilaiKalkulator(input);
                break;
            case "4":
                InputNilaiKalkulator(input);
                break;
            case "5":
                Main();
                break;
            default:
                WrongInput();
                break;
        }
    }

    static void InputNilaiKalkulator(string input)
    {

        switch (input)
        {
            case "1":
                JumlahInputan(input);
                break;
            case "2":
                JumlahInputan(input);
                break;
            case "3":
                JumlahInputan(input);
                break;
            case "4":
                JumlahInputan(input);
                break;
            default:
                Console.WriteLine("Wrong iunput");
                break;


        }
    }

    static void JumlahInputan(string input)
    {
        int BanyakInputan;
        double hasil = 0d;
        double[] ArrayAngka = { };
        List<double> ListAngka = new List<double>();

        Console.WriteLine("Gunakan [, / .] untuk angka desimal");
        Console.Write("Masukan berapa banyak inputan: ");
        BanyakInputan = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < BanyakInputan; i++)
        {
            Console.Write("Masukan angka ke-{0}: ", i + 1);
            ListAngka.Add(Convert.ToDouble(Console.ReadLine()));
        }

        ArrayAngka = ListAngka.ToArray();

        switch (input)
        {
            case "1":
                for (int i = 0; i < ArrayAngka.Length; i++)
                {
                    if (ArrayAngka[i] == ArrayAngka[0])
                    {
                        hasil = ArrayAngka[i] + hasil;
                    }
                    else
                    {
                        hasil = hasil + ArrayAngka[i];
                    }


                }
                Console.WriteLine("Penjumlahannya adalah = {0}", hasil);
                break;
            case "2":
                for (int i = 0; i < ArrayAngka.Length; i++)
                {
                    if (ArrayAngka[i] == ArrayAngka[0])
                    {
                        hasil = ArrayAngka[i] - hasil;
                    }
                    else
                    {
                        hasil = hasil - ArrayAngka[i];
                    }
                }
                Console.WriteLine("Pengurangannya adalah = {0}", hasil);
                break;
            case "3":
                hasil = 1d;
                for (int i = 0; i < ArrayAngka.Length; i++)
                {
                    if (ArrayAngka[i] == ArrayAngka[0])
                    {
                        hasil = ArrayAngka[i] * hasil;
                    }
                    else
                    {
                        hasil = hasil * ArrayAngka[i];
                    }
                }
                Console.WriteLine("Perkaliannya adalah = {0}", hasil);
                break;
            case "4":
                hasil = 1d;
                for (int i = 0; i < ArrayAngka.Length; i++)
                {
                    if (ArrayAngka[i] == ArrayAngka[0])
                    {
                        hasil = ArrayAngka[i] / hasil;
                    }
                    else
                    {
                        hasil = hasil / ArrayAngka[i];
                    }
                }
                Console.WriteLine("Pembagiannya adalah = {0}", hasil);
                break;
        }

    }


    // Method untuk perhitungan kalkulator
    static int PerhitunganKalkulator(string input, int angka1, int angka2)
    {
        int hasil = 0;

        switch (input)
        {
            case "1":
                hasil = angka1 + angka2;
                break;
            case "2":
                hasil = angka1 - angka2;
                break;
            case "3":
                hasil = angka1 * angka2;
                break;
            case "4":
                hasil = angka1 / angka2;
                break;
        }

        return hasil;
    }

    // Method Untuk Membuat Bentuk Segitiga
    static void Segitiga(int input)
    {
        for (int i = 1; i <= input; i++)
        {
            for (int j = input; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    //Method Untuk Tampilan Salah Input
    static void WrongInput()
    {
        Console.Clear();
        Console.WriteLine("Maaf, Input Tidak Sesuai\nSilahkan Run Ulang...");
    }
}