using UnityEngine;

public class WindowEventListener : MonoBehaviour
{
    public delegate void WindowEvent();
    public static event WindowEvent OnWindowFocusLost;
    public static event WindowEvent OnWindowFocusGained;

    private bool windowFocused = true;

    void Update()
    {
        if (Application.isFocused != windowFocused)
        {
            windowFocused = Application.isFocused;

            if (windowFocused)
            {
                OnWindowFocusGained?.Invoke();
            }
            else
            {
                OnWindowFocusLost?.Invoke();
            }
        }
    }
}
