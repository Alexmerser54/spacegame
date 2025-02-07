﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Game.Objects
{
    abstract class GameObject
    {
        protected Point position;

        public GameObject(Point position)
        {
            this.position = position;
        }

        public Point Position => position;
    }
}
