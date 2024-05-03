using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame
{
    /// <summary>
    /// Game class containing methods related to game logic.
    /// </summary>
    class Game : SuperGame
    {
        /// <summary>
        /// Method to update the position of the character based on keyboard input.
        /// </summary>
        /// <param name="key">he key pressed by the player.</param>
        /// <param name="xChange">Output parameter representing the change in the x coordinate.</param>
        /// <param name="yChange">Output parameter representing the change in the y coordinate.</param>
        public static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            // Initialise the changes to 0
            xChange = 0;
            yChange = 0;

            switch (key)
            {
                case "LeftArrow":
                    xChange = -1;
                    break;
                case "RightArrow":
                    xChange = 1;
                    break;
                case "UpArrow":
                    yChange = -1;
                    break;
                case "DownArrow":
                    yChange = 1;
                    break;
                case "Spacebar":
                    // Handle Spacebar input if needed
                    break;
                default:
                    // Handle other keys if needed
                    break;
            }
        }

        /// <summary>
        /// Method to update the symbol representing the curso based on they key pressed.
        /// </summary>
        /// <param name="key">The key pressed by the player.</param>
        /// <returns>The symbol representing the player's cursor.</returns>
        public new static char UpdateCursor(string key)
        {
            char cursor = '<'; // Default cursor

            // Determine the cursor based on the key pressed
            switch (key)
            {
                case "LeftArrow":
                    cursor = '<';
                    break;
                case "RightArrow":
                    cursor = '>';
                    break;
                case "UpArrow":
                    cursor = '^';
                    break;
                case "DownArrow":
                    cursor = 'v';
                    break;
                default:
                    // Handle other keys if needed
                    break;
            }

            return cursor;
        }

        /// <summary>
        /// Method to keep a coordinate within bounds.
        /// </summary>
        /// <param name="dimension">The coordinate to be constrained.</param>
        /// <param name="max">The maximum value for the coordinate.</param>
        /// <returns>The constrained coordinate.</returns>
        public new static int KeepInBounds(int dimension, int max)
        {
            // Constrain the coordinate between 0 and max - 1
            if (dimension < 0)
            {
                // If dimension is less than 0, set it to 0
                return 0;
            }
            else if (dimension >= max)
            {
                // If dimension is greater than or equal to max, set it to max - 1
                // We subtract 1 because the upper bound is exclusive
                return max - 1;
            }
            else
            {
                // If dimension is within bounds, return it unchanged
                return dimension;
            }
        }

        /// <summary>
        /// Method to check if the player has scored by hitting the fruit.
        /// </summary>
        /// <param name="characterX">The x coordinate of the character.</param>
        /// <param name="characterY">The y coordinate of the character.</param>
        /// <param name="fruitX">The x coordinate of the fruit.</param>
        /// <param name="fruitY">The y coordinate of the fruit.</param>
        /// <returns></returns>
        public new static bool DidScore(int characterX,  int characterY, int fruitX, int fruitY)
        {
            // Check if the character and fruit are at the same position
            return characterX == fruitX && characterY == fruitY;
        }
    }
}
