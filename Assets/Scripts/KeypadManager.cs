using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadManager : MonoBehaviour
{
    public Animator doorAnimator;
    public TextMeshProUGUI keypadNum;
    public int ButtonNum = 0;
    private Vector3 originalScale;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clearButton()
    {
        transform.localScale = new Vector3(originalScale.x, originalScale.y / 2f, originalScale.z);
        keypadNum.text = "";
    }

    public void enterButton()
    {
        transform.localScale = new Vector3(originalScale.x, originalScale.y / 2f, originalScale.z);
        if (keypadNum.text == "5297")
        {
            keypadNum.text = "Correct";
            doorAnimator.SetTrigger("OpenDoor");
        }
        else
        {
            keypadNum.text = "";
        }
    }

    public void PressButton()
    {
        transform.localScale = new Vector3(originalScale.x, originalScale.y / 2f, originalScale.z);
        if (keypadNum.text.Length < 4)
        {
            keypadNum.text += ButtonNum.ToString();
        }
    }

    public void ReleaseButton()
    {
        transform.localScale = originalScale;
    }

}
