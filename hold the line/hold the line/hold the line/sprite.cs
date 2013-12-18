using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace hold_the_line
{
    class sprite
    {
        public class Sprite
        {
            GraphicsDeviceManager graphics;
            SpriteBatch spriteBatch;

            Texture2D exploding;
            Texture2D turrets;

            protected List<Rectangle> frames = new List<Rectangle>();
            private int frameWidth = 0;
            private int frameHeight = 0;
            private int currentFrame;
            private float frameTime = 0.1f;
            private float timeForCurrentFrame = 0.0f;
        }
    }
}
