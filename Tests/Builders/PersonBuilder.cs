
using CustomAttributes.Entities;

namespace Tests.Builders
{
    using System;

    public class PersonBuilder : Person
    {
        public PersonBuilder Anonymous()
        {
            this.Surname = "Jhonson";
            this.BirthDay = new DateTime(1986, 03, 18);

            return this;
        }

        public PersonBuilder Peter()
        {
            this.Name = "Peter";
            this.Surname = "Jhonson";
            this.BirthDay = new DateTime(1986, 03, 18);

            return this;
        }

        public Person Build()
        {
            this.HasChanges = false;
            return this;
        }
    }
}
