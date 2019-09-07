using System;

namespace UniFrameWork.Domain.Core.UniEvent
{
    //イベントを購読する専用のインタフェース

    public interface IUniEventSubscriber<TArg>
    {
        //イベント登録
        IDisposable Subscribe(Action<TArg> handler);
    }
}