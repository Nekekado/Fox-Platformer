using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public void Move(float xAxis, bool IsSeeRight)
    {
        if (xAxis > 0f && IsSeeRight == false)
        {
            Rotate();
        }

        if (xAxis < 0f && IsSeeRight)
        {
            Rotate();
        }
        
        Vector2 direction = new Vector2(xAxis * _speed, _rigidbody2D.velocity.y);
        _rigidbody2D.velocity = direction;
    }

    private void Rotate()
    {
        Vector2 rotatedScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        transform.localScale = rotatedScale;
    }
}
