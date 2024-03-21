using BepInEx;
using POKModManager;

namespace Mod_Template
{
    [BepInPlugin("Unknown.ModTemplate", "Mod Template", "1.0.0")]
    public class Main : BaseUnityPlugin
    {
        public void Start()
        {
            POKManager.RegisterMod(new Mod(), "Template mod", "1.0.0", "This is a template mod");
        }
    }
}
