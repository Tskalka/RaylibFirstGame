using System;

namespace C__Projects
{
    /// <summary>
    /// Display text when game is complete.
    /// </summary>
    class WinScreen: Actor
    {

        public WinScreen()
        {
            _position = new Point(300 , 350);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect that you won.
        /// This should be called whenever the end platform is reached.
        /// </summary>
        private void UpdateText()
        {
            _text = "A Winner Is YOU!!!";
        }

    }
}