using Script.BigBang;
using Script.BigBang.SceneCreatorCreator;
using UniFrameWork.BigBang.Core;
using UniFrameWork.GameSystem.Core.Scene;
using UnityEngine;

namespace Script.God
{
    //ゲームの全てのはじまり、神
    public class MainGod : MonoBehaviour
    {
        [SerializeField] SceneChangerCreator sceneChangerCreator;
        [SerializeField] TitleSceneCreatorCreator titleSceneCreatorCreator;

        SceneManager sceneManager;

        void Awake()
        {
            DontDestroyOnLoad(gameObject);
            var sceneChanger =sceneChangerCreator.Create();
            var titleSceneCreator = titleSceneCreatorCreator.Create(sceneChanger);
            sceneManager = new SceneManagerCreator(titleSceneCreator).Create();
            sceneChanger.ChangedScene.Subscribe(sceneManager.SetScene);
        }

        void Update()
        {
            sceneManager.Update();
        }
    }
}