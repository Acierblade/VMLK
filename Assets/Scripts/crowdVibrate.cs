using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crowdVibrate : MonoBehaviour
{

    public AudioSource audioSource;
    [SerializeField] private OculusHaptics LeftHaptics;
    [SerializeField] private OculusHaptics RightHaptics;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
         if (audioSource.time > 210.15f && audioSource.time < 218.17f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 235.72f && audioSource.time < 242.94f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 308.21f && audioSource.time < 317.23f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 339.57f && audioSource.time < 345.85f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 360.38f && audioSource.time < 368.78f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 407.80f && audioSource.time < 414.88f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 481.63f && audioSource.time < 486.50f)
        {
            LeftHaptics.Vibrate(VibrationForce.Medium);
            RightHaptics.Vibrate(VibrationForce.Medium);
        }

        else if (audioSource.time > 502.40f && audioSource.time < 513.11f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 573.76f && audioSource.time < 578.98f)
        {
            LeftHaptics.Vibrate(VibrationForce.Medium);
            RightHaptics.Vibrate(VibrationForce.Medium);
        }

        else if (audioSource.time > 647.69f && audioSource.time < 651.99f)
        {
            LeftHaptics.Vibrate(VibrationForce.Medium);
            RightHaptics.Vibrate(VibrationForce.Medium);
        }

        else if (audioSource.time > 678.29f && audioSource.time < 686.99f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 678.29f && audioSource.time < 686.99f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 753.35f && audioSource.time < 765.48f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 832.16f && audioSource.time < 844.94f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 832.16f && audioSource.time < 844.94f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 876.62f && audioSource.time < 887.03f)
        {
            LeftHaptics.Vibrate(VibrationForce.Hard);
            RightHaptics.Vibrate(VibrationForce.Hard);
        }

        else if (audioSource.time > 887.03f && audioSource.time < 892.19f)
        {
            LeftHaptics.Vibrate(VibrationForce.Light);
            RightHaptics.Vibrate(VibrationForce.Light);
        }
    }
}
