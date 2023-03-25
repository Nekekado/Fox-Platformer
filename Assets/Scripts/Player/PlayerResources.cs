using UnityEngine;

public class PlayerResources : MonoBehaviour
{
    [Header("Settings for GroundCheck")]
    [SerializeField] private Transform feetPos;
    [SerializeField] private LayerMask layerOfGround;
    [SerializeField] private float circleRadius;

    [Header("Access to scripts")] 
    [SerializeField] private TextsManager _textsManager;

    private bool _onGround;
    private bool _isSeeRight;
    private int _score;

    public bool OnGround => _onGround;
    public bool IsSeeRight => _isSeeRight;
    public int Score => _score;

    private void Update()
    {
        CheckRotation();
        CheckGround();
    }

    private void CheckGround()
    {
        _onGround = Physics2D.OverlapCircle(feetPos.position, circleRadius, layerOfGround);
    }
    
    private void CheckRotation()
    {
        if (transform.localScale.x > 0f)
        {
            _isSeeRight = true;
        }

        if (transform.localScale.x < 0f)
        {
            _isSeeRight = false;
        }
    }

    public void CollectBonus(Bonus bonus)
    {
        bonus.Die();
        _score += bonus.Scores;
        _textsManager.Display();
    }
}
