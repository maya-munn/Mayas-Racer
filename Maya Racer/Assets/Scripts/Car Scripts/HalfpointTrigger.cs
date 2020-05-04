using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfpointTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject halfpointTrigger;

    public void OnTriggerEnter(Collider other)
    {
        lapCompleteTrigger.SetActive(true);
        halfpointTrigger.SetActive(false);
    }
}
