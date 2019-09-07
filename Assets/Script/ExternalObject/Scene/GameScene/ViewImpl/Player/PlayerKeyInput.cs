using Script.Domain.Scene.GameScene.View.Player;
using UniFrameWork.Domain.Core.UniEvent;
using UnityEngine;

namespace Script.ExternalObject.Scene.GameScene.ViewImpl.Player
{
    public class PlayerKeyInput : IPlayerInput
    {
        readonly UniEvent<Direction> inputtedMove = new UniEvent<Direction>();
        public IUniEventSubscriber<Direction> InputtedMove => inputtedMove;

        public void Update()
        {
            if (Input.GetKey(KeyCode.W))
                inputtedMove.Raise(Direction.Up);
            else if (Input.GetKey(KeyCode.A))
                inputtedMove.Raise(Direction.Left);
            else if (Input.GetKey(KeyCode.S))
                inputtedMove.Raise(Direction.Down);
            else if (Input.GetKey(KeyCode.D))
                inputtedMove.Raise(Direction.Right);
        }
    }
}