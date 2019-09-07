using UniFrameWork.Domain.Core.UniEvent;

namespace Script.Domain.Scene.GameScene.View.Player
{
    public interface IPlayerInput
    {
        IUniEventSubscriber<Direction> InputtedMove { get; }
        void Update();
    }
}