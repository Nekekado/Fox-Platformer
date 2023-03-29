using System;
using System.Collections;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public event Action<bool> IsJumped;
    
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _jumpForce = 4f;
    

    private bool _isJumping;

    public bool IsJumping => _isJumping;
    
    public void Jump(bool isSeeRight)
    {
        _rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }
}
