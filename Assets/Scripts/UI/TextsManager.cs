using TMPro;
using UnityEngine;

public class TextsManager : MonoBehaviour
{
    [SerializeField] private PlayerResources _playerResources;
    [SerializeField] private TMP_Text _text;

    private void Start()
    {
        UpdateTexts();
    }

    public void Display()
    {
        UpdateTexts();
    }

    private void UpdateTexts()
    {
        _text.text = "Счёт:" + _playerResources.Score.ToString();
    }
}
