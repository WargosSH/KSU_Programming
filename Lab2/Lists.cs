using System;
using System.Collections.Generic;

namespace @class
{
    //////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////
    class ListTeacher
    {
        List<Teacher> mList;
    
        ListTeacher()
        {
            mList = new List<Teacher>();
        }
        

        public void Add(Teacher inTeacher)
        {
            mList.Add(inTeacher);
        }  


        public void Print()
        {
            foreach(Teacher item in mList)
            {
                Console.WriteLine("-------------------------------");
                item.printInfo();
            }
            Console.WriteLine("-------------------------------\n");
        }

        public int Count()
        {
            return mList.Count;
        }

        public List<Teacher> List
        {
            get { return mList; }
            set { mList = value; }
        }
    }


    //////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////
    class ListStudent
    {
        List<Student> mList;
    
        ListStudent()
        {
            mList = new List<Student>();
        }
        

        public void Add(Student inStudent)
        {
            mList.Add(inStudent);
        }  


        public void Print()
        {
            foreach(Student item in mList)
            {
                Console.WriteLine("-------------------------------");
                item.printInfo();
            }
            Console.WriteLine("-------------------------------\n");
        }

        public int Count()
        {
            return mList.Count;
        }

        public List<Student> List
        {
            get { return mList; }
            set { mList = value; }
        }
    }


    //////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////
    class ListHuman
    {
        List<Human> mList;
    
        ListHuman()
        {
            mList = new List<Human>();
        }
        

        public void Add(Human inHuman)
        {
            mList.Add(inHuman);
        }  


        public void Print()
        {
            foreach(Human item in mList)
            {
                Console.WriteLine("-------------------------------");
                item.printInfo();
            }
            Console.WriteLine("-------------------------------\n");
        }

        public int Count()
        {
            return mList.Count;
        }

        public List<Human> List
        {
            get { return mList; }
            set { mList = value; }
        }
    }
}