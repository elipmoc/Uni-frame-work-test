using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;
using UniFrameWork.Domain.Core.UniEvent;

namespace Script.Domain
{
    public class SceneChanger
    {
        readonly UniEvent<SceneCreator> changedScene = new UniEvent<SceneCreator>();

        readonly ISceneCreatorCreator<SceneChanger> titleSceneCreatorCreator;
        readonly ISceneCreatorCreator<PlayerName> gameSceneCreatorCreator;

        public IUniEventSubscriber<SceneCreator> ChangedScene => changedScene;

        public SceneChanger(
            ISceneCreatorCreator<SceneChanger> titleSceneCreatorCreator,
            ISceneCreatorCreator<PlayerName> gameSceneCreatorCreator
        )
        {
            this.titleSceneCreatorCreator = titleSceneCreatorCreator;
            this.gameSceneCreatorCreator = gameSceneCreatorCreator;
        }

        public void ChangeTitleScene()
        {
            changedScene.Raise(titleSceneCreatorCreator.Create(this));
        }

        public void ChangeGameScene(PlayerName playerName)
        {
            changedScene.Raise(gameSceneCreatorCreator.Create(playerName));
        }
    }
}