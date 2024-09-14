using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEventListener : MonoBehaviour
{
    public delegate void MouseEvent(Vector3 position);
    public static event MouseEvent OnMouseClick;
    public static event MouseEvent OnMouseHover;
    public static event MouseEvent OnMouseMove;

    void Update()
    {
        // Mouse click detection
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            OnMouseClick?.Invoke(Input.mousePosition);
        }

        // Mouse hover detection (Raycast from screen to objects)
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            OnMouseHover?.Invoke(Input.mousePosition);
        }

        // Mouse move detection
        if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
        {
            OnMouseMove?.Invoke(Input.mousePosition);
        }
    }
}
