using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private ActionController _actionController;

    private float _xAxis;
    private bool _isJumping;

    public float XAxis => _xAxis;

    public void Update()
    {
        ReadInput();
        ReactOnInput();
    }

    private void ReadInput()
    {
        _xAxis = Input.GetAxis("Horizontal");

        _isJumping = Input.GetKeyDown(KeyCode.Space);
    }

    private void ReactOnInput()
    {
        if (_xAxis != 0 && _isJumping == false)
        {
            _actionController.Move(_xAxis);
        }
        
        if (_isJumping)
        {
            _actionController.Jump();
        }
    }
}
