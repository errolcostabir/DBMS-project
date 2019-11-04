using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbms
{
    class passclass
    {
        static string Uname;
        static string Id;
        static int test;
        static string sid;
        static string tid;
        static string question;
        static string answers;
        public static string uname
        {
            get
            {
                return Uname;
            }
            set
            {
                Uname = value;
            }
        }

        public static string id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public static int Test
        {
            get
            {
                return test;
            }
            set
            {
                test = value;
            }
        }

        public static string SID
        {
            get
            {
                return sid;
            }
            set
            {
                sid = value;
            }
        }
        public static string TID
        {
            get
            {
                return tid;
            }
            set
            {
                tid = value;
            }
        }
        public static string Quetion
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }
        public static string Answers
        {
            get
            {
                return answers;

            }
            set
            {
                answers = value;
            }
        }
    }
}
