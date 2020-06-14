using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applause : MonoBehaviour {
    
    public GameObject AudienceMember;
    Animator m_animator;
    // Use this for initialization
    void Start () {
        m_animator = AudienceMember.GetComponent<Animator>();
        StartCoroutine(Response());
    }
	

    IEnumerator Response()
    {
        yield return new WaitForSeconds(207);
        m_animator.SetBool("Clap", true);
        yield return new WaitForSeconds(2);
        m_animator.SetBool("Clap", false);
        yield return new WaitForSeconds(24);
        m_animator.SetBool("Clap", true);
        yield return new WaitForSeconds(2);
        m_animator.SetBool("Clap", false);
        yield return new WaitForSeconds(71);
        m_animator.SetBool("Clap", true);
        yield return new WaitForSeconds(2);
        m_animator.SetBool("Clap", false);
    }

}
