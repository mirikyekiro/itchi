using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class video1 : MonoBehaviour
{
    VideoPlayer _videoPlayer;

    void Start()
    {
        _videoPlayer = GetComponent<VideoPlayer>();
        _videoPlayer.Prepare();

        _videoPlayer.loopPointReached += _videoPlayer_loopPointReached;

        Invoke("play", 3);
    }

    private void _videoPlayer_loopPointReached(VideoPlayer source)
    {

        SceneManager.LoadScene(3);
    }

    private void play()
    {
        _videoPlayer.Play();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        { SceneManager.LoadScene(2); }

    }
}
