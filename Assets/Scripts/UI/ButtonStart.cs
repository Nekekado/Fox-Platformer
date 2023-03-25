using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStart : MonoBehaviour
{
    [SerializeField] private int _numberLevelScene;

    public void StartGame()
    {
        SceneManager.LoadScene(_numberLevelScene);
    }
}
