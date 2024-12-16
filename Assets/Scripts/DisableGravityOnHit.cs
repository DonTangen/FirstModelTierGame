using UnityEngine;

public class DisableGravityOnHit : MonoBehaviour
{

    public Rigidbody rb;
    public BoxCollider bc;

    // Update is called once per frame
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Free Racing Car")
        {
         //   rb.useGravity = false;
            rb.AddForce(Random.Range(-100, 100) * Time.deltaTime, 50 * Time.deltaTime, 25 * Time.deltaTime);
            bc.enabled = false;
        }

    }
}

