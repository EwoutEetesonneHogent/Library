using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Models
{

        public class Checkout
        {
            public int Id { get; set; }
            public DateTime LendingDate { get; }
            public DateTime DueDate { get; }
            public DateTime? ReturnedOn { get; set; }
            public bool IsReturned => ReturnedOn.HasValue;

            public Checkout(int id, DateTime lendingDate)
            {
                if (lendingDate > DateTime.Today)
                    throw new ArgumentException("Lending date cannot be in the future.");

                Id = id;
                LendingDate = lendingDate;
                DueDate = lendingDate.AddDays(14);
            }
        }
    }
