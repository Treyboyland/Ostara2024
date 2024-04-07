using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
#if UNITY_WEBGL || UNITY_ANDROID || UNITY_IOS
        //Do Nothing
#else
        if (Input.GetButtonDown("Screenshot"))
        {
            TakeScreenshot();
        }
#endif
    }

    public void TakeScreenshot()
    {
        string directory = Application.dataPath + "/../Logs/";
        string fileName = "Screenshot-" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-fff") + ".png";
        ScreenCapture.CaptureScreenshot(directory + fileName);
        Debug.LogWarning($"Screenshot saved to {directory + fileName}");
    }
}
