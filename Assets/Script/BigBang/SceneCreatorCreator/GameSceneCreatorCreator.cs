using Script.Domain;
using Script.ExternalObject.Scene.GameScene.ViewImpl.Player;
using Script.ExternalObject.Scene.GameScene.ViewImpl.Ui;
using Script.GameSystem.Scene.GameScene;
using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;
using UnityEngine;

namespace Script.BigBang.SceneCreatorCreator
{
    public class GameSceneCreatorCreator : MonoBehaviour, ISceneCreatorCreator<PlayerName>
    {
        [SerializeField] PlayerNameTextView playerNameTextView;
        [SerializeField] Player player;

        public SceneCreator Create(PlayerName playerName)
        {
            return () =>
            {
                var instance = Instantiate(this);
                return new GameScene(
                    instance.playerNameTextView,
                    playerName,
                    new PlayerSystem(instance.player, new PlayerKeyInput())
                );
            };
        }
    }
}