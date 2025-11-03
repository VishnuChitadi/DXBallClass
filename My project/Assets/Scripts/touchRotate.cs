using UnityEngine;

public class touchRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.youWin) // youWin is a bool variable from another class
            transform.Rotate(0, 0, 90);
    }
}

