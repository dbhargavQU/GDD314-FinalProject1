using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpeakerController : MonoBehaviour
{
    public GameObject socket;
    public GameObject spawnObject1;
    public GameObject spawnObject2;

    private bool isPlaced = false;

    void Update()
    {
        if (!isPlaced)
        {
            if (Vector3.Distance(transform.position, socket.transform.position) < 0.1f)
            {
                isPlaced = true;
                spawnObject1.SetActive(true);
                spawnObject2.SetActive(true);
            }
        }
    }
}
