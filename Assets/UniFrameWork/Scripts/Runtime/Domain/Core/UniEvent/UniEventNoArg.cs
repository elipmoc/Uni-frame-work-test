using System;

namespace UniFrameWork.Domain.Core.UniEvent
{
    //イベント管理クラス

    public class UniEventNoArg : IUniEventNoArgSubscriber
    {
        event Action e;

        //イベント登録の実装
        public IDisposable Subscribe(Action handler)
        {
            e += handler;
            return new DisposableAction(() => e -= handler);
        }

        //イベント発火
        public void Raise() => e?.Invoke();
    }
}