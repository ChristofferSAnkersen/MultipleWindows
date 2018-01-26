using MultipleWindows.Models;
using MultipleWindows.Views;
using System.Collections.Generic;

namespace MultipleWindows.ViewModels
{
    public class MainViewModel
    {
        private DataManager dm;

        public Person ImportantPerson { get; set; }
        public List<Person> ImportantPersons { get; set; } 

        public MainViewModel()
        {
            // Instantiate DataManager, i.e. the Model layer of MVVM
            dm = new DataManager();

            // Populate MainViewModel properties
            ImportantPerson = dm.ImportantPerson;
            ImportantPersons = dm.ImportantPersons;
        }
    }
}
