using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_WPF
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Random rd = new Random();

            Data.Add(new Model() { XValue = 1, YValue1 = rd.Next(0, 100), YValue2 = rd.Next(100, 200), YValue3 = rd.Next(200, 300) });
            Data.Add(new Model() { XValue = 2, YValue1 = rd.Next(0, 100), YValue2 = rd.Next(100, 200), YValue3 = rd.Next(200, 300) });
            Data.Add(new Model() { XValue = 3, YValue1 = rd.Next(0, 100), YValue2 = rd.Next(100, 200), YValue3 = rd.Next(200, 300) });
            Data.Add(new Model() { XValue = 4, YValue1 = rd.Next(0, 100), YValue2 = rd.Next(100, 200), YValue3 = rd.Next(200, 300) });
            Data.Add(new Model() { XValue = 5, YValue1 = rd.Next(0, 100), YValue2 = rd.Next(100, 200), YValue3 = rd.Next(200, 300) });
        }
    }
}
