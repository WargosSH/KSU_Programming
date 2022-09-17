using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Teacher : Human
    {
        string mWorkPlace;
        string mQualification;
        string mFacultet;
        ListStudent mList;

        Teacher(
            string inName, 
            string inSurname, 
            int inAge, 
            double inHeight, 
            double inWeight, 
            bool inHabbits, 
            Nation inNation, 
            Address inAddress,
            string inWorkPlace,
            string inQualification,
            string inFacultet )
            :
            base(inName, inSurname, inAge, inHeight, inWeight, inHabbits, inNation, inAddress)
        {
            mWorkPlace = inWorkPlace;
            mQualification = inQualification;
            mFacultet = inFacultet;
            mList = new ListStudent();
        }


        Teacher() 
            : 
            base()
        {
            mWorkPlace = "Undefined";
            mQualification = "Undefined";
            mFacultet = "Undefined";
            mList = new ListStudent();
        }


        public override string printInfo()
        {
            base.printInfo();
            Console.WriteLine("Work Place: " + mWorkPlace);
            Console.WriteLine("Qualification: " + mQualification);
            Console.WriteLine("Facultet: " + mFacultet);
            Console.WriteLine("Students: ");
            mList.Print();
        }


        public int WorkPlace 
        {
            get { return mWorkPlace; }
            set { mWorkPlace = value; }
        }


        public string Qualification 
        {
            get { return mQualification; }
            set { mQualification = value; }
        }


        public string Facultet 
        {
            get { return mFacultet; }
            set { mFacultet = value; }
        }
        

        public ListStudent List
        {
            get { return mList; }
            set { mList = value; }
        }
    }
}
