using UnityEngine;
using UnityEngine.InputSystem;

public class PlatFormerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private Vector2 _boxOffset;
    [SerializeField] private Vector2 _boxSize;
    [SerializeField] private LayerMask _boxLayer;

    private Rigidbody2D rb2d;

    private float _movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.linearVelocityX = _movement;
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x * moveSpeed;
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.ReadValue<float>() == 1  || !IsGrounded())
        {
        rb2d.linearVelocityY = jumpHeight;
        }
    }

    private bool IsGrounded()
    {
        // Check for ground using a Boxcast.
        RaycastHit2D hit = Physics2D.BoxCast(transform.position + (Vector3) _boxOffset, _boxSize, 0, Vector2.zero,  0,  _boxLayer);
        Debug.Log(hit.collider.name);

        return hit;
    }

    private void OnDrawGizmos()
    {
        
    }
}
