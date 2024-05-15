using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_ball : MonoBehaviour
{
     private void OnTriggerEnter (Collider other)
    {
        Debug.Log ("Trigger: " + other.gameObject.name);
        
        GameObject[] allObjects = GameObject.FindGameObjectsWithTag("ballTag");
        
        foreach(GameObject obj in allObjects) {
        
            Destroy(obj);
        }
        
    } 
}



//PlayerArmature