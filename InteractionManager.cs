using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    TVManager tVManager;
    private void Start()
    {
        tVManager = FindObjectOfType<TVManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TV"))
        {
            tVManager.isPlayerCloseToTV = true;
            tVManager.controlsCanvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("TV"))
        {
            tVManager.isPlayerCloseToTV = false;
            tVManager.controlsCanvas.SetActive(false);
        }
    }
}
