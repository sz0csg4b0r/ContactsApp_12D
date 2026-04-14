<<<<<<< HEAD
﻿using SQLite;
using System;
=======
﻿using System;
>>>>>>> 38f51cfa4c2b1d6ac715347978e8316e455347c3
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contact
    {
<<<<<<< HEAD
        
        [PrimaryKey, AutoIncrement]
=======
        // sqlite primarykey, autoinctrement
>>>>>>> 38f51cfa4c2b1d6ac715347978e8316e455347c3
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



    }
}
