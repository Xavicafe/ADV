using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject gm;

    public float speed= 10.0f; 
    
    void OnCollisionStay(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            GameObject gam =Instantiate(gm, collision.contacts[0].point, Quaternion.identity);
            Debug.Log(collision.gameObject.transform.position);
            Debug.Log("Toca");
        }
    }

    private void Update() {

         Rigidbody rb = GetComponent<Rigidbody>();
         if (Input.GetKey(KeyCode.A))
             rb.AddForce(Vector3.left);
         if (Input.GetKey(KeyCode.D))
             rb.AddForce(Vector3.right);
         if (Input.GetKey(KeyCode.W))
             rb.AddForce(Vector3.up);
         if (Input.GetKey(KeyCode.S))
             rb.AddForce(Vector3.down);
 
     }
}
