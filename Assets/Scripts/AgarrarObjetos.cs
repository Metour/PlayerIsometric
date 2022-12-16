using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarObjetos : MonoBehaviour
{
    public bool isPickable = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "InteractionZone")
        {
            other.gameObject.GetComponentInParent<ThirdPersonController>().objectToPick = this.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "InteractionZone")
        {
            other.gameObject.GetComponentInParent<ThirdPersonController>().objectToPick = null;
        }
    }
}