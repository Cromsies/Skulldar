using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float speed = 5.0f;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rigidbody.AddForce(Vector3);
    }


}
