using System.Runtime.InteropServices;
using UnityEngine;

public class ShowAds : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = FindObjectOfType<AudioSource>();

        ShowAdv();
    }

    public void UnMuteAudio()
    {
        _audioSource.Play(0);
    }
}
