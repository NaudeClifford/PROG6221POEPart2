using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PROG6221POEPart2
{
    internal abstract class AbstractClassd
    {

        //================== class stores user information  ==================
        private string name;
        private string day;
        private List<string> favouriteTopic;

        public AbstractClassd() 
        {

            name = "";
            day = "";
            favouriteTopic = new List<string>();
        }

        public AbstractClassd(string name, string day, List<string> favouriteTopic) 
        { 
            this.name = name;
            this.day = day;
            this.favouriteTopic = favouriteTopic;
        }
        //================== custom setters and getters for validating the information, if incorrect, will send an error and not add the information  ==================

        public void setName(string name) 
        {

            if (name.Equals(string.IsNullOrEmpty)) throw new NullReferenceException("Need to enter a value for Name!");

            else if (name.All(Char.IsDigit).Equals(true)) throw new FormatException("Only enter strings");

            else this.name = name;
        }

        public void setDay(string day)
        {

            if (day.Equals(string.IsNullOrEmpty)) throw new NullReferenceException("Need to enter a value for your day!");

            else if (day.All(Char.IsDigit).Equals(true)) throw new FormatException("Only enter strings");

            else this.day = day;
        }

        public void setFavouriteTopic(List<string> favouriteTopic)
        {
            int check = 0;

            for (int i = 0; i < favouriteTopic.Count; i++)
            {

                if (favouriteTopic[i].Equals(string.IsNullOrEmpty)) throw new NullReferenceException("Need to enter a value for your favourite topic!");

                else if (favouriteTopic[i].All(Char.IsDigit).Equals(true)) throw new FormatException("Only enter strings");

                else check++;

                }
            if (check.Equals(favouriteTopic.Count()))
            {
                this.favouriteTopic = favouriteTopic;
                Console.WriteLine("");
            }

            else throw new Exception("ReTry Askking the questions");
        }

        public string getName()
        {

            return name; 
        }

        public string getDay() 
        {

            return day;
        }

        public List<string> getFavouriteTopic()
        {

            return favouriteTopic;
        }

        //================== ToString ==================
        public override string ToString()
        {
            string result = "\nUser Information: \nName: " + name + "\nHow was there day: " + day;

            for (int i = 0; i < favouriteTopic.Count(); i++) 
            {
                result = result + "\nusers favourite topics: " + favouriteTopic[i];
            }

            return result;
        }

        //================== interface for a ToString if the user would like to ask for there information  ==================

        public interface IClassd 
        {

            abstract void OutPut(string message);
        }


    }
}
