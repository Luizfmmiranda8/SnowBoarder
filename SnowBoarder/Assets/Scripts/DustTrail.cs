using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] ParticleSystem dustEffect;
    #endregion
    #region EVENTS
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dustEffect.Play();
        }        
    }

    void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Ground")
        {
            dustEffect.Stop();
        }       
    }
    #endregion
}
