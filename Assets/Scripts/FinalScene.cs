using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    [SerializeField] private string sceneName = "End";
    [SerializeField] private GameObject finalSocket;

    private bool isTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!isTriggered && other.gameObject == finalSocket)
        {
            isTriggered = true;
            SceneManager.LoadScene(sceneName);
        }
    }
}
