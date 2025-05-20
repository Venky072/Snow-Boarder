using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{ 
    [SerializeField] float delay = 2.5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other) 
    {
    if(other.tag  == "Player")
    {
        Debug.Log("Finished");
        finishEffect.Play();
        GetComponent<AudioSource>().Play();
        Invoke("reloadScene",delay);
    } 
 }
 void reloadScene()
 {
      SceneManager.LoadScene(0);
 }
}
