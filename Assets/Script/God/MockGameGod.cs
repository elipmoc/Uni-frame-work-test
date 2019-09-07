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
        [SerializeField] GameSceneCreatorCreator gameSceneCreatorCreator;

        SceneManager sceneManager;

        void Awake()
        {
            DontDestroyOnLoad(gameObject);
            var titleSceneCreator = gameSceneCreatorCreator.Create(new PlayerName("モック用のゲームシーン"));
            sceneManager = new SceneManagerCreator(titleSceneCreator).Create();
        }

        void Update()
        {
            sceneManager.Update();
        }
    }
}