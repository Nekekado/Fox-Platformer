using System;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    [SerializeField] private ActionController _actionController;
    
    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Bonus"))
        {
            Bonus bonus = collision2D.gameObject.GetComponent<Bonus>();
            _actionController.CollectBonus(bonus);
        }
    }
}
