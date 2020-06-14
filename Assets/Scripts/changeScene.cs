using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

	public string sceneName;

    public AudioSource audioSource;

    public float audioTime;

    [SerializeField] private v_gameplay gameplay;


    //public float TIME_LIMIT = 3F;

    // private float timer = 0F;



    // Update is called once per frame
    void Update()
    {
        // this.timer += Time.deltaTime;

        // if (this.timer >= TIME_LIMIT){
        // SceneManager.LoadScene(sceneName);
        //}
        SpeechScene();
        MainMenu();
    }

    private void SpeechScene ()
    {

        if (audioSource.time >= audioTime)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void MainMenu()
    {
        if (gameplay.home== true && OVRInput.GetUp(OVRInput.Button.Three))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
