using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string myLevel;
    void OnCollisionEnter(Collision myCollision)
    {
        if (myCollision.gameObject.name == "floor")
        {
            Application.LoadLevel(myLevel);
        }
    }


}
