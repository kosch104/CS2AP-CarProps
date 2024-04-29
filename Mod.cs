using Colossal.Logging;
using Game;
using Game.Modding;

namespace AP_CarProps
{
    public class Mod : IMod
    {
        public static ILog log = LogManager.GetLogger($"AssetPacksManager.Packs")
            .SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            log.Info("Loading Asset Pack " + nameof(AP_CarProps));
        }

        public void OnDispose()
        {
        }
    }
}