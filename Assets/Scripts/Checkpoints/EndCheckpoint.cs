using UnityEngine;

public class EndCheckpoint : MonoBehaviour
{
    [SerializeField] private GameObject _winWindow;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _winWindow.SetActive(true);
        }
    }
}
