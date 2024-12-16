using System.Collections;
using UnityEngine;

public class NukeChickens : MonoBehaviour
{
    public GameObject vfx_EasyExplosion;
    private IEnumerator OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Free Racing Car")
        {
            yield return new WaitForSeconds(0.75f);
            Instantiate(vfx_EasyExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}