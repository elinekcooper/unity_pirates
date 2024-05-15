using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_arrow2 : MonoBehaviour
{
     private void OnTriggerEnter (Collider other)
    {
        Debug.Log ("Trigger: " + other.gameObject.name);
        
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("arrow2Tag");
        
        foreach(GameObject obj in allObjects) {
        
            Destroy(obj);
        }
        
    } 
}