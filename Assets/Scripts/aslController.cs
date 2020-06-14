using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class aslController : MonoBehaviour {


    //ASL
    [SerializeField] private GameObject aslVideoObj;
    private bool playasl;
    public VideoPlayer aslVideo;
    public MeshRenderer aslRenderer;
    public Material[] aslTexture;

    public bool showASL;


    public AudioSource audioSource;


    // Use this for initialization
    void Start ()
    {
        if (aslVideo == null)
        {
            aslVideo = GetComponent<VideoPlayer>();
        }

        if (aslRenderer == null)
        {
            aslRenderer = GetComponent<MeshRenderer>();
        }

        playasl = false;
        showASL = true;
    }

    private void showingASL()
    {
        if (OVRInput.GetUp(OVRInput.Button.Two) && audioSource.isPlaying == true || OVRInput.GetUp(OVRInput.Button.Start))
        {
            showASL = !showASL;
        }
    }

    private void viewASL()
    {
        if (showASL == true)
        { 
        aslRenderer.material = aslTexture[0];
        }

        else if (showASL == false)
        {
            aslRenderer.material = aslTexture[1];
        }
    }

    // Update is called once per frame
    void Update ()
    {
        playASL();
        vMLKasl();
        PausePlayback();
        ResumePlayback();
        viewASL();
        showingASL();
    }

    private void playASL()
    {
        if (audioSource.isPlaying == true && audioSource.time >= 1.4f)
        {
            playasl = true;
        }

        else if (audioSource.isPlaying == false)
        {
            playasl = false;
        }
    }
    private void vMLKasl()
    {
        if (playasl == true)
        {
            aslVideoObj.SetActive(true);

            if (aslVideo.isPlaying == false)
            {
                aslVideo.Play();
            }
        }
    }

    public void PausePlayback()
    {
        if (aslVideo.isPlaying == true && playasl == false)
        {
            aslVideo.Pause();
        }
    }

    public void ResumePlayback()
    {
        if (aslVideo.isPlaying == false && playasl == true)
        {
            aslVideo.Play();
        }
    }
}
