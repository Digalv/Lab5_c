using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_c
{
    internal class NumberSystemCollection
    {
        private NumberSystem[] _systems;

        public NumberSystemCollection()
        {
            _systems = new NumberSystem[0];
        }

        public void AddSystem(NumberSystem system)
        {
            if (system is null)
            {
                throw new FormatException("Incorrect system parameter.");
            }
            else
            {
                Array.Resize(ref _systems, _systems.Length + 1);
                _systems[_systems.Length - 1] = system;
            }
        }

        public void DeleteSystem(int systemId)
        {
            if (systemId >= 0 && systemId < _systems.Length)
            {
                Array.Copy(_systems, systemId + 1, _systems, systemId, _systems.Length - systemId - 1);
                Array.Resize(ref _systems, _systems.Length - 1);
            }
        }

        public void EditSystem(uint index, NumberSystem system)
        {
            if (index >= 0 && index < Systems.Length && !(system is null))
            {
                Systems[index] = system;
            }
            else
            {
                throw new FormatException("Incorrect array index, or system parameter");
            }
        }

        public NumberSystem[] Systems => _systems;
    }
}
