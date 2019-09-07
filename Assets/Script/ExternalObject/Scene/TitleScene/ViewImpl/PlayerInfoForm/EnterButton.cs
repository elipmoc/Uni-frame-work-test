using Script.Domain.Scene.TitleScene.View.PlayerInfoForm;
using UniFrameWork.Domain.Core.UniEvent;
using UnityEngine;

namespace Script.ExternalObject.Scene.TitleScene.ViewImpl.PlayerInfoForm
{
    public class EnterButton : MonoBehaviour, IEnterButton
    {
        readonly UniEventNoArg entered = new UniEventNoArg();
        public IUniEventNoArgSubscriber Entered => entered;

        public void OnClick()
        {
            entered.Raise();
        }
    }
}