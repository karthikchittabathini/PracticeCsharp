using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class UserBO
    {
        //Declaring User Registration Variables  
        private int _BloggerID;
        private string _BloggerName;
        private string _BloggerSubject;
        private int _BlogID;
        private string _BlogName;
        private string _BlogContent;
        private DateTime _BlogDate;

        public int BloggerID
        {
            get
            {
                return _BloggerID;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value less than zero");
                }
                else
                {
                    _BloggerID = value;
                }

            }
        }
        public string BloggerName
        {
            get
            {
                return _BloggerName;
            }
            set
            {
                _BloggerName = value;
            }
        }

        public string BloggerSubject
        {
            get
            {
                return _BloggerSubject;
            }
            set
            {
                _BloggerSubject = value;
            }
        }

        public int BlogID
        {
            get
            {
                return _BlogID;
            }
            set
            {
                _BlogID = value;
            }
        }

        public string BlogName
        {
            get
            {
                return _BlogName;
            }
            set
            {
                _BlogName = value;
            }
        }

        public string BlogContent
        {
            get
            {
                return _BlogContent;
            }
            set
            {
                _BlogContent = value;
            }
        }

        public DateTime BlogDate
        {
            get
            {
                return _BlogDate;
            }
            set
            {
                _BlogDate = value;
            }
        }

    }
}
