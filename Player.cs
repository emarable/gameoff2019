using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace gameoff2019
{
    class Player
    {
        public Texture2D PlayerTexture;
        public Vector2 Position;

        public bool Active;
        public int Health;
        public int Width { get { return PlayerTexture.Width;  } }
        public int Height { get { return PlayerTexture.Height;  } }

        public void Init(Texture2D texture, Vector2 position) {
            this.PlayerTexture = texture;
            this.Position = position;
            this.Active = true;
            this.Health = 100;
        }
        public void Step() { }
        public void Draw(SpriteBatch sb) {
            sb.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
        }
    }
}
