using System.Diagnostics.CodeAnalysis;
using RoR2.UI;
using RoR2.UI.MainMenu;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SwE.Patches;

internal static class EarlyAccessDisclaimerPatch
{
    private const string Token = "INDEV_DISCLAIMER";

    [SuppressMessage("Member Access", "Publicizer001:Accessing a member that was not originally public")]
    public static void Apply()
    {
        SceneManager.sceneLoaded += (scene, _) =>
        {
            if (scene.name != "title") return;

            var warningText =  GameObject.Find("MainMenu").transform.Find("MENU: EA Warning/FirstTimeEAWarning/Panel/FaderAndScroller(JUICED)/ContentPanel/TextPanel/WarningText");
            warningText.GetComponent<LanguageTextMeshController>().token = Token;
        };

        On.RoR2.UI.MainMenu.MainMenuController.StartManaged += (orig, self) =>
        {
            if (!MainMenuController.eaWarningShown && !MainMenuController.eaMessageSkipConVar.value)
            {
                MainMenuController.eaWarningShown = true;
                self.desiredMenuScreen = self.EAwarningProfileMenu;
            }
            
            orig(self);
        };
    }
}