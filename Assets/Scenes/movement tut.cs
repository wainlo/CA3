using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public TutorialTrigger nextTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        // Disable this trigger
        gameObject.SetActive(false);

        // Enable next trigger
        if (nextTrigger != null)
            nextTrigger.gameObject.SetActive(true);
        else
            TutorialManager.Instance.OnAllWalkTriggersComplete();
    }
}