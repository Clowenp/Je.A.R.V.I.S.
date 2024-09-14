using UnityEngine;

public class AvatarController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();

        // Subscribing to mouse and window events
        MouseEventListener.OnMouseClick += HandleMouseClick;
        MouseEventListener.OnMouseHover += HandleMouseHover;
        MouseEventListener.OnMouseMove += HandleMouseMove;

        WindowEventListener.OnWindowFocusLost += HandleWindowFocusLost;
        WindowEventListener.OnWindowFocusGained += HandleWindowFocusGained;
    }

    void HandleMouseClick(Vector3 position)
    {
        // Trigger avatar animation for a mouse click
        animator.SetTrigger("ClickReaction");
    }

    void HandleMouseHover(Vector3 position)
    {
        // Trigger avatar animation for mouse hover
        animator.SetTrigger("HoverReaction");
    }

    void HandleMouseMove(Vector3 position)
    {
        // Trigger avatar animation for mouse move
        animator.SetTrigger("MoveReaction");
    }

    void HandleWindowFocusLost()
    {
        // Trigger avatar animation for losing focus
        animator.SetTrigger("FocusLost");
    }

    void HandleWindowFocusGained()
    {
        // Trigger avatar animation for gaining focus
        animator.SetTrigger("FocusGained");
    }

    void OnDestroy()
    {
        // Unsubscribing from events
        MouseEventListener.OnMouseClick -= HandleMouseClick;
        MouseEventListener.OnMouseHover -= HandleMouseHover;
        MouseEventListener.OnMouseMove -= HandleMouseMove;

        WindowEventListener.OnWindowFocusLost -= HandleWindowFocusLost;
        WindowEventListener.OnWindowFocusGained -= HandleWindowFocusGained;
    }
}
