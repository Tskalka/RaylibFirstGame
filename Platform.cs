using System;
using Raylib_cs;

namespace C__Projects
{

    /// <summary>
    /// Inherits from the actor class.

    /// </summary>
    class Platform : Actor
    {

        /// <summary>
        /// Sets position of the platform, accepts x and y value for placement on the screen.

        /// </summary>
        public Platform(int x, int y)
        {
            SetWidthHeight(100,10);
            int x1 = x;
            int y1 = y;

            Point position = new Point(x1,y1);
            SetPosition(position);
        }

    }
}
