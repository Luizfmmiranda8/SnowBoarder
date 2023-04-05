using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] float delay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    #endregion
    #region EVENTS
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground")
        {
            crashEffect.Play();
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
