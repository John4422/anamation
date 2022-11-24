using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace anamation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D tribblegreytexture;
        Texture2D tribblecreamtexture;
        Texture2D tribblebrowntexture;
        Texture2D tribbleorangetexture;
        Texture2D backgroundtexture;
        Rectangle tribblecreRect;
        Rectangle tribblebroRect;
        Rectangle tribbleorRect;
        Rectangle tribbleGreRect;
        Vector2 tribbleGreyspeed;
        Vector2 tribblebrownspeed;
        Vector2 tribblecreamspeed;
        Vector2 tribbleorangespeed;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tribbleorRect = new Rectangle(200, 50, 50, 50);
            tribblebroRect = new Rectangle(100, 200, 50, 50);
            tribbleGreRect = new Rectangle (300, 100, 50, 50);
            tribblecreRect = new Rectangle(400, 250, 75 , 75);
            tribbleGreyspeed = new Vector2(2, -2);
            tribblebrownspeed = new Vector2(-1, 2);
            tribblecreamspeed = new Vector2(2, 0);
            tribbleorangespeed = new Vector2(2, 2);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribblegreytexture = Content.Load<Texture2D>("tribblegrey");
            tribblebrowntexture = Content.Load<Texture2D>("tribblebrown");
            tribbleorangetexture = Content.Load<Texture2D>("tribbleorange");
            tribblecreamtexture = Content.Load<Texture2D>("tribblecream");
            backgroundtexture = Content.Load<Texture2D>("cloudbackground");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            tribbleGreRect.X += (int)tribbleGreyspeed.X;
            if (tribbleGreRect.Right > 800 || tribbleGreRect.X < 0 )
                tribbleGreyspeed.X *= -1;


            tribbleGreRect.Y += (int)tribbleGreyspeed.Y;
            if (tribbleGreRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleGreRect.Y < 0 )
                tribbleGreyspeed.Y *= -1;

            tribblebroRect.X += (int)tribblebrownspeed.X;
            if (tribblebroRect.Right > 800 || tribblebroRect.X < 0)
                tribblebrownspeed.X *= -1;


            tribblebroRect.Y += (int)tribblebrownspeed.Y;
            if (tribblebroRect.Bottom > _graphics.PreferredBackBufferHeight || tribblebroRect.Y < 0)
                tribblebrownspeed.Y *= -1;

            tribblecreRect.X += (int)tribblecreamspeed.X;
            if (tribblecreRect.Right > 800 || tribblecreRect.X < 0)
                tribblecreamspeed.X *= -1;


            tribblecreRect.Y += (int)tribblecreamspeed.Y;
            if (tribblecreRect.Bottom > _graphics.PreferredBackBufferHeight || tribblecreRect.Y < 0)
                tribblecreamspeed.Y *= -1;

            tribbleorRect.X += (int)tribbleorangespeed.X;
            if (tribbleorRect.Right > 800 || tribbleorRect.X < 0)
                tribbleorangespeed.X *= -1;


            tribbleorRect.Y += (int)tribbleorangespeed.Y;
            if (tribbleorRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleorRect.Y < 0)
                tribbleorangespeed.Y *= -1;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(backgroundtexture, new Rectangle(0, 0, 800, 500), Color.White);
            _spriteBatch.Draw(tribblegreytexture, tribbleGreRect, Color.White);
            _spriteBatch.Draw(tribblebrowntexture, tribblebroRect, Color.White);
            _spriteBatch.Draw(tribblecreamtexture, tribblecreRect, Color.White);
            _spriteBatch.Draw(tribbleorangetexture, tribbleorRect, Color.White);

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}