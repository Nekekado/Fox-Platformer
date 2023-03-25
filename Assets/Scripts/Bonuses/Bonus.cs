using System.Collections;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private int _scores;
    [SerializeField] private Animator _animator;
    [SerializeField] private AnimationClip _collectAnimation;

    public int Scores => _scores;

    public void Die()
    {
        StartCoroutine(DieCoroutine());
    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    private IEnumerator DieCoroutine()
    {
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
        _animator.SetTrigger("Dead");
        yield return new WaitForSeconds(_collectAnimation.length);
        Destroy(gameObject);
    }
}
