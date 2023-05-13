using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeversManager : MonoBehaviour
{
    public List<LeverFlip> levers;
    public Animator doorAnimator;
    bool isDoorOpen = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isDoorOpen)
        {
            if (!levers[0].isFlipped && !levers[3].isFlipped)
            {
                if (levers[1].isFlipped && levers[2].isFlipped && levers[4].isFlipped)
                {
                    doorAnimator.SetTrigger("doorUp");
                    isDoorOpen = true;
                }
            }
        }
    }
}
