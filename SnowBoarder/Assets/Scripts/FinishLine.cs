using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] float delay = 1f;
    #endregion
    #region EVENTS
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
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
