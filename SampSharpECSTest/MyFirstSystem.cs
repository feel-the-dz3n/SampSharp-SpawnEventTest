using System;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using SampSharp.Entities.SAMP.Commands;

namespace SampSharpECSTest
{
    public class MyFirstSystem : ISystem
    {
        [Event]
        public void OnGameModeInit(IServerService serverService)
        {
            Console.WriteLine("My first ECS game mode is initializing.");

            serverService.AddPlayerClass(8, new Vector3(0, 0, 7), 0);
            serverService.SetGameModeText("My First Game Mode");
        }

        [PlayerCommand("hello")]
        public void MyFirstCommand(Player player)
        {
            player.SendClientMessage($"Hello, {player.Name}!");
        }

        [Event]
        public void OnPlayerSpawn(Player player)
        {
            player.SendClientMessage("You spawned");
        }

        [Event]
        public void OnPlayerRequestSpawn(Player player)
        {
            player.SendClientMessage("You request spawn");
        }
    }
}
