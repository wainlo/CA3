using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public static TutorialManager Instance;

    [Header("Teleport Tutorial")]
    public GameObject teleportZone1;

    [Header("Completion UI")]
    public GameObject congratsUI; // reference to placed Spatial UI

    private void Awake()
    {
        Instance = this;
    }

    public void OnAllWalkTriggersComplete()
    {
        // Enable first teleport zone
        teleportZone1.SetActive(true);
    }

    public void OnTutorialComplete()
    {
        // Show the already-placed Spatial UI
        congratsUI.SetActive(true);
    }
}