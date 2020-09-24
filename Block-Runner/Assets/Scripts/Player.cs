using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceX = 5f;
    public float forceZ = 4000f;
    public GameManager gm;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey("a"))
        {
            rb.AddForce(-forceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(forceX * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            gm.EndGame();
        }
        
    }
}
