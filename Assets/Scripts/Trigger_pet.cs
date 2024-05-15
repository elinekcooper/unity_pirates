using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_pet : MonoBehaviour
{
    public Animator playerAnim;

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
        playerAnim.SetTrigger("pet");
    }
    
}
