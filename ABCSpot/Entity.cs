using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCSpot
{
    public class Hayvan
    {
        public string ID { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public string Renk { get; set; }
        public string Dogum { get; set; }
        public string TC { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Tur}";
        }

    }

    public class Sahip
    {
        public string TC { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }


        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }
    public class Randevular
    {
        public string randevuid{ get; set; }

        public string hayvanid { get; set; }
        public string vetid { get; set; }

        public string tarihsaatid { get; set; }

    }

    public class SaglikGecmisi
    {
        public string gecmisid { get; set; }
        public string hayvanid { get; set; }
        public string vetid { get; set; }
        public string tarihsaatid { get; set; }
        public string tani { get; set; }
        public string tedavi { get; set; }




    }

}
