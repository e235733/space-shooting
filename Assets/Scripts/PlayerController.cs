using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Vector2 padding = new Vector2(0.2f, 0.2f);
    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private GameControls controls;

    private Vector2 minBounds;
    private Vector2 maxBounds;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        controls = new GameControls();
        controls.Player.Move.Enable();

        InitBounds();
    }

    void OnEnable()
    {
        controls.Player.Enable();
    }

    void OnDisable()
    {
        controls.Player.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = controls.Player.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed;

        Vector2 clampedPos = rb.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, minBounds.x, maxBounds.x);
        clampedPos.y = Mathf.Clamp(clampedPos.y, minBounds.y, maxBounds.y);
        rb.position = clampedPos;
    }

    void InitBounds()
    {
        Camera mainCamera = Camera.main;
        Vector2 min = mainCamera.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = mainCamera.ViewportToWorldPoint(new Vector2(1, 1));

        minBounds = min + padding;
        maxBounds = max - padding;
    }
}
