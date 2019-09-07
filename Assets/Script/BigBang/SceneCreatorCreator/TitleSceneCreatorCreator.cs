using Script.Domain;
using Script.ExternalObject.Scene.TitleScene.ViewImpl.PlayerInfoForm;
using Script.GameSystem.Scene.TitleScene;
using UniFrameWork.Domain.Core;
using UniFrameWork.Domain.Core.Scene;
using UnityEngine;

namespace Script.BigBang.SceneCreatorCreator
{
    public class TitleSceneCreatorCreator : MonoBehaviour, ISceneCreatorCreator<SceneChanger>
    {
        [SerializeField] EnterButton enterButton;
        [SerializeField] PlayerNameInputView playerNameInputView;

        public SceneCreator Create(SceneChanger sceneChanger)
        {
            return () =>
            {
                var instance = Instantiate(this);
                return new TitleScene(
                    new PlayerInfoForm(instance.enterButton, instance.playerNameInputView),
                    sceneChanger
                );
            };
        }
    }
}