using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class changeScene_load : MonoBehaviour {

    public string loadScene;
    public string speechScene;

    public AudioSource audioSource;

    public float audioTime;

    // Update is called once per frame
    void Update()
    {
        LoadingScene();
        SpeechScene();
    }

    private void LoadingScene()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            SceneManager.LoadScene(speechScene);
        }
    }

    private void SpeechScene()
    {

        if (audioSource.time >= audioTime)
        {
            SceneManager.LoadScene(loadScene);
        }
    }

}
