using System;

namespace C__Projects
{
    /// <summary>
    /// The score board will show lives in the top portion of the game.
    /// </summary>
    class ScoreBoard : Actor
    {
        private int _lives = 1;

        public ScoreBoard()
        {
            _position = new Point(725, 0);
            _width = 0;
            _height = 0;
            
            UpdateText();
        }

        /// <summary>
        /// Increments the points by the amount specified and updates the
        /// text.
        /// </summary>
        /// <param name="points"></param>

        /// <summary>
        /// Removes lives 
        /// </summary>
        public void RemovePoints(int lives)
        {
            _lives -= lives;
            UpdateText();
        }

        /// <summary>
        /// Updates the text to reflect the amount of lives you have
        /// </summary>
        private void UpdateText()
        {
            _text = $"Lives: {_lives}";
        }

        /// <summary>
        /// Returns the lives member variable
        /// </summary>
        public int GetLives()
        {
            return _lives;
        }
    }
}