using TMPro;

namespace SwE.Patches;

internal static class SteamBuildIDLabelPatch
{
    public static void Apply()
    {
        On.RoR2.UI.SteamBuildIdLabel.Start += (_, self) =>
        {
            var text = $"{SwEPlugin.Instance.Name} ver. {SwEPlugin.Instance.Version}";
            text += SwEPlugin.Instance.IsDebug ? " [INDEV]" : "";
            
            self.GetComponent<TextMeshProUGUI>().text = text;
        };
    }
}