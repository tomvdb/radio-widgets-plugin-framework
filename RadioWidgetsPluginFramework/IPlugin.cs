using System.Numerics;
using Raylib_cs;

namespace RadioWidgetsPluginFramework
{
    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        string Version { get; }

        event Action<string> Notify;

        // initial start (only called once)
        void Initialize();

        // mouse position is null if mouse if not over plugin gui
        // called on every frame
        void Update(Vector2? MousePosition, Vector2 ViewPortSize);

        // draw plugin gui on Raylib Texture
        // called on every frame
        void Draw(RenderTexture2D texture);

        // called on app exit
        void Close();

        // called when plugin is selected (called once select)
        void PluginFocus();

        // called when plugin is not showing (called once on back/home button pressed)
        void PluginFocusLost();

        // expects a 64x64 texture with icon data
        // could potentially be used to make the icon dynamic
        Texture2D GetIcon();


    }
}
