using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        Screen.fullScreen = !Screen.fullScreen;
/*#if NETFX_CORE && WINDOWS_UWP
            //Dispatch from Unity App thread to Windows UI Thread
            UnityEngine.WSA.Application.InvokeOnUIThread(() =>
            {
                var appView = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView();
                if (appView.IsFullScreen)
                    appView.ExitFullScreenMode();
                else
                    appView.TryEnterFullScreenMode();
            }, false);
#endif */
    }
}


