using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _health;
    [SerializeField] private float maxHealth;
    public GameObject deathEffect; // Save for later when enemy get death animation.
    [SerializeField] private float moveSpeed;
    private Rigidbody2D _rb;
    private Transform _target;
    private Vector2 _moveDirection;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _health = maxHealth;
        _target = GameObject.Find("Player").transform;
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Die();
        }
    }

    private void Update()
    {
        if (!_target)
        {
            return;
        }
        Vector3 direction = (_target.position - transform.position).normalized;
        float angleCalculation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _rb.rotation = angleCalculation;
        _moveDirection = direction;
    }

    private void FixedUpdate()
    {
        if (_target)
        {
            _rb.velocity = new Vector2(_moveDirection.x, _moveDirection.y) * moveSpeed;
        }
    }

    private void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
