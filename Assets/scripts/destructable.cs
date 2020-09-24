using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructable : MonoBehaviour
{
    public GameObject destroyedVersion;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(this.tag + " : " + (collision.gameObject.tag));
        if (collision.gameObject.tag == "Player" && this.tag == "Obstacle")
        {
            Instantiate(this.destroyedVersion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
