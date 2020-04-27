using System;

namespace UniFrameWork.Domain.Core.UniEvent
{
    //イベントを購読する専用のインタフェース
    public interface IUniEventNoArgSubscriber
    {
        //イベント登録
        IDisposable Subscribe(Action handler);
    }
}