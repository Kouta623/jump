using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log(other.gameObject.name + " ‚ªÚG‚µ‚½");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " ‚ª—£‚ê‚½");
    }
}