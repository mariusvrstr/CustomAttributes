using System;
using System.Linq;
using System.Reflection;
using CustomAttributes.CustomProperties;

namespace CustomAttributes.Contracts
{
    public static class AttributeHelper
    {
        public static bool HasValidationSettingAttribute(this ICustomAttributeProvider provider, SettingEnum setting)
        {
            var atts = provider.GetCustomAttributes(typeof(ValidationSetting), true);

            return atts.Length != 0 &&
                atts.Any(att => ((ValidationSetting) att).Setting == setting);
        }
    }
}
