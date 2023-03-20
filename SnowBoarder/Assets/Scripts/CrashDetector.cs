using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    #region EVENTS
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            Debug.Log("You bonk your head on the ground");
        }
    }
    #endregion
}
