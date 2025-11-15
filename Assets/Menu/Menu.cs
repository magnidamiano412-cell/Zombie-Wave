using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource audio;
    public Animator transition;

    public float transitionTime = 1f;

    void Start()
    {
        Cursor.visible = true;
    }


    public void PlayGame()
    {
        audio.Play();
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void QuitGame()
    {
        audio.Play();
        Application.Quit();
    }

    public void PlayButton()
    {
        audio.Play();
    }

    public void QuitButton()
    {
        audio.Play();
    }

    public void OpButton()
    {
        audio.Play();
    }

    public void Discord()
    {
        audio.Play();
        Application.OpenURL("https://discord.gg/JSYcn8qU");
    }

    public void Itch()
    {
        audio.Play();
        Application.OpenURL("https://gamebossking.itch.io/");
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
