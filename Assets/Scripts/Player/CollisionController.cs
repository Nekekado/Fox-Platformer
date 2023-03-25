using UnityEngine;

public class CollisionController : MonoBehaviour
{
    [SerializeField] private ActionController _actionController;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Bonus"))
        {
            Bonus bonus = collision2D.gameObject.GetComponent<Bonus>();
            _actionController.CollectBonus(bonus);
        }
    }
}
