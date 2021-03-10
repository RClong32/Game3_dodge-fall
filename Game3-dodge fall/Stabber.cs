using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Game3_dodge_fall
{
    public class Stabber
{

        public enum Direction
        {
            Down = 0,
            Right = 1,
            Up = 2,
            Left = 3,
        }

        private Direction direction;

        private Vector2 position;

        private double dropTimer;
        private Texture2D dT;

       

        public void LoadContent(ContentManager content)
        {
            dT = content.Load<Texture2D>("colored_packed");

        }

        public void Update(GameTime gameTime)
        {
            dropTimer += gameTime.ElapsedGameTime.TotalSeconds;
            if(dropTimer > 0.01)
            {               
                 position += new Vector2(0, 2) *100 * (float)gameTime.ElapsedGameTime.TotalSeconds;
                dropTimer = 0;
            }
            Vector2 temp = position;
            if(temp.Y >= 500)
            {
                Random r = new Random();
                int rX = r.Next(50, 575);
                int rY = r.Next(-100, 50);
                position = new Vector2(rX, rY);
            }

           
        }


        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(50, 50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(100, 50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(350, -50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(200, 50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(300, -100), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(100, 20), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(425, 120), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(150, 50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(575, -50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(200, 50), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(dT, position, new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(225, -200), 2f, SpriteEffects.None, 0);
        }







        }
}
