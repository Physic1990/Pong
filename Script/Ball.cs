using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 200f;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
       rigidbody=GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
       ResetPosition();
       AddStartingForce();
    }

    public void ResetPosition(){
        rigidbody.position = Vector3.zero;
        rigidbody.velocity = Vector3.zero;

        //AddStartingForce();
    }

    public void AddStartingForce()
    {
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1.0f : 1.0f;

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f)
                                      : Random.Range(0.5f, 1.0f);

        // Apply the initial force and set the current speed
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * this.speed);

    }

    public void AddForce(Vector2 force){
        rigidbody.AddForce(force);
    }

}