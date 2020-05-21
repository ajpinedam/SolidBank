using System;
namespace SolidBank
{
    public abstract class BaseAccount
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Number { get; set; }

        public decimal Amount { get; set; }

        public string Type { get; set; }
    }
}
