using System;
using System.Collections.Generic;
using System.Text;

namespace hw15
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{Name} | Score: {Score} | Active: {IsActive}";
        }
    }
}
