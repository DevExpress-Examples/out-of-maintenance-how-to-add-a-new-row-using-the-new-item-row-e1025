using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Linq;

namespace NewItemRow {
    public class Item {
        public string Text { get; set; }
        public int Number { get; set; }
        public bool Boolean { get; set; }
    }

    public class MainViewModel : ViewModelBase {
        public List<Item> Items {
            get { return GetValue<List<Item>>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Items = GetData();
        }

        static List<Item> GetData() {
            return Enumerable.Range(0, 5).Select(x => new Item { Text = "Text" + x, Number = x, Boolean = x % 2 == 0 }).ToList();
        }
    }
}
