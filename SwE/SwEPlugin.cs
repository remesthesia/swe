using BepInEx;
using SeLib.API;
using SwE.Patches;

namespace SwE
{
    [BepInDependency(SeLib.PluginInfo.GUID, SeLib.PluginInfo.Version)]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public sealed class SwEPlugin : BaseRoR2Plugin<SwEPlugin>
    {
        public override void OnRegister()
        {
            SteamBuildIDLabelPatch.Apply();
            WindowTitlePatch.Apply();
        }
    }
}
