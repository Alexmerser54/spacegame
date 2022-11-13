﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Game
{
    class Star
    {
        Point position;
        int energyRadius;
        int destroyRadius;
        int power;

        public Star(Point pos, int energyRadius, int destroyRadius, int power)
        {
            position = pos;
            this.energyRadius = energyRadius;
            this.destroyRadius = destroyRadius;
            this.power = power;
        }

        public int Power
        {
            get
            {
                return power;
            }
        }

        public int EnergyRadius
        {
            get
            {
                return energyRadius;
            }
        }


        public int DestroyRadius
        {
            get
            {
                return destroyRadius;
            }
        }

        public Point Position
        {
            get
            {
                return position;
            }
        }

    }
}
