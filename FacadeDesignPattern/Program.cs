using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            
        }
    }
    public class Islemci
    {
        public void IslemciIs1()
        {

        }
        public void IslemciIs2()
        {

        }
    }
    public class RAM
    {
        public void RamIslem1()
        {

        }
        public void RamIslem2()
        {

        }
    }
    public class Harddisk
    {
        public void HarddiskIslem1()
        {

        }
        public void HarddiskIslem2()
        {

        }
    }
    public class Bilgisayar
    {
        public Islemci Islemci { get; set; }
        public RAM Ram { get; set; }
        public Harddisk Harddisk { get; set; }
    }

}
