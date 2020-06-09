using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    [SerializeField]
    private int _timeToWait = 4;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        // If on the Splash Screen, Start wait coroutine.
        // Scene index is changed in the build settings
        if (currentSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    // Wait, and then load
    private IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(_timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        // Use SceneManager to change scenes
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
