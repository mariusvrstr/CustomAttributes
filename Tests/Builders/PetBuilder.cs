
using CustomAttributes.Entities;

namespace Tests.Builders
{
    public class PetBuilder : Pet
    {
        public PetBuilder()
        {
        }

        public PetBuilder(Person owner)
        {
            this.Owner = owner;
        }

        public PetBuilder Anonymous()
        {
            this.Species = "Cat";

            return this;
        }

        public PetBuilder Draco()
        {
            this.Name = "Draco";
            this.Species = "Bearded Dragon";

            return this;
        }

        public Pet Build()
        {
            this.HasChanges = false;
            return this;
        }
    }
}
