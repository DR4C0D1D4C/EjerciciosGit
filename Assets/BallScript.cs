using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 12f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    void Launch()
    {
        float x = Random.value < 0.4f ? -1 : 1;
        float y = Random.Range(-0.5f, 0.5f);

        Vector2 dir = new Vector2(x, y).normalized;
        rb.linearVelocity = dir * speed;
    }

    void Update()
    {
        if (Mathf.Abs(transform.position.x) > 10f)
        {
            transform.position = Vector2.zero;
            Launch();
        }
    }

}
