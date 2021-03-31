using PulsarPluginLoader;

namespace virus_fix
{
    public class Plugin : PulsarPlugin
    {
        public override string Version => "1.0";

        public override string Author => "pokegustavo";

        public override string ShortDescription => "Fixes virus in cargo glitch";

        public override string Name => "Virus Fix";

        public override string HarmonyIdentifier()
        {
            return "pokegustavo.Virus_Fix";
        }
    }
}