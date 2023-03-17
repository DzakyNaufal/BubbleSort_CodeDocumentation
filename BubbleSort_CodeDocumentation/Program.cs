using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleShort
{
    /// <summary>
    /// main class
    /// </summary>
    class Program
    {
        // Deklrasi array int dengan ukuran 20
        /// <param name="a">tempat untuk memasukkan array sesuai angka yang diinginkan</param>
        private int[] a = new int[20];

        /// <summary>
        /// Deklarasi variabel int untuk menyimpan banyaknya data yang disimpan pada array
        /// </summary>
        private int n;

        /// <summary>
        /// fungsi method ini untuk menerima angka yang dimasukkan
        /// </summary>
        public void read()
        {
            ///menerima angka untuk menentukan banyaknya data yang disimpan pada array 
            while (true)
            {
                Console.Write("masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("-----------------------");

            /// Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }

        }

        /// Fungsi ini akan Menampilkan array yang telah tersusun
        public void display()
        {        
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                ///pada pass i, dibandingkan n - 1 elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n; j++)
                {
                    if (a[j] > a[j + 1]) /// jika elmen tidak dalam urutan yang benar
                    {
                        /// tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ///membuat objek dari kelas BubbleSort
            Program mylist = new Program();

            ///tujuannya untuk pemanggilan fungsi untuk menerima elemen array
            mylist.read();

            ///pemanggilan fungsi untuk mengurutkan array 
            mylist.BubbleSortArray();

            ///pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            ///keluar
            Console.WriteLine("\n\n Tekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }

}