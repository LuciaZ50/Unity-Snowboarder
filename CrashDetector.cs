using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", 1f);
           
        }
    }
        
    void ReloadScene()
        {
            SceneManager.LoadScene(0);    

        }
    
}
