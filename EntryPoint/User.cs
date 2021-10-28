using EntryPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLines
{
    class User
    {
        public static int currentID;

        //public const int HEIGHT = 180;
        public readonly int HEIGHT;
        public readonly int ID;

        public Race race; 

        private String username; 
        private int password ;
        public String Username {
            get {
                return "The username is " + username;
            }
        }
        public int Password {   
            get {
                return password;
            }
            set {
                if (value >= 4 && value <= 10)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Invalid password! Please select password between 4 and 10 characters");
                }
            } 
      }
        public User() {
            currentID++;
            ID = currentID;
        }
        public User(String username, Race race) {
            currentID++;
            ID = currentID;
            this.username = username;
            this.race = race;

            if (race == Race.Martian)
            {
                HEIGHT = 100;
            }
            else if (race == Race.Earthling)
            {
                HEIGHT = 180;
            }
        }
    }
}
