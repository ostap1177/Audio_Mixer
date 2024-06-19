using UnityEngine;
using UnityEngine.Audio;

public class ButtonAllSound : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _audioMixerGroup;
    [SerializeField] private string _mixerName;

    private bool isClicked;
    private int _minValue = -80;
    private int _maxValue = 0;

    public void OnButtonTurnsOffAllMusic()
    {
        if (isClicked == false)
        {
            isClicked = true;
            _audioMixerGroup.audioMixer.SetFloat(_mixerName, _minValue);
        }
        else
        {
            isClicked = false;
            _audioMixerGroup.audioMixer.SetFloat(_mixerName, _maxValue);
        }
    }
}
