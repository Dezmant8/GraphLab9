using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addComp : MonoBehaviour
{
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "Platform")
        {
            if (!myCollision.gameObject.GetComponent<Rigidbody>())
            {
                myCollision.gameObject.AddComponent<Rigidbody>();
            }
        }
    }


}
