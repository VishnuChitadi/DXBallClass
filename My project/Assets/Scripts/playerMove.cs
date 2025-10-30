using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D pad;
    private Vector2 position;
    public float displacement = 0.1f;
    public Animator animator;
    private SoundManager soundManager;

    // Called once before the first frame update
    void Start()
    {
        pad = GetComponent<Rigidbody2D>();
        position = pad.transform.localPosition;

        // Find the SoundManager by tag ("music")
        soundManager = GameObject.FindGameObjectWithTag("music").GetComponent<SoundManager>();
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

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("ouchBrick")){
            Debug.Log("Stumble Sound");
            soundManager.PlaySFX(soundManager.stumbleSound);
        
        }
    }
}

