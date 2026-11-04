// Name: Ahmed Mohamed Elmashad
// Student ID: 225106090

using System;

namespace Cse111Task1
{
    public class StudentList
    {
        public Student? First;
        public Student? Last;
        public int Count;

        public void AddFront(int id)
        {
            Student student = new Student(id);
            student.Next = First;
            First = student;

            if (Last == null)
                Last = student;

            Count++;
        }

        public void AddEnd(int id)
        {
            Student student = new Student(id);

            if (Last == null)
            {
                First = student;
                Last = student;
            }
            else
            {
                Last.Next = student;
                Last = student;
            }

            Count++;
        }

        public bool Remove(int id)
        {
            if (First == null)
                return false;

            if (First.Id == id)
            {
                First = First.Next;
                Count--;

                if (First == null)
                    Last = null;

                return true;
            }

            Student current = First;
            while (current.Next != null)
            {
                if (current.Next.Id == id)
                {
                    if (current.Next == Last)
                        Last = current;

                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void Reverse()
        {
            Student? previous = null;
            Student? current = First;
            Last = First;

            while (current != null)
            {
                Student? next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            First = previous;
        }

        public void Print()
        {
            Student? current = First;
            while (current != null)
            {
                Console.Write(current.Id);
                if (current.Next != null)
                    Console.Write(" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
