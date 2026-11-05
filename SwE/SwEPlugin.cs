using BepInEx;
using SeLib.API;

namespace SwE
{
    [BepInDependency(SeLib.PluginInfo.GUID, SeLib.PluginInfo.Version)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public sealed class SwEPlugin : BaseRoR2Plugin<SwEPlugin>
    {
        public override void OnRegister()
        {
            
        }
    }
}
