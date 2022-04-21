using System;
using Raylib_cs;
namespace C__Projects
{
    /// <summary>
    /// Inherits from the actor class.

    /// </summary>
    class Player : Actor
    {

        /// <summary>
        /// Sets position of the buffer onto the board with a width and height.
        /// Runs the update text function
        /// </summary>
        public Player()
        {
            SetWidthHeight(Constants.DEFAULT_SQUARE_SIZE, Constants.DEFAULT_SQUARE_SIZE);

            int x = 75;
            int y = Constants.MAX_Y / 2;

            Point position = new Point(x,y);
            SetPosition(position);
            UpdateText();
        
        }

        /// <summary>
        /// Calls the moveNext function from the actor class.
        /// </summary>
        public void Move()
        {
            MoveNext();
        }


        /// <summary>
        /// Updates the text to draw a face on the player
        /// </summary>
        public void UpdateText()
        {
            _text = ">.<";

        }

        

        

    }
}
