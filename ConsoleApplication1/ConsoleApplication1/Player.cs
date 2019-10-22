﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private string Name;
        public void PickBall(Board game)
        {
            Console.WriteLine("Which group do you choose?");
            int group = int.Parse(Console.ReadLine());
            Console.WriteLine("How many balls will you pick?");
            int balls = int.Parse(Console.ReadLine());
            game.PickBall(group, balls);
        }
        public Player(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
}
