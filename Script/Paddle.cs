using UnityEngine;

public class Paddle : MonoBehaviour{
    public float speed = 10.0f;

    protected Rigidbody2D rigidbody;

    private void Awake(){
        rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition(){
        rigidbody.position=new Vector2(rigidbody.position.x,0.0f);
        rigidbody.velocity = Vector3.zero;
    }
}