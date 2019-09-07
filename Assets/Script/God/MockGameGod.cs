using Script.BigBang;
using Script.BigBang.SceneCreatorCreator;
using Script.Domain;
using UniFrameWork.BigBang.Core;
using UniFrameWork.GameSystem.Core.Scene;
using UnityEngine;

namespace Script.God
{
    //ゲームの全てのはじまり、神
    //GameSceneから開始するモック用
    public class MockGameGod : MonoBehaviour
    {
        [SerializeField] SceneChangerCreator sceneChangerCreator;
        [SerializeField] GameSceneCreatorCreator gameSceneCreatorCreator;

        SceneManager sceneManager;

        void Awake()
        {
            DontDestroyOnLoad(gameObject);
            var sceneChanger = sceneChangerCreator.Create();
            var titleSceneCreator = gameSceneCreatorCreator.Create(new PlayerName("モック用のゲームシーン"));
            sceneManager = new SceneManagerCreator(titleSceneCreator).Create();
            sceneChanger.ChangedScene.Subscribe(sceneManager.SetScene);
        }

        void Update()
        {
            sceneManager.Update();
        }
    }
}