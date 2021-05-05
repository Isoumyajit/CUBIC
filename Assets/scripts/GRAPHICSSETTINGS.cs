
using UnityEngine;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine.UI;

public class GRAPHICSSETTINGS : MonoBehaviour
{
    [SerializeField] Image _soundOnIcon;
    [SerializeField] Image _soundOffIcon;

    private bool muted = false;

    private void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
           
        }
        UpdateButtonPress();
        AudioListener.pause = muted;
    }
    public void setQuality(int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);
    }

    public void onButtonPress()
    {
        if (!muted)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonPress();
    }

    private void UpdateButtonPress()
    {
        if (!muted)
        {
            _soundOffIcon.enabled = false;
            _soundOnIcon.enabled = true;
        }
        else
        {
            _soundOnIcon.enabled = false;
            _soundOffIcon.enabled = true;
        }
    }

    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
