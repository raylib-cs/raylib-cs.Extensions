namespace Raylib_cs.Extensions;

public static class TextureExtensions
{
    public static void Draw(this Texture2D texture, int posX, int posY, Color tint)
    {
        Raylib.DrawTexture(texture, posX, posY, tint);
    }
}
