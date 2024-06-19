using UnityEngine;

public class ButtonPlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    public void OnButtonSoundClick()
    { 
        _audioSource.Play();
    }
}
