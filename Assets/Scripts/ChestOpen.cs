using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{

    private Animator chestAnimator;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        chestAnimator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OpenChest()
    {
        audioSource.Play();
        chestAnimator.SetTrigger("OpenChest");
    }
}
