using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailNetBehaviour : MonoBehaviour
{
    public AudioSource Fail;
    public GameObject panelOver;
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            FindAnyObjectByType<Setting>().Fail.Play();
            panelOver.SetActive(true);
            print("Game Over !!!");
            Time.timeScale = 0.0f;
            FindAnyObjectByType<Setting>().hidesetting.enabled = false;
            FindAnyObjectByType<Setting>().replay.enabled = false;
            FindAnyObjectByType<LineManager>().linactive = false;
        }
    }
    public void Play()
    {
        panelOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        FindAnyObjectByType<Setting>().hidesetting.enabled = true;
        FindAnyObjectByType<Setting>().replay.enabled = true;
        FindAnyObjectByType<LineManager>().linactive = true;
    }

}
