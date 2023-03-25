using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverWindow;
    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Player"))
        {
            _gameOverWindow.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
