using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kædet_list_Datastruktur
{
    public class LinkedList
    {
        public Element currentFirstElement { get; private set; }

        public void Add_first(Element newElement)
        {
            if (currentFirstElement != null)
            {
                newElement.Next = currentFirstElement;
            }
            currentFirstElement = newElement;
        }

        public void Remove()
        {
            if (currentFirstElement.Next != null)
            {
                currentFirstElement = currentFirstElement.Next;
            }
            else
            {
                currentFirstElement = null;
            }
        }

        public void RemoveElementWithValue(object value)
        {
            Element tempElement = currentFirstElement;
            Element previousElement = null;
            int valueRemove = Convert.ToInt32(value);

            while (tempElement != null)
            {
                if (Convert.ToInt32(tempElement.Data) == valueRemove)
                {
                    if (previousElement != null)
                    {
                        previousElement.Next = tempElement.Next;
                    }
                    else
                    {
                        currentFirstElement = tempElement.Next;
                    }
                    return;
                }
                previousElement = tempElement;
                if (tempElement.Next == null)
                    throw new NullReferenceException();

                tempElement = tempElement.Next;
            }
        }

        public int Count()
        {
            int result = 0;
            Element tempElement = currentFirstElement;
            while (tempElement.Next != null)
            {
                result++;
                tempElement = tempElement.Next;
            }
            return result += 1;
        }

        public string To_String()
        {
            string result = "";

            Element tempElement = currentFirstElement;

            int count = Count();
            for (int i = 0; i < count; i++)
            {
                if (i < count - 1)
                {
                    result += $"{tempElement.Data}, ";
                }
                else
                {
                    result += $"{tempElement.Data}";
                }
                if (tempElement.Next != null)
                {
                    tempElement = tempElement.Next;
                }
            }
            return result;
        }
    }
}
