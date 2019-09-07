using UniFrameWork.Domain.Core.Scene;

namespace UniFrameWork.Domain.Core
{
    //SceneCreatorを生成するファクトリー
    public interface ISceneCreatorCreator<in TArg>
    {
        SceneCreator Create(TArg arg);
    }
}