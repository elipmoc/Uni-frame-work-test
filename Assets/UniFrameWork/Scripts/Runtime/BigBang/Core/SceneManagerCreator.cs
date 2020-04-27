using UniFrameWork.Domain.Core.Scene;
using UniFrameWork.ExternalObject.Core.Scene;
using UniFrameWork.GameSystem.Core.Scene;

namespace UniFrameWork.BigBang.Core
{
    //SceneManagerのファクトリー
    public class SceneManagerCreator
    {
        readonly SceneCreator firstSceneCreator;

        public SceneManagerCreator(SceneCreator sceneCreator)
        {
            firstSceneCreator = sceneCreator;
        }

        public SceneManager Create()
        {
            return new SceneManager(firstSceneCreator, new UnitySceneController());
        }
    }
}