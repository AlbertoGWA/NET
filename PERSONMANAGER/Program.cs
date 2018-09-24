using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using PERSON;

namespace PERSONMANAGER
{
    class personManager
    {
        private List<person> _persons = new List<person>();
        protected XDocument _document;
        public person select(person person)
        {
            return (from p in _persons where p._dni == person._dni select p).SingleOrDefault();
        }
        public List<person> selectAll()
        {
            return _persons;
        }
        public void insert(person person)
        {
            _persons.Add(person);
        }
        public void update(person person)
        {
            var persons = (from p in _persons where p._dni == person._dni select p).SingleOrDefault();
            persons = person;
        }

        public void delete(person person)
        {
            var persons = (from p in _persons where p._dni == person._dni select p).SingleOrDefault();
            _persons.Remove(persons);
        }

        public void exportXML(string path)
        {
            XElement root = new XElement("Persons");
            _document = new XDocument(root);
            _persons.ToList().ForEach(ps => {
                XElement child = new XElement("Person",
                 new XAttribute("Id", ps._dni),
                 new XElement("Name", ps._name),
                 new XElement("Lastname", ps._lastname),
                 new XElement("Dni", ps._dni),
                 new XElement("Direcction", ps._direcction),
                 new XElement("Birthdate", ps._birthdate),
                 new XElement("Phone", ps._phone),
                 new XElement("Sexo", ps._sexo),
                 new XElement("Email", ps._email),
                 new XElement("CivilStatus", ps._civilStatus),
                 new XElement("Country", ps._country)
                );
                root.Add(child);
            });
            _document.Save(path);
        }
        public void importXML(string path)
        {
            _document = XDocument.Load(path);
            _persons = (from p in _document.Elements("Persons").Elements("Person")
                        select new person
                        {
                            _name = p.Element("Name").Value,
                            _lastname = p.Element("Lastname").Value,
                            _dni = Convert.ToInt32(p.Element("Dni").Value),
                            _direcction = p.Element("Direcction").Value,
                            _birthdate = Convert.ToDateTime(p.Element("Birthdate").Value),
                            _phone = Convert.ToInt32(p.Element("Phone").Value),
                            _sexo = p.Element("Sexo").Value,
                            _email = p.Element("Email").Value,
                            _civilStatus = p.Element("CivilStatus").Value,
                            _country = p.Element("Country").Value
                        }).ToList();
        }
        public void exportNotepad(string path) {
            using (StreamWriter write = new StreamWriter(path))
            {
                _persons.ToList().ForEach(ps => {
                    write.WriteLine(ps._name);
                    write.WriteLine(ps._lastname);
                    write.WriteLine(ps._dni);
                    write.WriteLine(ps._direcction);
                    write.WriteLine(ps._birthdate);
                    write.WriteLine(ps._phone);
                    write.WriteLine(ps._sexo);
                    write.WriteLine(ps._email);
                    write.WriteLine(ps._civilStatus);
                    write.WriteLine(ps._country);
                });
        }
    }
        public void importNotepad(string path) {
            using (StreamReader sr = new StreamReader(path))
            {
                string line = string.Empty;
                int count = 0;
                List<string> data = new List<string>();
                List<string[]> datas = new List<string[]>();
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    data.Add(line);
                    if (count == 10)
                    {
                        string[] arrayData = data.ToArray();
                        datas.Add(arrayData);
                        data.Clear();
                        count = 0;
                    }
                }
                
               _persons = datas.Select(d => new person {
                   _name = d[0],
                   _lastname = d[1],
                   _dni = Convert.ToInt32(d[2]),
                   _direcction = d[3],
                   _birthdate = Convert.ToDateTime(d[4]),
                   _phone = Convert.ToInt32(d[5]),
                   _sexo = d[6],
                   _email = d[7],
                   _civilStatus = d[8],
                   _country = d[9]
               }).ToList();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
