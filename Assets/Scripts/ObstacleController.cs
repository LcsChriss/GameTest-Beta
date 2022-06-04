using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    private Rigidbody2D ObsRB;

    private GameController _GameController;

    // Start is called before the first frame update
    void Start()
    {
        ObsRB = GetComponent<Rigidbody2D>();
        //ObsRB.velocity = new Vector2(-5f, 0f);

        _GameController = FindObjectOfType(typeof(GameController)) as GameController;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveObject();
    }

    void MoveObject()
    {
        transform.Translate(Vector2.left * _GameController._ObsVelocit * Time.smoothDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player")
        {
            Debug.Log("KKKK TOCOU NO OBS NOOB");
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
        Debug.Log("E a pedra morreu");
    }

}
