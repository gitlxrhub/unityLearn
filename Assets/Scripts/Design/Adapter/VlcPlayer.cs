using System;
using UnityEngine;

public class VlcPlayer : IAdvancedMediaPlayer
{
    public void PlayMusic(string fileName)
    {
        Debug.Log("PlayMusic");
    }

    public void PlayVideo(string fileName)
    {
        Debug.Log("PlayVideo");
    }
}
