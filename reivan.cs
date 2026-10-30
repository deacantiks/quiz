using System;
using System.Collections;

namespace Quiz_Muhammad_Reivan
{
    internal class Program
    {
        
        static int kapasitas = 5;

        
        static void Push(ArrayList rak_buku)
        {
            if (rak_buku.Count < kapasitas)
            {
                Console.Write("Masukkan judul buku : ");
                string judul = Console.ReadLine();
                rak_buku.Add(judul);
                Console.WriteLine("Buku berhasil ditambahkan ke rak.");
            }
            else
            {
                Console.WriteLine("Kapasitas rak buku penuh!");
            }
        }

        
        static void Top(ArrayList rak_buku)
        {
            if (rak_buku.Count > 0)
            {
                Console.WriteLine("Buku teratas saat ini: [" + rak_buku[rak_buku.Count - 1] + "]");
            }
            else
            {
                Console.WriteLine("Rak buku kosong.");
            }
        }

        
        static void Pop(ArrayList rak_buku)
        {
            if (rak_buku.Count > 0)
            {
                Console.WriteLine("Buku [" + rak_buku[rak_buku.Count - 1] + "] telah diambil.");
                rak_buku.RemoveAt(rak_buku.Count - 1);
            }
            else
            {
                Console.WriteLine("Rak buku kosong, dak ado yang bisa diambil.");
            }
        }

        
        static void Tampil(ArrayList rak_buku)
        {
            if (rak_buku.Count > 0)
            {
                Console.WriteLine("Daftar Buku");
                for (int i = rak_buku.Count - 1; i >= 0; i--)
                {
                    Console.WriteLine("[" + rak_buku[i] + "]");
                }
            }
            else
            {
                Console.WriteLine("Rak buku masih kosong.");
            }
        }

        static void Main(string[] args)
        {
            ArrayList rak_buku = new ArrayList();
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear(); 
                Console.WriteLine("PROGRAM STACK BUKU");
                Console.WriteLine("1. Tambah Buku");
                Console.WriteLine("2. Lihat Buku Teratas");
                Console.WriteLine("3. Ambil Buku Teratas");
                Console.WriteLine("4. Tampilkan Semua Buku");
                Console.WriteLine("5. Jumlah Buku");
                Console.WriteLine("6. Keluar");
                Console.Write("\nPilih Menu : ");

               
                string input = Console.ReadLine();
                int pilihan;

                if (int.TryParse(input, out pilihan))
                {
                    Console.WriteLine(""); 

                    switch (pilihan)
                    {
                        case 1:
                            Push(rak_buku);
                            break;
                        case 2:
                            Top(rak_buku);
                            break;
                        case 3:
                            Pop(rak_buku);
                            break;
                        case 4:
                            Tampil(rak_buku);
                            break;
                        case 5:
                            Console.WriteLine("Jumlah buku saat ini: " + rak_buku.Count + " buku.");
                            break;
                        case 6:
                            Console.WriteLine("Terima kasih sudah menggunakan program ini.");
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Pilihan menu tidak tersedia.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Input dak valid Harap masukkan angko benar2.");
                }

              
                if (isRunning)
                {
                    Console.WriteLine("\nketik r...");
                    Console.ReadKey();
                }
            }
        }
    }
}
