
namespace CustomAttributes.Contracts
{
    using System.Linq;
    using CustomProperties;

    public abstract class EntityBase
    {
        private readonly bool _monitor;

        protected EntityBase()
        {
            var attributes = this.GetType().GetCustomAttributes(typeof(MonitorChanges), true);
            if (attributes.Any())
            {
                this._monitor = true;
            }
        }
        
        public bool HasChanges { get; set; }
        public bool ValidateMandatoryFields()
        {
            var mandatoryItems = this.GetType().GetProperties()
                .Where(prop => prop.HasValidationSettingAttribute(SettingEnum.Required));

            return mandatoryItems.All(property => property.GetValue(this) != null);
        }
        
        protected void OnPropertyChanged<T>(T original, T updated)
        {
            if (!_monitor || (updated == null && original == null) || (updated != null && updated.Equals(original))) return;
            
            this.HasChanges = true;
        }
    }
}
