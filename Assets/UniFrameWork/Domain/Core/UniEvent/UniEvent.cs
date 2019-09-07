using System;

namespace UniFrameWork.Domain.Core.UniEvent
{
    //イベント管理クラス
    public class UniEvent<TArg> : IUniEventSubscriber<TArg>
    {
        event Action<TArg> e;

        //イベント登録の実装
        public IDisposable Subscribe(Action<TArg> handler)
        {
            e += handler;
            return new DisposableAction(() => e -= handler);
        }

        //イベント発火
        public void Raise(TArg arg) => e?.Invoke(arg);
    }
}