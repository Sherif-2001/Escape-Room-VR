using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SafeButtons : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    private Vector3 originalScale;
    int increaseAmount = 1;
    int currentNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        numberText.text = currentNumber.ToString();
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseNumber()
    {
        if (currentNumber < 9)
            currentNumber += increaseAmount;

        else
            currentNumber = 0;

        numberText.text = currentNumber.ToString();
    }

    public void PressButton()
    {
        transform.localScale = new Vector3(originalScale.x, originalScale.y / 2f, originalScale.z);
        IncreaseNumber();
    }

    public void ReleaseButton()
    {
        transform.localScale = originalScale;
    }
}
