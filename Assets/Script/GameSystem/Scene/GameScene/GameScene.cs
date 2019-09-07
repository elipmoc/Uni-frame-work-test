using Script.Domain;
using Script.Domain.Scene.GameScene.View;
using UniFrameWork.Domain.Core.Scene;

namespace Script.GameSystem.Scene.GameScene
{
    public class GameScene : IScene
    {
        readonly PlayerSystem playerSystem;

        public GameScene(IPlayerNameTextView playerNameTextView, PlayerName playerName, PlayerSystem playerSystem)
        {
            playerNameTextView.SetPlayerName(playerName);
            this.playerSystem = playerSystem;
        }

        public void Dispose()
        {
        }

        public void Update()
        {
            playerSystem.Update();
        }
    }
}