using System;
using Raylib_cs;

namespace C__Projects
{
    /// <summary>
    /// Handles all the interaction with the user input library.
    /// </summary>
    public class InputService
    {

        public InputService()
        {

        }
        /// <summary>
        /// Will get user input from left, right or space.
        /// </summary>
        public bool IsLeftPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT);
        }
        public bool IsRightPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT);

        }
        public bool IsSpacePressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_SPACE);
        }

         /// <summary>
        /// Will return a new point based on the direction added based on user input.
        /// </summary>
        public Point GetDirection()
        {
            int x = 0;
            int y = 0;

            if(IsLeftPressed())
            {
                x = -1;
            }
            if(IsRightPressed())
            {
                x = 1;
            }
            if(IsSpacePressed())
            {
                y -= 150;
            }

            return new Point (x,y);
        }

        /// <summary>
        /// Returns true if the user has attempted to close the window.
        /// </summary>
        /// <returns></returns>
        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }
    }
}