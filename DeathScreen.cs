using System;

namespace C__Projects
{
    /// <summary>
    /// The score board in the top portion of the game.
    /// </summary>
    class DeathScreen: Actor
    {


        /// <summary>
        /// Creates a new red screen that will block out the old screen with the words, You Died.
        /// </summary>
        public DeathScreen()
        {
            _position = new Point(0 , 0);
            _width = 800;
            _height = 600;
            
            UpdateText();
        }

        /// <summary>
        /// Updates the text to say that you have died.
        /// </summary>
        private void UpdateText()
        {
            _text = "You Died";
        }

    }
}