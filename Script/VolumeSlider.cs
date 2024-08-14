using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("GameBGMusic"))
        {
            PlayerPrefs.SetFloat("GameBGMusic", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void ChangVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("GameBGMusic");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("GameBGMusic", volumeSlider.value);
    }
}
