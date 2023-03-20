using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    #region EVENTS
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Debug.Log("You finish"); 
        }
    }
    #endregion
}
