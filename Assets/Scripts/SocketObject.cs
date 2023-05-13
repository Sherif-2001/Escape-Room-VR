using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketObject : MonoBehaviour
{

    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public XRSocketInteractor socket3;

    public Animator coffinAnimator;
    public AudioSource coffinAudio;

    bool isCoffinOpen = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        IXRSelectInteractable object1 = socket1.GetOldestInteractableSelected();
        IXRSelectInteractable object2 = socket2.GetOldestInteractableSelected();
        IXRSelectInteractable object3 = socket3.GetOldestInteractableSelected();

        if (object1 != null && object2 != null && object3 != null)
        {

            if (object1.transform.name == "Pyramid" && object2.transform.name == "MagicBox" && object3.transform.name == "Scarab")
            {
                if (!isCoffinOpen)
                {
                    coffinAnimator.SetTrigger("OpenCoffin");
                    coffinAudio.Play();
                    isCoffinOpen = true;
                }
            }
        }
    }

}
