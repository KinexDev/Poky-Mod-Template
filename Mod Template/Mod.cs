using POKModManager;

namespace Mod_Template
{
    class Mod : ModClass
    {
        public override void OnEnabled()
        {
            print("Template mod has been enabled!");
        }

        public override void OnDisabled()
        {
            print("Template mod has been disabled!");
        }
    }
}
