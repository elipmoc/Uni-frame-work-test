using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;

namespace UniFrameWork.GameSystem.Core.Scene
{
    public class SceneManager : IGameSystem
    {
        CurrentSceneOwner currentSceneOwner;

        public SceneManager(SceneCreator firstSceneCreator,
            IUnitySceneController unitySceneController)
        {
            currentSceneOwner = new CurrentSceneOwner(firstSceneCreator, unitySceneController);
        }

        public void Update()
        {
            currentSceneOwner.CurrentSceneUpdate();
        }

        public void SetScene(SceneCreator sceneCreator)
        {
            currentSceneOwner.ChangeCurrentScene(sceneCreator);
        }

        public void Dispose()
        {
            currentSceneOwner.CurrentSceneDispose();
        }
    }
}