using UnityEngine;

public class DismissUI : MonoBehaviour
{
    public void ClosePanel()
    {
        gameObject.SetActive(false);
    }
}