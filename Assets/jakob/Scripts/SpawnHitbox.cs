using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlatFormerMovement))]
public class SpawnHitbox : MonoBehaviour
{
    public float attackRadius = 1.5f;
    public LayerMask attackLayer;
    public PlatFormerMovement Pm;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(InputAction.CallbackContext ctx)
    {
        RaycastHit2D hit = Physics2D.CircleCast(transform.position + new Vector3(Pm.movement, 0, 0), attackRadius, Vector2.zero, 0, attackLayer);

        if (hit)
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
}
