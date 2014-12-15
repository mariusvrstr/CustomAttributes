
namespace CustomAttributes.CustomProperties
{
    using Contracts;
    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ValidationSetting : Attribute
    {
        public SettingEnum Setting { get; set; }

        public ValidationSetting(SettingEnum setting)
        {
            this.Setting = setting;
        }
    }
}
