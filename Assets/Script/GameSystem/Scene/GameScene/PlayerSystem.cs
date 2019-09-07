using Script.Domain.Scene.GameScene.View.Player;
using UniFrameWork.Domain.Core;

namespace Script.GameSystem.Scene.GameScene
{
    public class PlayerSystem : IGameSystem
    {
        readonly IPlayerInput playerInput;

        public PlayerSystem(IPlayer player, IPlayerInput playerInput)
        {
            playerInput.InputtedMove.Subscribe(player.Move);
            this.playerInput = playerInput;
        }

        public void Dispose()
        {
        }

        public void Update()
        {
            playerInput.Update();
        }
    }
}