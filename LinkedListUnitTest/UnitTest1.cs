using Kædet_list_Datastruktur;

namespace LinkedListUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add_first_int()
        {
            object data = 1;
            Element element = null;
            Element el = new(data, element);

            Assert.Equal(el.Data, 1);
            Assert.Equal(el.Next, element);
        }
        [Fact]
        public void Add_first_string()
        {
            object data = "a";
            Element element = null;
            Element el = new(data, element);

            Assert.Equal(el.Data, "a");
            Assert.Equal(el.Next, element);
        }
        [Fact]
        public void AddAnother()
        {
            object data = 1;
            Element element = new(data, new Element(1));

            Element newElement = new(5, element);
            //newElement.Next = element;

            Assert.Equal(newElement.Next, element);
        }


        [Fact]
        public void Remove_first()
        {
            Element firstElement = new Element(1);

            Element addedElement = new(1, new Element(1));
            firstElement.Next = addedElement;
            firstElement.Next = null;
            Assert.Equal(firstElement.Next, null);
        }
        [Fact]
        public void Count()
        {
            Element firstElement = new Element(1, null);
            Element firstElement2 = new Element(2, null);
            Element firstElement3 = new Element(3, null);
            firstElement.Next = firstElement2;
            firstElement2.Next = firstElement3;

            int total = 0;
           if(firstElement.Next !=null ) 
            {
                total++; 
                if (firstElement2.Next != null )
                {
                    total++;
                    
                    if(firstElement3.Next != null )
                    {
                        total++;
                    }
                }
            }

            Assert.Equal(total,2);

        }
        [Fact]
        public void To_String()
        {
            Element firstElement = new Element(1, null);
            Element firstElement2 = new Element(2, null);
            Element firstElement3 = new Element(3, null);
            firstElement.Next = firstElement2;
            firstElement2.Next = firstElement3;
            
            string testString = firstElement.Data.ToString() + firstElement2.Data.ToString() + firstElement3.Data.ToString();
            Assert.Equal(testString, "123");
        }
        [Fact]
        public void Sort()
        {
            Element firstElement3 = new Element(2, null);
            Element firstElement2 = new Element(7, firstElement3);
            Element firstElement = new Element(1, firstElement2);

            int c = Convert.ToInt32(firstElement3.Data);
            int b = Convert.ToInt32(firstElement2.Data);
            int a = Convert.ToInt32(firstElement.Data);

            int mathResult = Math.Max(a, Math.Max(b, c));
            int mathResult2 = Math.Max(a, Math.Min(b, c));
            int mathResult3 = Math.Min(a, Math.Min(b, c));
            string result = $"{mathResult}, {mathResult2}, {mathResult3}";

            Assert.Equal(result, "7, 2, 1");

        }
    }
}