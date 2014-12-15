using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tests.Builders;

namespace Tests
{
    [TestClass]
    public class CustomPropertyTests
    {
        [TestMethod]
        public void TestMandatoryFieldWithoutDataShouldFailValidation()
        {
            var owner = new PersonBuilder().Anonymous().Build();
            var pet = new PetBuilder(owner).Anonymous().Build();

            Assert.IsFalse(owner.ValidateMandatoryFields(), "Validate must fail if a mandatory field is not supplied");
            Assert.IsFalse(pet.ValidateMandatoryFields(), "Validate must fail if a mandatory field is not supplied");
        }

        [TestMethod]
        public void TestMandatoryFieldsProvidedShouldPassValidation()
        {
            var owner = new PersonBuilder().Peter().Build();
            var pet = new PetBuilder(owner).Draco().Build();

            Assert.IsTrue(owner.ValidateMandatoryFields(), "Validation must pass for entity with mandatory fields added");
            Assert.IsTrue(pet.ValidateMandatoryFields(), "Validation must pass for entity with mandatory fields added");
        }

        [TestMethod]
        public void ClasshWithoutMonitorAttributeShouldNotShowChanges()
        {
            var pet = new PetBuilder().Draco().Build();
            pet.Name = "Rose";

            Assert.IsFalse(pet.HasChanges);
        }

        [TestMethod]
        public void ClasshWithMonitorAttributeShouldShowChanges()
        {
            var peter = new PersonBuilder().Peter().Build();
            peter.Name = "Rose";

            Assert.IsTrue(peter.HasChanges);
        }
    }
}
