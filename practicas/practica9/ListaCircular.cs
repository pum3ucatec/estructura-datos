    public class CircularList
    {
        private Node last;

        public CircularList()
        {
            last = null;
        }

        public void Insert(int data)
        {
            Node newNode = new Node(data);
            if (last == null)
            {
                last = newNode;
                last.Next = last;
            }
            else
            {
                newNode.Next = last.Next;
                last.Next = newNode;
                last = newNode;
            }
        }

        public void Show()
        {
            if (last == null)
            {
                Console.WriteLine("Empty list");
                return;
            }
            Node current = last.Next;
            do
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            } while (current != last.Next);
            Console.WriteLine("(start)");
        }

        public void Delete(int data)
        {
            if (last == null)
                return;

            Node current = last.Next;
            Node previous = last;
            bool found = false;
            do
            {
                if (current.Data == data)
                {
                    found = true;
                    break;
                }
                previous = current;
                current = current.Next;
            } while (current != last.Next);

            if (found)
            {
                if (current == last && current == last.Next)
                {
                    last = null;
                }
                else
                {
                    previous.Next = current.Next;
                    if (current == last)
                        last = previous;
                }
            }
        }
    }
