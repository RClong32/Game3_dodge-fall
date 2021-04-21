using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace TheCave
{
    public class HolyThunder
    {
        public enum Direction
        {
            calm = 0,
            cruel = 1,
        }


        private double animationTimer;

        private short animationFrame = 0;

        private Direction direction;


        private Texture2D _texture;





        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("Lightning_Cyan");
        }


        public void Update(GameTime gameTime)
        {

            var keyboardState = Keyboard.GetState();
            float t = (float)gameTime.ElapsedGameTime.TotalSeconds;



        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            animationTimer += gameTime.ElapsedGameTime.TotalSeconds;
            if (animationTimer > 0.03)
            {
                animationFrame++;
                if (animationFrame > 5) animationFrame = 0;
                animationTimer -= 0.03;
            }
            var source = new Rectangle(animationFrame * 100, (int)direction * 100, 90, 170);
            spriteBatch.Draw(_texture, new Vector2(800, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(1600, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(2000, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(3000, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(3100, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(7000, -30), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);

        }






    }
}