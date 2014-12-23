using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timmy.Domain {
    public class User {
        public string Id { get; private set; }

        public User(string id) {
            Id = id;
        }
    }
}