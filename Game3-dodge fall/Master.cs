using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace TheCave
{
    public class Master
    {
        private Texture2D _texture;

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("vampire");
        }


        public void Update(GameTime gameTime)
        {

            var keyboardState = Keyboard.GetState();
            float t = (float)gameTime.ElapsedGameTime.TotalSeconds;



        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {

            var source = new Rectangle(0, 0, 64, 64);
            spriteBatch.Draw(_texture, new Vector2(7200, 150), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(3050, 150), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);
            spriteBatch.Draw(_texture, new Vector2(2000, 150), source, Color.White, 0f, new Vector2(0, 0), 2f, SpriteEffects.None, 0);

        }


    }
}