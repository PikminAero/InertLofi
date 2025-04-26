using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace InertLofi
{
    // Taken straight from Calamity's source files, I apologize
    // Thanks to Nycro#0001 <@!262663471189983242> for this null background which cleanly ignores vanilla's parallax mechanics
    internal class NullSurfaceBackground : ModSurfaceBackgroundStyle
    {
        public override void ModifyFarFades(float[] fades, float transitionSpeed)
        {
            for (int i = 0; i < fades.Length; i++)
            {
                if (i == Slot)
                {
                    fades[i] += transitionSpeed;
                    if (fades[i] > 1f)
                    {
                        fades[i] = 1f;
                    }
                }
                else
                {
                    fades[i] -= transitionSpeed;
                    if (fades[i] < 0f)
                    {
                        fades[i] = 0f;
                    }
                }
            }
        }

        private static readonly string TexPath = "CalamityMod/Backgrounds/BlankPixel";
        public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b) => BackgroundTextureLoader.GetBackgroundSlot(TexPath);
        public override int ChooseFarTexture() => BackgroundTextureLoader.GetBackgroundSlot(TexPath);
        public override int ChooseMiddleTexture() => BackgroundTextureLoader.GetBackgroundSlot(TexPath);
        public override bool PreDrawCloseBackground(SpriteBatch spriteBatch) => false;
    }

    public class LofiMainMenu : ModMenu
    {
        // Taken straight out of Calamity
        public class Cinder
        {
            public int Time;
            public int Lifetime;
            public int IdentityIndex;
            public float Scale;
            public float Depth;
            public Color DrawColor;
            public Vector2 Velocity;
            public Vector2 Center;

            public Cinder(int lifetime, int identity, float depth, Color color, Vector2 startingPosition, Vector2 startingVelocity)
            {
                Lifetime = lifetime;
                IdentityIndex = identity;
                Depth = depth;
                DrawColor = color;
                Center = startingPosition;
                Velocity = startingVelocity;
            }
        }

        public static List<Cinder> Cinders
        {
            get;
            internal set;
        } = new();
        public override string DisplayName => "Calamity Style (but it's lofi)";
        public override int Music => MusicLoader.GetMusicSlot("InertLofi/Assets/Music/CalamityTitle");
        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("InertLofi/Assets/Images/Logo_placeholder");
        public override Asset<Texture2D> SunTexture => ModContent.Request<Texture2D>("CalamityMod/Backgrounds/BlankPixel");
        public override Asset<Texture2D> MoonTexture => ModContent.Request<Texture2D>("CalamityMod/Backgrounds/BlankPixel");
        public override ModSurfaceBackgroundStyle MenuBackgroundStyle => ModContent.GetInstance<NullSurfaceBackground>();
        private Asset<Texture2D> BackgroundTexture => ModContent.Request<Texture2D>("InertLofi/Assets/Images/Background_placeholder");

        // Taken from Calamity's source and adapted to remove the cinders
        // Before drawing the logo, draw the entire Calamity background. This way, the typical parallax background is skipped entirely.
        public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor)
        {
            Texture2D texture = BackgroundTexture.Value;

            // Calculate the draw position offset and scale in the event that someone is using a non-16:9 monitor
            Vector2 drawOffset = Vector2.Zero;
            float xScale = (float)Main.screenWidth / texture.Width;
            float yScale = (float)Main.screenHeight / texture.Height;
            float scale = xScale;

            // if someone's monitor isn't in wacky dimensions, no calculations need to be performed at all
            if (xScale != yScale)
            {
                // If someone's monitor is tall, it needs to be shifted to the left so that it's still centered on screen
                // Additionally the Y scale is used so that it still covers the entire screen
                if (yScale > xScale)
                {
                    scale = yScale;
                    drawOffset.X -= (texture.Width * scale - Main.screenWidth) * 0.5f;
                }
                else
                    // The opposite is true if someone's monitor is widescreen
                    drawOffset.Y -= (texture.Height * scale - Main.screenHeight) * 0.5f;
            }

            spriteBatch.Draw(texture, drawOffset, null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);


            static Color selectCinderColor()
            {
                if (Main.rand.NextBool(3))
                    return Color.Lerp(Color.White, Color.LightGray, Main.rand.NextFloat());

                return Color.Lerp(Color.MediumPurple, Color.Pink, Main.rand.NextFloat(0.9f));
            }

            // Randomly add cinders.
            for (int i = 0; i < 5; i++)
            {
                if (Main.rand.NextBool(4))
                {
                    int lifetime = Main.rand.Next(200, 300);
                    float depth = Main.rand.NextFloat(1.8f, 5f);
                    Vector2 startingPosition = new Vector2(Main.screenWidth * Main.rand.NextFloat(-0.1f, 1.1f), Main.screenHeight * 1.05f);
                    Vector2 startingVelocity = -Vector2.UnitY.RotatedBy(Main.rand.NextFloat(-0.9f, 0.9f)) * 4f;
                    Color cinderColor = selectCinderColor();
                    Cinders.Add(new Cinder(lifetime, Cinders.Count, depth, cinderColor, startingPosition, startingVelocity));
                }
            }

            // Update all cinders.
            for (int i = 0; i < Cinders.Count; i++)
            {
                Cinders[i].Scale = Utils.GetLerpValue(Cinders[i].Lifetime, Cinders[i].Lifetime / 3, Cinders[i].Time, true);
                Cinders[i].Scale *= MathHelper.Lerp(0.6f, 0.9f, Cinders[i].IdentityIndex % 6f / 6f);
                if (Cinders[i].IdentityIndex % 13 == 12)
                    Cinders[i].Scale *= 2f;

                float flySpeed = MathHelper.Lerp(3.2f, 14f, Cinders[i].IdentityIndex % 21f / 21f);
                Vector2 idealVelocity = -Vector2.UnitY.RotatedBy(MathHelper.Lerp(-0.44f, 0.44f, (float)Math.Sin(Cinders[i].Time / 16f + Cinders[i].IdentityIndex) * 0.5f + 0.5f));
                idealVelocity = (idealVelocity + Vector2.UnitX).SafeNormalize(Vector2.UnitY) * flySpeed;

                float movementInterpolant = MathHelper.Lerp(0.01f, 0.08f, Utils.GetLerpValue(45f, 145f, Cinders[i].Time, true));
                Cinders[i].Velocity = Vector2.Lerp(Cinders[i].Velocity, idealVelocity, movementInterpolant);

                Cinders[i].Time++;
                Cinders[i].Center += Cinders[i].Velocity;
            }

            // Clear away all dead cinders.
            Cinders.RemoveAll(c => c.Time >= c.Lifetime);

            // Draw cinders.
            Texture2D cinderTexture = ModContent.Request<Texture2D>("CalamityMod/Skies/CalamitasCinder").Value;
            for (int i = 0; i < Cinders.Count; i++)
            {
                Vector2 drawPosition = Cinders[i].Center;
                spriteBatch.Draw(cinderTexture, drawPosition, null, Cinders[i].DrawColor, 0f, cinderTexture.Size() * 0.5f, Cinders[i].Scale, 0, 0f);
            }


            // Set the logo draw color to be white and the time to be noon
            // This is because there is not a day/night cycle in this menu, and changing colors would look bad
            drawColor = Color.White;
            Main.time = 27000;
            Main.dayTime = true;

            // Draw the logo using a different spritebatch blending setting so it doesn't have a horrible yellow glow
            Vector2 drawPos = new Vector2(Main.screenWidth / 2f, 100f);
            spriteBatch.End();
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
            spriteBatch.Draw(Logo.Value, drawPos, null, drawColor, logoRotation, Logo.Value.Size() * 0.5f, logoScale, SpriteEffects.None, 0f);
            spriteBatch.End();
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
            return false;
        }
    }
}
