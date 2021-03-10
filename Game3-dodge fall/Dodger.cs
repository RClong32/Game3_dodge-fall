using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

//used the 32x32 bat sprite from opengameart.com

namespace Game3_dodge_fall
{
    public class Dodger
{
     public enum Direction
        {
            Down = 0,
            Right = 1,
            Up = 2,
            Left = 3,
        }

     private KeyboardState keyboardState;
        //private KeyboardState previousKeyboardState;

        private double animationTimer;

        private short animationFrame = 1;

        private Direction direction;


        private Texture2D texture;

        private Vector2 position;

    public void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("dodgerBat");

        }

    public void Update(GameTime gameTime)
        {

           
            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Up) || keyboardState.IsKeyDown(Keys.W))
            {
                direction = Direction.Up;
                position += new Vector2(0, -2);
                
            }
            if (keyboardState.IsKeyDown(Keys.Down) || keyboardState.IsKeyDown(Keys.S))
            {
                direction = Direction.Down;
                position += new Vector2(0, 2);
                
            }
            if (keyboardState.IsKeyDown(Keys.Left) || keyboardState.IsKeyDown(Keys.A))
            {
                direction = Direction.Left;
                position += new Vector2(-2, 0);
                
            }
            if (keyboardState.IsKeyDown(Keys.Right) || keyboardState.IsKeyDown(Keys.D))
            {
                direction = Direction.Right;
                position += new Vector2(2, 0);
                
            }
            }

    public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;

            if(animationTimer > 0.1)
            {
                animationFrame++;
                if (animationFrame > 3) animationFrame = 1;
                animationTimer -= 0.1;
            }
            var source = new Rectangle(animationFrame * 32, (int)direction * 32, 32, 32);
            spriteBatch.Draw(texture, position, source, Color.White, 0, new Vector2(-75,-50), 4.0f, SpriteEffects.None, 0);
        }

    }
}
