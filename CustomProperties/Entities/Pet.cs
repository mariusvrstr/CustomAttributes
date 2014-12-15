using CustomAttributes.Contracts;
using CustomAttributes.CustomProperties;

namespace CustomAttributes.Entities
{
    public class Pet : EntityBase
    {
        [ValidationSetting(SettingEnum.Required)]
        public string Name { get; set; }

        public string Species { get; set; }

        public Person Owner { get; set; }
    }
}
