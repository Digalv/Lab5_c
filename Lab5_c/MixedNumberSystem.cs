using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_c
{
    internal class MixedNumberSystem : NumberSystem
    {
        private string positionalPart;
        private string nonPositionalPart;
        private bool allowNegativeNumbers;

        public string PositionalPart
        {
            get { return positionalPart; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    positionalPart = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public string NonPositionalPart
        {
            get { return nonPositionalPart; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    nonPositionalPart = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        public bool AllowNegativeNumbers
        {
            get { return allowNegativeNumbers; }
            set { allowNegativeNumbers = value; }
        }

        public MixedNumberSystem(string systemName, int baseValue, string description, string positionalPart, string nonPositionalPart, bool allowNegativeNumbers)
            : base(systemName, baseValue, description)
        {
            if (positionalPart != null)
                PositionalPart = positionalPart;
            else
                throw new ArgumentNullException(nameof(positionalPart));

            if (nonPositionalPart != null)
                NonPositionalPart = nonPositionalPart;
            else
                throw new ArgumentNullException(nameof(nonPositionalPart));

            AllowNegativeNumbers = allowNegativeNumbers;
        }

        public override string ToString()
        {
            return $"Смешанная система счисления\n{base.ToString()}\nПозиционная часть: {PositionalPart}\nНепозиционная часть: {NonPositionalPart}\nДопустимость отрицательных чисел: {AllowNegativeNumbers}";
        }
    }
}
