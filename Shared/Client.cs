<<<<<<< HEAD:Core/Client.cs
﻿using BlueBank.Domain.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System;
>>>>>>> context:Shared/Client.cs


namespace BlueBank.Domain.Shared
{
    public class Client
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public string Cpf { get; set; }
        // public Account Account { get; set; }
        public Guid AccountId { get; set; }
        public Guid Id { get; set; }
   }
}
