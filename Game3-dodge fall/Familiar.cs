using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace TheCave
{
    /// <summary>
    /// A class representing the player's sprite
    /// </summary>
    public class Familiar
    {
        public enum Direction
        {
            Down = 0,
            Right = 1,
            Up = 2,
            Left = 3,
        }

        private KeyboardState keyboardState;

        private double animationTimer;

        private short animationFrame = 1;

        private Direction direction;


        private Texture2D _texture;


        private Rectangle _Familiar = new Rectangle(128, 128, 128, 128);


        private Vector2 _position;



        /// <summary>
        /// The current position of the player
        /// </summary>
        public Vector2 Position => _position;

        /// <summary>
        /// Loads the player texture atlas
        /// </summary>
        /// <param name="content">The ContentManager to use to load the content</param>
        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("Familiar");
        }

        /// <summary>
        /// Updates the player
        /// </summary>
        /// <param name="gameTime">An object representing time in the game</param>
        public void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();
            float t = (float)gameTime.ElapsedGameTime.TotalSeconds;

            //keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
            {
                direction = Direction.Up;

            }
            if (keyboardState.IsKeyDown(Keys.Down) || keyboardState.IsKeyDown(Keys.S))
            {
                direction = Direction.Down;

            }
            if (keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A))
            {
                direction = Direction.Left;

            }
            if (keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D))
            {
                direction = Direction.Right;

            }

            if (keyboardState.IsKeyDown(Keys.Left)) _position -= Vector2.UnitX * 100 * t;
            if (keyboardState.IsKeyDown(Keys.Right)) _position += Vector2.UnitX * 300 * t;
            if (keyboardState.IsKeyDown(Keys.Up)) _position -= Vector2.UnitY * 60 * t;
            if (keyboardState.IsKeyDown(Keys.Down)) _position += Vector2.UnitY * 120 * t;

        }

        /// <summary>
        /// Draws the player sprite
        /// </summary>
        /// <param name="gameTime">An object representing time in the game</param>
        /// <param name="spriteBatch">The SpriteBatch to draw the player with</param>
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

            if (animationTimer > 0.1)
            {
                animationFrame++;
                if (animationFrame > 3) animationFrame = 1;
                animationTimer -= 0.1;
            }
            var source = new Rectangle(animationFrame * 128, (int)direction * 128, 128, 128);
            spriteBatch.Draw(_texture, _position, source, Color.White);
        }
    }
}