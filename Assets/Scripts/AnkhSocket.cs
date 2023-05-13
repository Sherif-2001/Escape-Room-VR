using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AnkhSocket : MonoBehaviour
{
    private XRSocketInteractor socket;
    public Animator treasureAnimator;
    bool isTreasureOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        IXRSelectInteractable object1 = socket.GetOldestInteractableSelected();

        if (object1 != null)
        {
            if (object1.transform.name == "Ankh")
            {
                if (!isTreasureOpen)
                {
                    treasureAnimator.SetTrigger("OpenTreasure");
                    isTreasureOpen = true;
                }
            }

        }
    }
}
