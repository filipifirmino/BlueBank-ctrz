<<<<<<< HEAD:Core/Entities/Account.cs
﻿using BlueBank.Domain.Core;
using BlueBank.Domain.Shared.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
=======
﻿using System;
>>>>>>> 1f480b5891663a1204e4e86bd1880cfcb10296d5:Shared/Account.cs

namespace BlueBank.Domain.Shared
{
    public class Account : Entity
    {
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public List<Transaction> Transactions { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
<<<<<<< HEAD:Core/Entities/Account.cs
        public AccountType Type { get; set; }
=======
<<<<<<< HEAD

        protected Account(Guid id, double balance, bool status)
        {
            Id = id;
=======
>>>>>>> 1f480b5891663a1204e4e86bd1880cfcb10296d5:Shared/Account.cs
        public Client Client { get; set; }
        public Guid ClientId { get; set; }

        public Account()
        {
<<<<<<< HEAD:Core/Entities/Account.cs
=======
            this.Id = id;
>>>>>>> context
>>>>>>> 1f480b5891663a1204e4e86bd1880cfcb10296d5:Shared/Account.cs
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Transactions = new List<Transaction>();
            Status = true;
        }
    }
}
