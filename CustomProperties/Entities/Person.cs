using System;
using CustomAttributes.Contracts;
using CustomAttributes.CustomProperties;

namespace CustomAttributes.Entities
{
    [MonitorChanges]
    public class Person : EntityBase
    {
        private string _name;
        private string _surname;
        private DateTime _birthDay;

        [ValidationSetting(SettingEnum.Required)]
        public string Name {
            get { return this._name; }
            set
            {
                this.OnPropertyChanged(_name, value);
                this._name = value;
            }}

        [ValidationSetting(SettingEnum.Required)]
        public string Surname
        {
            get { return this._surname; }
            set
            {
                this.OnPropertyChanged(_surname, value);
                this._surname = value;
            }
        }
        
        public DateTime BirthDay 
        {
            get { return this._birthDay; }
            set
            {
                this.OnPropertyChanged(_birthDay, value);
                this._birthDay = value;
            }
        }
    }
}
