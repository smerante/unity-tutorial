using UnityEngine;

public class MouseListnerEvents : MonoBehaviour
{
    public MouseMevement playerMouseMovement;

    private void OnMouseEnter()
    {
        Debug.Log("Mouse Enter " + this.name);
    }

    private void OnMouseExit()
    {
        Debug.Log("Mouse Exit " + this.name);
    }

    private void OnMouseDown()
    {
        playerMouseMovement.mouseDown = true;
    }
    private void OnMouseUp()
    {
        playerMouseMovement.mouseDown = false;
    }
}
