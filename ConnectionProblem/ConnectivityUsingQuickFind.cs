
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics.Contracts;

namespace ConnectionProblem
{
    public class ConnectivityUsingQuickFind
    {
        private int[] _elementsInNetwork;
        public ConnectivityUsingQuickFind(int NumberOfElements)
        {
            _elementsInNetwork = new int[NumberOfElements];
            for (int elementCounter = 0; elementCounter < NumberOfElements; elementCounter++)
            {
                _elementsInNetwork[elementCounter] = elementCounter;
            }
        }
        public ConnectivityUsingQuickFind() : this(10)
        {

        }

        public bool IsConnected(int FirstElement, int SecondElement)
        {
            return _elementsInNetwork[FirstElement] == _elementsInNetwork[SecondElement];
        }

        public void ConnectElements(int FirstElement, int SecondElement)
        {
            //Contract.Requires(FirstElement >= 0 && FirstElement < _elementsInNetwork.Length,"Either first or second element is invalid");

            if (FirstElement <0 || FirstElement > _elementsInNetwork.Length )
            {
                throw new ArgumentException("Invalid first element");
            }

            if (SecondElement < 0 || SecondElement > _elementsInNetwork.Length)
            {
                throw new ArgumentException("Invalid second element");
            }

            int firstElement = _elementsInNetwork[FirstElement];
            int secondElement = _elementsInNetwork[SecondElement];
            
            for (int elemnetCounter = 0; elemnetCounter < _elementsInNetwork.Length; elemnetCounter++)
            {
                if (_elementsInNetwork[elemnetCounter] == firstElement)
                {
                    _elementsInNetwork[elemnetCounter] = secondElement;
                }
            }
        }
    }
}
