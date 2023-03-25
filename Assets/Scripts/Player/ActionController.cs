using UnityEngine;

public class ActionController : MonoBehaviour
{
    [SerializeField] private MoveController _moveController;
    [SerializeField] private JumpController _jumpController;
    [SerializeField] private PlayerResources _playerResources;

    public void Move(float xAxis)
    {
        if (_jumpController.IsJumping == false)
        {
            _moveController.Move(xAxis, _playerResources.IsSeeRight);
        }
    }

    public void Jump()
    {
        if (_playerResources.OnGround)
        {
            _jumpController.Jump(_playerResources.IsSeeRight);
        }
    }

    public void CollectBonus(Bonus bonus)
    {
        _playerResources.CollectBonus(bonus);
    }
}
