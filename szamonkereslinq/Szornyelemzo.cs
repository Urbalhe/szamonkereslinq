using System;
using System.Collections.Generic;
using System.Text;

namespace szamonkereslinq
{
    internal class Szornyelemzo
    {
        private List<Szorny> szornyek;

        public Szornyelemzo()
        {
            var dbKezelo = new SzornyAdatbazis();
            this.szornyek = dbKezelo.Feltolt();
        }
        public List<string> OsszesSzornyNevListaba()
        {
            return szornyek
                .Select(k => k.Nev)
                .ToList();
        }




    }
}
