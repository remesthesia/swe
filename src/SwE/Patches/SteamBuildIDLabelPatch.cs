using TMPro;

namespace SwE.Patches;

internal static class SteamBuildIDLabelPatch
{
    private const string DebugLabel = "-debug";
    
    public static void Apply()
    {
        On.RoR2.UI.SteamBuildIdLabel.Start += (_, self) =>
        {
            var text = $"{SwEPlugin.Instance.Name} ver. {SwEPlugin.Instance.Version}";
            text += SwEPlugin.Instance.IsDebug ? $"{DebugLabel}" : "";
            
            self.GetComponent<TextMeshProUGUI>().text = text;
        };
    }
}