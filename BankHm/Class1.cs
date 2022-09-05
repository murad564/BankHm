using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHm

{
    class Card
    {
        public string _pan { get; set; }
        public string _pin { get; set; }
        public string _cvc { get; set; }
        public string _dateactivty { get; set; }
        public decimal _balance { get; set; }

        public Card() { }

        public Card(string pin, string pan, string cvc, string dateact, decimal balance)
        {
            _pin = pin;
            _pan = pan;
            _cvc = cvc;
            _dateactivty = dateact;
            _balance = balance;
        }



    }
}