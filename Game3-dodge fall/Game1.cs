using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game3_dodge_fall
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Dodger dodger;
        private Stabber stabber;
        //private Texture2D at;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            dodger = new Dodger();
            stabber = new Stabber();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dodger.LoadContent(Content);
            stabber.LoadContent(Content);
            //at = Content.Load<Texture2D>("colored_packed");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            dodger.Update(gameTime);
            stabber.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            dodger.Draw(gameTime, _spriteBatch);
            stabber.Draw(gameTime, _spriteBatch);
            //_spriteBatch.Draw(at, new Vector2(50, 50), new Rectangle(512, 112, 16, 16), Color.White, 2.3f, new Vector2(0,0), 2f, SpriteEffects.None,0);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
