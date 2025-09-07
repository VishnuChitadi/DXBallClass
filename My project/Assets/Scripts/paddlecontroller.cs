using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Rigidbody2D pad;
    Vector2 initial;
    public float displacement;

    // Start is called before the first frame update
    void Start()
    {
        pad = GetComponent<Rigidbody2D>();
        initial = pad.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (initial.x <= 9.75f)
                initial.x += displacement;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (initial.x > -9.75f)
                initial.x -= displacement;
        }

        pad.MovePosition(initial);
    }
}

