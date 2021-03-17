using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelay : MonoBehaviour
{
    Animator animator;
    public float delaySeconds;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(AnimationDelaying());
    }

    //Delays the animaiton
    IEnumerator AnimationDelaying()
    {
        while (true)
        {
            yield return new WaitForSeconds(delaySeconds);
            animator.SetTrigger("StartAnimation");
        }
    }
}
