using System;

namespace UniFrameWork.Domain.Core
{
    //任意のDispose処理を設定できるDisposableなクラス
    public class DisposableAction : IDisposable
    {
        readonly Action e;
        public DisposableAction(Action e) => this.e = e;
        public void Dispose() => e();
    }
}