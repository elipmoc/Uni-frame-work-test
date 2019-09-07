using Script.Domain;
using Script.Domain.Scene.TitleScene.View.PlayerInfoForm;
using UnityEngine;
using UnityEngine.UI;

namespace Script.ExternalObject.Scene.TitleScene.ViewImpl.PlayerInfoForm
{
    public class PlayerNameInputView : MonoBehaviour, IPlayerNameInputView
    {
        [SerializeField] Text text;

        public PlayerName GetText()
        {
            return new PlayerName(text.text);
        }
    }
}