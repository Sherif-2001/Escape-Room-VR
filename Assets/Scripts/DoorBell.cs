using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraFading;
using UnityEngine.SceneManagement;

public class DoorBell : MonoBehaviour
{
    public string scene;
    private Vector3 originalScale;
    public AudioSource bellAudioSource;
    public AudioSource hitAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PressButton()
    {
        bellAudioSource.Play();
        transform.localScale = new Vector3(originalScale.x, originalScale.y / 2f, originalScale.z);
        Invoke("PlayerHit", 2f);
    }

    public void ReleaseButton()
    {
        transform.localScale = originalScale;
    }

    void PlayerHit()
    {
        hitAudioSource.Play();
        CameraFade.Out(1f);
        Invoke("GoToLevel",1f);
    }

    void GoToLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
