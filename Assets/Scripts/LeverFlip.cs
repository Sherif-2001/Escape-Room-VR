using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverFlip : MonoBehaviour
{
    public Animator animator;
    public bool isFlipped = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FlipLever()
    {
        isFlipped = !isFlipped;
        animator.SetBool("FlipLever", isFlipped);
    }
}
