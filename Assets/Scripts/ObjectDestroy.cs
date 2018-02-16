using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 0.1f);
    }
}
