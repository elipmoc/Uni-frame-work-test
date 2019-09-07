using Script.BigBang.SceneCreatorCreator;
using Script.Domain;
using UnityEngine;

namespace Script.BigBang
{
    public class SceneChangerCreator : MonoBehaviour
    {
        [SerializeField] TitleSceneCreatorCreator titleSceneCreatorCreator;
        [SerializeField] GameSceneCreatorCreator gameSceneCreatorCreator;

        public SceneChanger Create()
        {
            return new SceneChanger(titleSceneCreatorCreator, gameSceneCreatorCreator);
        }
    }
}