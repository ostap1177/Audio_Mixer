using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundChanger : MonoBehaviour
{
    [SerializeField] private List<AudioMixerGroup> _mixersGroup = new List<AudioMixerGroup>();
    [SerializeField] private List<string> _mixersName = new List<string>();

    private float value = 20f;

    public void ChangeVoleme(float volume)
    {
        for (int i=0; i<_mixersGroup.Count;i++)
        {
            _mixersGroup[i].audioMixer.SetFloat(_mixersName[i], Mathf.Log10(volume) * value);
        }
    }
}
