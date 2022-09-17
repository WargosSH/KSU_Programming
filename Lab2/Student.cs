using System;
using System.Collections.Generic;


namespace @class
{
    class Student : Human
    {
        private int mCourse;     // 1..5
        private string mGroup;   // xx-xx
        private string mFacultet;   // XXXXXXX

        Student(
            string inName, 
            string inSurname, 
            int inAge, 
            double inHeight, 
            double inWeight, 
            bool inHabbits, 
            Nation inNation, 
            Address inAddress,
            int inCourse,
            string inGroup,
            string inFacultet) 
            :
            base(inName, inSurname, inAge, inHeight, inWeight, inHabbits, inNation, inAddress)
        {
            mCourse = inCourse;
            mGroup = inGroup;
            mFacultet = inFacultet;
        }

        Student() : base()
        {
            mCourse = 1;
            mGroup = "00-00";
            mFacultet = "Undefined";
        }


        public override string printInfo()
        {
            base.printInfo();
            Console.WriteLine("Course: " + mCourse.ToString());
            Console.WriteLine("Group: " + mGroup);
            Console.WriteLine("Facultet: " + mFacultet);
            Console.WriteLine("GlobalGroup: " + mCourse.ToString() + mGroup);
        }


        public int Course 
        {
            get { return mCourse; }
            set { mCourse = value; }
        }


        public string Group 
        {
            get { return mGroup; }
            set { mGroup = value; }
        }


        public string Facultet 
        {
            get { return mFacultet; }
            set { mFacultet = value; }
        }
    }
}
