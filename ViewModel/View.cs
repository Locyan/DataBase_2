using DataModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ViewModel
{
    public class View : DataElement
    {

        public static RoutedCommand AddCommand  {get; set }
        public ObservableCollection<RecordDescription>? RecordDescriptions { get; set; }
    }
}