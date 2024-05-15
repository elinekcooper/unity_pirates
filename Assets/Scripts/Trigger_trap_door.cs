using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_trap_door : MonoBehaviour
{
    public Animator playerAnim;
    public Animator doorAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
        private void OnTriggerEnter(Collider other)
    {
        playerAnim.SetTrigger("death");
        doorAnim.SetTrigger("doorOpen");

    }
    
}
