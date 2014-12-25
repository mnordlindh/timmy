using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
        public interface IQuery<TSource> {
        bool Match(TSource item);
    }
}
