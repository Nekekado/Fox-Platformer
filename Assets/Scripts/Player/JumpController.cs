using System;
using System.Collections;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    public event Action<bool> IsJumped;
    
    [SerializeField] private AnimationCurve _animationCurveY;
    [SerializeField] private AnimationCurve _animationCurveX;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _duration;
    [SerializeField] private float _heigh;
    [SerializeField] private float _length;

    private bool _isJumping;

    public bool IsJumping => _isJumping;
    
    public void Jump(bool isSeeRight)
    {
        _isJumping = true;
        IsJumped?.Invoke(_isJumping);

        StartCoroutine(JumpCoroutine(transform.position, isSeeRight));
    }

    private IEnumerator JumpCoroutine(Vector2 startPosition, bool InRight)
    {
        for (float time = 0; time <= 1f; time += Time.fixedDeltaTime / _duration)
        {
            float yCurve = _animationCurveY.Evaluate(time) * _heigh;
            float xCurve = 0f;
            
            if (InRight)
            { 
                xCurve = _animationCurveX.Evaluate(time) * _length;
            }
            else
            { 
                xCurve = -_animationCurveX.Evaluate(time) * _length;
            }
            
            Vector2 direction = new Vector2(xCurve, yCurve);
            //Vector2 target = Vector2.Lerp(_rigidbody2D.position, direction, time); 
            
            
            _rigidbody2D.velocity = direction;
            //_rigidbody2D.position = target;

            yield return new WaitForFixedUpdate();
        }
        
        _isJumping = false;
        IsJumped?.Invoke(_isJumping);
    }
}
