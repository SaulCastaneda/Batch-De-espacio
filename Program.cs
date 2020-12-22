using System;
using System.IO;
namespace PruebaDisco
{
    class Program
    {
        static void Main(string[] args)
        { //29-07-2020
            DriveInfo[] Discos = DriveInfo.GetDrives();
            foreach (DriveInfo d in Discos)
            { 
                
                Console.WriteLine("Disco {0}", d.Name);
                Console.WriteLine("Tipo de disco:{0}", d.DriveType);

                if (d.IsReady == true)
                {
                    Double disponible = d.AvailableFreeSpace / 1073741824;
                    Double free = d.TotalFreeSpace / 1073741824;
                    Double total = d.TotalSize / 1073741824;

                    Console.WriteLine(
                                      "  Espacio disponible para el uso  actual :{0, 15} GB",
                                    disponible);

                    Console.WriteLine(
                        "  Total disponible:          {0, 15} GB",
                        free);

                    Console.WriteLine(
                        "  Total del disco:            {0, 15} GB ",
                       total);
                    if (disponible== free) {
                        Console.WriteLine("EL DISCO ESTA LLENO ");
                    }

                }

            }

        }
    }
}
