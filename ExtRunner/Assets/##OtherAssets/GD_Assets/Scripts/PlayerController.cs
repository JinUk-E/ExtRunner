using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpForce = 3f;
    public float JumpSpeed = 2f;
    [SerializeField] private bool isJumping = false;
    [SerializeField] private bool isTop = false;
    [SerializeField] private Vector2 startPos;
    private Animator playerAnimator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerAnimator.SetBool("IsMove", GD_GameManager.Instance.isPlaying);
        
        if(Input.GetMouseButton(0) && GD_GameManager.Instance.isPlaying) isJumping = true;
        if (isTop && isJumping && transform.position.y <= startPos.y +.1f)
        {
            isJumping = false;
            isTop = false;
        }
        
        if (!isJumping) return;
        if (transform.position.y <= JumpForce - 0.1f && !isTop)
        {
            transform.position =
                Vector2.Lerp(transform.position, 
                    new Vector2(transform.position.x, JumpForce),
                    JumpSpeed * Time.deltaTime);    
        }
        else
        {
            isTop = true;
        }
        
        if(isTop && transform.position.y > startPos.y)
        {
            transform.position =
                Vector2.Lerp(
                    transform.position, startPos, JumpSpeed * Time.deltaTime);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Mob"))
        {
            GD_GameManager.Instance.GameOver();
        }
    }
}
