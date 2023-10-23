using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplicationNew;


namespace WindowsFormsApplicationNew
{
    //6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure Matrix as a guide).
    //Use private properties for the fields which must be of type “string”. The class file must have separate setters and getters,
    //add an appropriate IComparable for the Name attribute. Save the class as “Information.cs”.
    internal class Information : IComparable<Information>
    {
        private string Name;
        private string Category;
        private string Structure;
        private string Definition;
        public string GetName()
        {
            return Name;
        }
        public void SetName(string newName)
        {
            Name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(newName);
        }
        public string GetCategory()
        {
            return Category;
        }
        public void SetCategory(string newCategory)
        {
            Category = newCategory;
        }
        public string GetStructure()
        {
            return Structure;
        }
        public void SetStructure(string newStructure)
        {
            Structure = newStructure;
        }
        public string GetDefinition()
        {
            return Definition;
        }
        public void SetDefinition(string newDefinition)
        {
            if (string.IsNullOrEmpty(newDefinition))
                Definition = "None";
            else
                Definition = newDefinition;
        }
        public int CompareTo(Information compareInformation)
        {
            return Name.CompareTo(compareInformation.Name);
        }
    }
}
