using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class SplashScreenHandler : MonoBehaviour
{
    [SerializeField] private VideoPlayer CLCSplash;
    private bool hasPlayed = false;
    private void Update()
    {
        CLCSplash.loopPointReached += LoadNextScene;
    }

    private void LoadNextScene(VideoPlayer vp)
    {
        if (!hasPlayed)
        {
            CLCSplash.loopPointReached -= LoadNextScene;
            hasPlayed = true;
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
