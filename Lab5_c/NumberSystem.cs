using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_c
{
    internal class NumberSystem
    {
        protected string _systemName;
        protected int _baseValue;
        protected string _description;

        public string SystemName
        {
            get => _systemName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _systemName = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect system name.");
                }
            }
        }

        public int BaseValue
        {
            get => _baseValue;
            set
            {
                if (value > 0)
                {
                    _baseValue = value;
                }
                else
                {
                    throw new FormatException("Incorrect base value.");
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _description = value.Trim();
                }
                else
                {
                    throw new FormatException("Incorrect description.");
                }
            }
        }

        public NumberSystem(string systemName, int baseValue, string description)
        {
            SystemName = systemName;
            BaseValue = baseValue;
            Description = description;
        }

        public override string ToString()
        {
            return $"Название: {SystemName}, Основание: {BaseValue}, Описание: {Description}";
        }
    }
}
