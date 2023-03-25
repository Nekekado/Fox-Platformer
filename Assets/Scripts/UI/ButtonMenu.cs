using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    [SerializeField] private int _numberMenuScene;

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(_numberMenuScene);
    }
}
