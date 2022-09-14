using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerNextLevel : MonoBehaviour
{
    [SerializeField] public int sceneIndex;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ouch");
        
        SceneManager.LoadScene(sceneIndex);
    }
}
