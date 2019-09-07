using Script.Domain;
using Script.Domain.Scene.TitleScene.View.PlayerInfoForm;
using UniFrameWork.Domain.Core.UniEvent;

namespace Script.GameSystem.Scene.TitleScene
{
    public class PlayerInfoForm
    {
        readonly UniEvent<PlayerName> submittedPlayerName = new UniEvent<PlayerName>();

        public IUniEventSubscriber<PlayerName> SubmittedPlayerName => submittedPlayerName;

        public PlayerInfoForm(IEnterButton enterButton, IPlayerNameInputView playerNameInputView)
        {
            enterButton.Entered.Subscribe(
                () =>
                {
                    submittedPlayerName.Raise(
                        playerNameInputView.GetText()
                    );
                }
            );
        }
    }
}