namespace UniFrameWork.Domain.Core.Scene
{
    //ISceneを返す関数のデリゲート
    public delegate IScene SceneCreator();

    //現在のSceneを管理するクラス
    public struct CurrentSceneOwner
    {
        IScene currentScene;
        readonly IUnitySceneController unitySceneController;

        //初期シーンのセット
        public CurrentSceneOwner(SceneCreator sceneCreator,
            IUnitySceneController unitySceneController)
        {
            this.unitySceneController = unitySceneController;
            unitySceneController.SetScene();
            currentScene = sceneCreator();
        }

        //現在のシーンを変更

        public void ChangeCurrentScene(SceneCreator sceneCreator)
        {
            currentScene.Dispose();
            unitySceneController.SetScene();
            currentScene = sceneCreator();
        }

        //シーンの更新処理を呼び出し

        public void CurrentSceneUpdate()
        {
            currentScene.Update();
        }

        //破棄

        public void CurrentSceneDispose()
        {
            currentScene.Dispose();
        }
    }
}