using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_c
{
    internal class NonPositionalNumberSystem : NumberSystem
    {
        private string _representationType;
        private bool _isNegativeAllowed;

        public string RepresentationType
        {
            get => _representationType;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _representationType = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect representation type.");
                }
            }
        }

        public bool IsNegativeAllowed
        {
            get => _isNegativeAllowed;
            set => _isNegativeAllowed = value;
        }

        public NonPositionalNumberSystem(string systemName, int baseValue, string description, string representationType, bool isNegativeAllowed)
            : base(systemName, baseValue, description)
        {
            RepresentationType = representationType;
            IsNegativeAllowed = isNegativeAllowed;
        }

        public override string ToString()
        {
            return $"Непозиционная система счисления\n{base.ToString()}\nТип представления: {RepresentationType}, Допускается отрицательное значение: {IsNegativeAllowed}";
        }
    }
}
