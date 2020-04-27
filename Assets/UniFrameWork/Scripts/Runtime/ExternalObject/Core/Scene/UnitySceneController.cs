using UniFrameWork.Domain.Core.Scene;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UniFrameWork.ExternalObject.Core.Scene
{
    public class UnitySceneController : IUnitySceneController
    {
        public void SetScene()
        {
            foreach (var rootGameObject in SceneManager.GetActiveScene().GetRootGameObjects())
            {
                Object.Destroy(rootGameObject);
            }
        }
    }
}