using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Fungus;
using System.Diagnostics.Tracing;
using System;

public class VideoPlayerFadeOut : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Fungus.Flowchart flowchart;
    [SerializeField] string videoName;

    public void VideoFinished(VideoPlayer vp)
    {
        flowchart.ExecuteBlock("Fade Video Out");
    }

    public void DisablePlayer()
    {
        videoPlayer.gameObject.SetActive(false);
    }

    public void EnablePlayer()
    {
        videoPlayer.gameObject.SetActive(true);
    }

 ///   public void ClearVideo()
 ///   {
 ///       videoPlayer.enabled = false;
 ///       flowchart.SendMessage("VideoCleared");
  ///  }

    void Start()
    {
        videoPlayer = gameObject.GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += VideoFinished;

#if UNITY_WEBGL
        videoPlayer.source = VideoSource.Url;
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoName);
#endif
    }








}
