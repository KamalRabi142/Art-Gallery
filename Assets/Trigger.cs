using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject infoPanel;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered trigger by: " + other.name);  // Moved outside the tag check for full visibility

        if (other.CompareTag("Player"))
        {
            Debug.Log("Tag is Player — showing panel.");
            infoPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited trigger by: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Tag is Player — hiding panel.");
            infoPanel.SetActive(false);
        }
    }
}
