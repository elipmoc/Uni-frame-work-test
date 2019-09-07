using Script.Domain;
using Script.Domain.Scene.GameScene.View;
using UnityEngine;
using UnityEngine.UI;

namespace Script.ExternalObject.Scene.GameScene.ViewImpl.Ui
{
    public class PlayerNameTextView : MonoBehaviour, IPlayerNameTextView
    {
        [SerializeField] Text text;

        public void SetPlayerName(PlayerName playerName)
        {
            text.text = playerName.Name;
        }
    }
}