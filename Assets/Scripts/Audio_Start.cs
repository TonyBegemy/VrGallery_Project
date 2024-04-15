using UnityEngine;
using UnityEngine.UI;

public class PlayAudioOnClick : MonoBehaviour
{
    public AudioSource playButton; // Reference to the button
    public AudioClip audioclip; // Reference to the AudioClip component

    public void PlayAudio()
    {
        playButton.PlayOneShot(audioclip);
    }

}
