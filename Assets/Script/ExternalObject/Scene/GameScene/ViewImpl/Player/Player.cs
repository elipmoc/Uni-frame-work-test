using System;
using Script.Domain.Scene.GameScene.View.Player;
using UnityEngine;

namespace Script.ExternalObject.Scene.GameScene.ViewImpl.Player
{
    public class Player : MonoBehaviour, IPlayer
    {
        [SerializeField] float speed;

        //移動処理。処理が複雑であれば、ドメインモデルとして切り出す。
        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    transform.position += Vector3.up * speed;
                    break;
                case Direction.Down:
                    transform.position += Vector3.down * speed;
                    break;
                case Direction.Left:
                    transform.position += Vector3.left * speed;
                    break;
                case Direction.Right:
                    transform.position += Vector3.right * speed;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), direction, null);
            }
        }
    }
}