using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SafeManager : MonoBehaviour
{
    private AudioSource audioSource;
    private Animator safeAnimator;
    public List<TextMeshProUGUI> numbers;
    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        safeAnimator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOpen)
        {
            if (numbers[0].text == "3" && numbers[1].text == "4" && numbers[2].text == "2" && numbers[3].text == "5")
            {
                audioSource.Play();
                safeAnimator.SetTrigger("Open");
                isOpen = true;
            }
        }
    }

}