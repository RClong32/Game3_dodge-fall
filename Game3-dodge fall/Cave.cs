using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheCave
{
    /// <summary>
    /// A game demonstrating parallax scrolling
    /// </summary>
    public class Cave : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Familiar _player;
        private HolyThunder _thunder;
        private Master _master;

        // Layer textures
        private Texture2D _foreground;
        private Texture2D _midground;
        private Texture2D _background;

        public Cave()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            // Need to use HiDef due to the size of our textures!
            _graphics.GraphicsProfile = GraphicsProfile.HiDef;
        }

        /// <summary>
        /// Initializes the game
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _player = new Familiar();
            _thunder = new HolyThunder();
            _master = new Master();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _player.LoadContent(Content);
            _thunder.LoadContent(Content);
            _master.LoadContent(Content);

            // load the layer textures
            _foreground = Content.Load<Texture2D>("cave_0002_back");
            _midground = Content.Load<Texture2D>("cave_0001_mid");
            _background = Content.Load<Texture2D>("cave_0000_front");
        }

        /// <summary>
        /// Updates the game
        /// </summary>
        /// <param name="gameTime">An object representing time in-game</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            _player.Update(gameTime);
            _thunder.Update(gameTime);
            _master.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// Draws the game
        /// </summary>
        /// <param name="gameTime">An object representing time in-game</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            //Calculating our offset vector
            float playerX = MathHelper.Clamp(_player.Position.X, 300, 13600);
            float offsetX = 300 - playerX;
            Matrix transform;



            // TODO: Add your drawing code here
            transform = Matrix.CreateTranslation(offsetX * 0.333f, 0, 0);

            _spriteBatch.Begin(transformMatrix: transform);
            _spriteBatch.Draw(_background, Vector2.Zero, Color.White);
            _spriteBatch.End();

            transform = Matrix.CreateTranslation(offsetX * 0.666f, 0, 0);
            _spriteBatch.Begin(transformMatrix: transform);
            _spriteBatch.Draw(_midground, Vector2.Zero, Color.White);
            _spriteBatch.End();

            transform = Matrix.CreateTranslation(offsetX, 0, 0);
            _spriteBatch.Begin(transformMatrix: transform);
            _spriteBatch.Draw(_foreground, Vector2.Zero, Color.White);
            _player.Draw(gameTime, _spriteBatch);
            _thunder.Draw(gameTime, _spriteBatch);
            _master.Draw(gameTime, _spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}