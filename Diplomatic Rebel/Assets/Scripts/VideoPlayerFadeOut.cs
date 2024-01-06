using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;
using Fungus;

public class VideoPlayerFadeOut : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public Fungus.Flowchart flowchart;

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
    }








}
