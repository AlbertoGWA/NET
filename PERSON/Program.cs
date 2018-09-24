using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSON
{
    public class person
    {
        public string _name { get; set; }
        public string _lastname { get; set; }
        public int _dni { get; set; }
        public DateTime _birthdate { get; set; }
        public string _direcction { get; set; }
        public int _phone { get; set; }
        public string _sexo { get; set; }
        public string _email { get; set; }
        public string _civilStatus { get; set; }
        public string _country { get; set; }

        public person(person person)
        {
            this._name = person._name;
            this._lastname = person._lastname;
            this._dni = person._dni;
            this._birthdate = person._birthdate;
            this._direcction = person._direcction;
            this._phone = person._phone;
            this._sexo = person._sexo;
            this._email = person._email;
            this._civilStatus = person._civilStatus;
            this._country = person._country;
        }
        public person() { }


        public string ToString()
        {
            return "person  {\n" +
                        $"\t name        : {_name}\n" +
                        $"\t lastname    : {_lastname}\n" +
                        $"\t dni         : {_dni}\n" +
                        $"\t birthdate   : {_birthdate}\n" +
                        $"\t direcction  : {_direcction}\n" +
                        $"\t phone       : {_phone}\n" +
                        $"\t sexo        : {_sexo}\n" +
                        $"\t email       : {_email}\n" +
                        $"\t civilStatus : {_civilStatus}\n" +
                        $"\t country     : {_country}\n" +
                        "\t}\n";
        }
        static void Main(string[] args)
        {
        }
    }
}
