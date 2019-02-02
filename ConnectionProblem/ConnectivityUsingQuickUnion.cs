using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionProblem
{
    public class ConnectivityUsingQuickUnion
    {
        private int[] _elementsInNetwork;
        public ConnectivityUsingQuickUnion(int NumberOfElements)
        {
            _elementsInNetwork = new int[NumberOfElements];
            for (int elementCounter = 0; elementCounter < NumberOfElements; elementCounter++)
            {
                _elementsInNetwork[elementCounter] = elementCounter;
            }
        }

        public ConnectivityUsingQuickUnion() : this(10)
        {

        }

        public bool AreElementsConnected(int FirstElement, int SecondElement)
        {
            return GetRootOfElement(FirstElement) == GetRootOfElement(SecondElement);
        }

        public void ConnectElements(int FirstElement, int SecondElement)
        {
            int rootOfFirstElement = GetRootOfElement(FirstElement);
            int rootOfSecondElement = GetRootOfElement(SecondElement);
            _elementsInNetwork[rootOfFirstElement] = rootOfSecondElement;
        }
        private int GetRootOfElement(int indexOfElement)
        {
            while (indexOfElement != _elementsInNetwork[indexOfElement])
            {
                indexOfElement = _elementsInNetwork[indexOfElement];
            }
            return indexOfElement;
        }
    }
}
