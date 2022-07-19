using System;
using System.Collections.Generic;
using System.Text;

namespace GameShopSOLID
{
    public class IntInput
    {
        private string input;
        //private Lazy<int> value = new Lazy<int>();
        public Lazy<int> Value { get; } = new Lazy<int>();
        public void ReadInput()
        {
            input = Console.ReadLine();
        }
        public bool ValidateInput()
        {
            if (String.IsNullOrWhiteSpace(input)) return false;
            int i = 0;
            if(Int32.TryParse(input, out i))
            {
                //Value.Value = i;      ne moze jer je readonly
                return true;
            }
            return false;
            
        }

    }
}
