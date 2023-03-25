using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private JumpController _jumpController;

    private void Start()
    {
        _jumpController.IsJumped += StartJumpAnimation;
    }

    private void Update()
    {
        _animator.SetFloat("XAxis", Mathf.Abs(_inputManager.XAxis));
    }

    private void StartJumpAnimation(bool isJumping)
    {
        _animator.SetBool("IsJumping", isJumping);
    }
}
