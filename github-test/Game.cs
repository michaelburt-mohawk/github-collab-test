// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Texture2D t;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Texture test");
            Window.SetSize(800, 600);

            t = Graphics.LoadTexture("C:\\Users\\Mohawk\\Documents\\my-cool-game\\github-test\\Assets\\house.png");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);

            Graphics.Draw(t, new Vector2(50, 50));
        }
    }
}
