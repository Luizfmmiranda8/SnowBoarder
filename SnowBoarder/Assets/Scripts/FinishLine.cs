using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    #endregion
    #region EVENTS
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", delay);
        }
    }
    #endregion

    #region METHODS
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    #endregion
}
