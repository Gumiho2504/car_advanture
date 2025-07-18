using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField] public AudioSource Soundbackground, completed, Fail;
    [SerializeField] private Slider Music;
    [SerializeField] private Slider Sfx;
    public GameObject setting;
    public Button hidesetting,replay;
    
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Sfxvolume"))
        {
            //PlayerPrefs.SetFloat("Sfxvolume", 1);
            //PlayerPrefs.SetFloat("musicvolumes", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    private void Load()
    {
        Music.value = PlayerPrefs.GetFloat("musicvolumes");
        Sfx.value = PlayerPrefs.GetFloat("Sfxvolume");
    }

    public void musicControl(float value)
    {
        Music.value += value;
        Soundbackground.volume = Music.value;
        Save();
    }

    public void sfxControl(float value)
    {
        Sfx.value += value;
        completed.volume = Sfx.value;
        Fail.volume = Sfx.value;
        SaveEffect();
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicvolumes", Music.value);

        PlayerPrefs.Save(); // Save the changes to PlayerPrefs
    }
    private void SaveEffect()
    {
        PlayerPrefs.SetFloat("Sfxvolume",Sfx.value);
    }
    public void Play()
    {
        replay.enabled = true;
        hidesetting.enabled = true;
        setting.SetActive(false);
        Time.timeScale = 1.0f;
        FindAnyObjectByType<LineManager>().linactive = true;
    }
    public void Settings()
    {
        replay.enabled = false;
        hidesetting.enabled = false;
        FindAnyObjectByType<LineManager>().linactive = false;
        Time.timeScale = 0f;
        setting.SetActive(true);
    }
    public void Home()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
}
