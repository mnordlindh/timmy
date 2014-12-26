using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {

    public interface IPersistor<T> {
        void Add(TimeReport timeReport);
    }

    public class ListPersistor<T> : IPersistor<T> {
        private ICollection<TimeReport> _collection;

        public ListPersistor(ICollection<TimeReport> collection) {
            _collection = collection;
        }

        public void Add(TimeReport timeReport) {
            if(timeReport == null){
                throw new ArgumentNullException("timeReport");
            }
            _collection.Add(timeReport);
        }
    }
}
