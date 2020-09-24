using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    Rigidbody rb;
    public float forceMult = 5f;
    // Start is called before the first frame update
    void Start()
    {
        forceMult += Time.timeSinceLevelLoad / 20f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 appliedForce = new Vector3(0, 0, -forceMult) * Time.deltaTime;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(appliedForce, ForceMode.VelocityChange);

        if (transform.position.z < -100f)
        {
            Destroy(gameObject);
        }

    }
}
