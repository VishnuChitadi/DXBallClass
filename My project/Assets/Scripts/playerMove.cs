using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D pad;
    private Vector2 position;
    public float displacement = 0.1f;
    public Animator animator;

    // Called once before the first frame update
    void Start()
    {
        pad = GetComponent<Rigidbody2D>();
        position = pad.transform.localPosition;
    }

    // Called once per frame
    void Update()
    {
        // Move right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetBool("isRunning",true);
            if (position.x <= 9.75f)
                position.x += displacement;
        }
        // Move left
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("isRunning", false);
            if (position.x >= -9.75f)
                position.x -= displacement;
        }

        pad.MovePosition(position);
    }
}

