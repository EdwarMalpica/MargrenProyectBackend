using Margren.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Margren.Domain.Entities
{
    public class Person
    {
        public int id_person { get; set; }
        public PersonName first_name { get;private set; }
        public PersonName last_name { get;private set; }
        public Gender gender { get;private set; }
        public TypeDocument type_document { get;private set; }
        public NumDocument num_document { get;private set; }

        public Person()
        {

        }
        public Person(int id)
        {
            this.id_person = id;
        }
        public void setId(int id)
        {
            this.id_person = id;
        }
        public void setFirstName(PersonName name)
        {
            this.first_name = name;
        }
        public void setLastName(PersonName name)
        {
            this.last_name = name;
        }
        public void setGender(Gender gender)
        {
            this.gender = gender;
        }
        public void setTypeDocument(TypeDocument typeDocument)
        {
            this.type_document = typeDocument;
        }
        public void setNumDocument(NumDocument numDocument)
        {
            this.num_document = numDocument;
        }

    }
}
