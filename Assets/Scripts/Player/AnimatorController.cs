using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerResources _playerResources;
    
    private void Update()
    {
        _animator.SetFloat("XAxis", Mathf.Abs(_inputManager.XAxis));
        _animator.SetBool("IsJumping", !_playerResources.OnGround);
    }
}
