using GTANetworkAPI;

namespace crimeaserver
{
    internal class Events : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        private void OnPlayerConnected(Player player)
        {
            player.SendChatMessage("~b~Hello on ~g~Crimea RP!");
        }

        [ServerEvent(Event.PlayerSpawn)]
        private void OnPlayerSpawn(Player player)
        {
            player.Health = 50;
            player.Armor = 50;
        }
    }
}
