using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 14f;
    private Rigidbody2D rb;
    private int puntuacionA = 0;
    private int puntuacionB = 0;
    //steel ball ruuuuuuuun
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
        if (transform.position.x > 10f)
        {
            puntuacionB++;
            Debug.Log(puntuacionA + " - " + puntuacionB);
            transform.position = Vector2.zero;
            Launch();
        }
        else if (transform.position.x < -10f)
        {
            puntuacionA++;
            Debug.Log(puntuacionA + " - " + puntuacionB);
            transform.position = Vector2.zero;
            Launch();
        }
    }

}
