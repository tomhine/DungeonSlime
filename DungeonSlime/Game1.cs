using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGameLibrary;

namespace DungeonSlime;

public class Game1 : Core
{
    private Texture2D _logo;
    private Vector2 _logoPos;
    private Vector2 _logoOrigin;

    public Game1() : base("Dungeon Slime", 1280, 720, false)
    {
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();

        _logoPos = new Vector2(
            Window.ClientBounds.Width * 0.5f,
            Window.ClientBounds.Height * 0.5f
        );
        _logoOrigin = new Vector2(_logo.Width * 0.5f, _logo.Height * 0.5f);
    }

    protected override void LoadContent()
    {
        // TODO: use this.Content to load your game content here
        _logo = Content.Load<Texture2D>("images/logo");
        
        base.LoadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);

        // TODO: Add your drawing code here
        SpriteBatch.Begin();

        SpriteBatch.Draw(
            _logo,
            _logoPos,
            null,
            Color.White * 0.5f,
            0.0f,
            _logoOrigin,
            1.0f,
            SpriteEffects.None,
            1.0f
        );

        SpriteBatch.End();

        base.Draw(gameTime);
    }
}
