using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13_DVD_Kolekcija
{
    class Producent
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Email { get; set; }

        public Producent(int id, string naziv, string email)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Email = email;
        }
        public override string ToString()
        {
            return this.Id + "           " + this.Naziv + "           " + this.Email;
        }
    }
}
