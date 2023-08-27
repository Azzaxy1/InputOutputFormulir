using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \t\t        FORMULIR PENDAFTARAN SEKOLAH ");
            Console.WriteLine();

            Console.Write(" Nama Lengkap \t\t\t : ");
            string nama = Console.ReadLine();

            Console.Write(" Tempat Dan Tanggal Lahir     \t : ");
            string tempatdantanggallahir = Console.ReadLine();

            Console.Write(" Jenis Kelamin \t\t\t : ");
            string jeniskelamin = Console.ReadLine();

            Console.Write(" No HP \t\t\t\t : ");
            string nohp = Console.ReadLine();

            Console.Write(" Alamat \t\t\t : ");
            string alamat = Console.ReadLine();

            Console.Write(" Kewarganegaraan \t\t : ");
            string kewarganegaraan = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(" Nama Lengkap \t\t\t : " + nama);
            Console.WriteLine(" TTL \t\t\t\t : " + tempatdantanggallahir);
            Console.WriteLine(" Jenis Kelamin \t\t\t : " + jeniskelamin);
            Console.WriteLine(" No HP \t\t\t\t : " + nohp);
            Console.WriteLine(" Alamat \t\t\t : " + alamat);
            Console.WriteLine(" Kewarganegaraan \t\t : " + kewarganegaraan);

            Console.WriteLine();
            Console.WriteLine(" \t\t\t\t TERIMAKASIH");

            Console.ReadKey();
        }
    }
}
