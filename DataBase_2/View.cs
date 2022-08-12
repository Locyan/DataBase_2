using DataModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DataBase_2
{
    public class View : DataElement
    {
        

        public ObservableCollection<RecordDescription>? Records { get; set; }= new ObservableCollection<RecordDescription>();
        public List <Genre> Genres { get => Enum.GetValues(typeof(Genre)).Cast<Genre>().ToList(); }
    }
}
