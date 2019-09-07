using Script.Domain;
using UniFrameWork.Domain.Core.Scene;

namespace Script.GameSystem.Scene.TitleScene
{
    public class TitleScene : IScene
    {
        public TitleScene(PlayerInfoForm playerInfoForm, SceneChanger sceneChanger)
        {
            playerInfoForm.SubmittedPlayerName.Subscribe(sceneChanger.ChangeGameScene);
        }

        public void Dispose()
        {
        }

        public void Update()
        {
        }
    }
}