using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace PROJECT_SLUG
{
    /// <summary>The mod entry point.</summary>
    internal sealed class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            Monitor.Log("meow!", LogLevel.Info);
        }

    }
}
