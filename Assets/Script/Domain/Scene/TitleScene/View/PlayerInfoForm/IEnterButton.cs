using UniFrameWork.Domain.Core.UniEvent;

namespace Script.Domain.Scene.TitleScene.View.PlayerInfoForm
{
    public interface IEnterButton
    {
        IUniEventNoArgSubscriber Entered { get; }
    }
}