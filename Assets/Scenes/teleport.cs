using UnityEngine;

public class TeleportTutorialZone : MonoBehaviour
{
    public TeleportTutorialZone nextZone;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        gameObject.SetActive(false);

        if (nextZone != null)
            nextZone.gameObject.SetActive(true);
        else
            TutorialManager.Instance.OnTutorialComplete();
    }
}