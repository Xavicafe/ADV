using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palatia : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(DelaySound());
    }


    IEnumerator DelaySound()
    {
        yield return new WaitForSeconds(10f);
        animator.SetTrigger("levantarse");
    }
}
