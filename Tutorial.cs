using System;
using Raylib_cs;

namespace C__Projects
{

    /// <summary>
    /// Inherits from the actor class.

    /// </summary>
    class Tutorial : Actor
    {

        /// <summary>
        /// Sets the tutorial display text
        /// </summary>
        public Tutorial(int x, int y)
        {
            int x1 = x;
            int y1 = y;

            Point position = new Point(x1,y1);
            SetPosition(position);

            UpdateText();
        }

        /// <summary>
        /// Updates tutorial text
        /// </summary>
        public void UpdateText()
        {
            _text = "Press Spaece to use your teleporting powers!";
        }
    }
}
