using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    public void SetPause()
    {
        Time.timeScale = 0;
    }

    public void UnsetPause()
    {
        Time.timeScale = 1;
    }
}
