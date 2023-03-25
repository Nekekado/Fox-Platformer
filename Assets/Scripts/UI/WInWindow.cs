using TMPro;
using UnityEngine;

public class WInWindow : MonoBehaviour
{
    [SerializeField] private PlayerResources _playerResources;
    [SerializeField] private TMP_Text _tmpText;

    private void OnEnable()
    {
        _tmpText.text = "Ваш счёт:" + _playerResources.Score.ToString();
    }
}
