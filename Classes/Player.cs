using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Coursework_0._0.Classes
{
    [Serializable]
    public class Player
    {
        private string username;
        private string password;
        private Image avatar;
        private int highscore = 0;
        private int hardhighscore = 0;
        private int score;
        private bool adminStatus;

        public Player()
        {
            username = "";
            password = "";
            avatar = null;
            highscore = 0;
            hardhighscore = 0;
            score = 0;
            adminStatus = false;
        }
        public Player(string username, string password) : this()
        {
            Username = username;
            Password = password;
        }

        public Image Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public bool AdminSatus
        {
            get { return adminStatus; }
            set { adminStatus = value; }
        }

        public int HighScore
        {
            get { return highscore; }
            set { highscore = value; }
        }
        public int HardHighScore
        {
            get { return hardhighscore; }
            set { hardhighscore = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (username == "admin")
                {
                    username = value;
                }
                if (value.Length < 5 && username != "admin")
                {
                    throw new PlayerExceptions("Username too short");
                }
                username = value;
            }
        }


        public string Password
        {
            get { return password; }
            set
            {
                if (value == "admin")
                {
                    password = value;
                }
                else if (value.Length < 7)
                {
                    throw new PlayerExceptions("Password too short");
                }
                else if (!ContainsNum(value))
                {
                    throw new PlayerExceptions("Password must contain a number");
                }
                else
                {
                    password = value;
                }
            }
        }

        private bool ContainsNum(string password)
        {
            foreach (char character in password)
            {
                if (Char.IsDigit(character))
                    return true;
            }
            return false;
        }
    }
}

