using System;

namespace UniFrameWork.Domain.Core
{
    public interface IGameSystem : IDisposable
    {
        //毎フレームの更新処理
        void Update();
    }
}