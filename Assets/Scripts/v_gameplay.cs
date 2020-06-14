using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v_gameplay : MonoBehaviour {

    public static bool runInBackground;
    public Animator king;
    public AudioSource speech;
    public AudioSource speech2;
    public AudioSource speech3;
    public bool pause;

    [SerializeField] private TeleportCamera TeleportCamera;
    [SerializeField] private GameObject subtitles;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private GameObject hands;
    [SerializeField] private OVRPlayerController Player;
    [SerializeField] private aslController aslController;

    public Transform book;
    public Transform bookstartpos;

    public bool home;


    // Use this for initialization
    void Start ()
    {

        if (king == null)
        {
            king = GetComponent<Animator>();
        }

        if (speech == null)
        {
            speech = GetComponent<AudioSource>();
        }
        if (speech2 == null)
        {
            speech2 = GetComponent<AudioSource>();
        }
        if (speech3 == null)
        {
            speech3 = GetComponent<AudioSource>();
        }

        pause = false;

        if (speech.isPlaying == false)
        {
            speech.Play();
        }

        home = false;
    }
	
	// Update is called once per frame
	void Update () {

        Application.runInBackground = false;

        PauseExperience();

        ResumeExperience();
    }

    public void PauseExperience()
    {
        if (OVRInput.GetUp(OVRInput.Button.Start))
        {
            pause = !pause;
        }

        if (pause == true)
        {
//            Debug.Log("paused");
            king.enabled = false;
            if (speech.isPlaying == true)
            {
                speech.Pause();
            }
            if (speech2.isPlaying == true)
            {
                speech2.Pause();
            }
            if (speech3.isPlaying == true)
            {
                speech3.Pause();
            }
            subtitles.SetActive(false);
            TeleportCamera.enabled = false;
            PauseMenu.SetActive(true);
            hands.SetActive(false);
            book.transform.position = bookstartpos.transform.position;
            book.transform.rotation = bookstartpos.transform.rotation;
            Player.enabled = false;
            aslController.showASL = false;

            home = true;
        }
    }

        public void ResumeExperience()
    {
        if (pause == false)
        {
         //   Debug.Log("resume");
            king.enabled = true;
            if (speech.isPlaying == false)
            {
                speech.Play();
            }
            if (speech2.isPlaying == false)
            {
                speech2.Play();
            }
            if (speech3.isPlaying == false)
            {
                speech3.Play();
            }
            subtitles.SetActive(true);
            TeleportCamera.enabled = true;
            PauseMenu.SetActive(false);
            hands.SetActive(true);
            Player.enabled = true;
            home = false;
        }

    }
}
