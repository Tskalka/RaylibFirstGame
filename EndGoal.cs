using System;
using Raylib_cs;

namespace C__Projects
{

    /// <summary>
    /// Inherits from the actor class.

    /// </summary>
    class EndGoal : Actor
    {

        /// <summary>
        /// Sets position of the end goal with display text
        /// </summary>
        public EndGoal(int x, int y)
        {
            SetWidthHeight(100,25);
            int x1 = x;
            int y1 = y;

            Point position = new Point(x1,y1);
            SetPosition(position);

            UpdateText();
        }

        /// <summary>
        /// Updates display text showing the end goal.
        /// </summary>
        public void UpdateText()
        {
            _text = "End Goal!";
        }
    }
}
