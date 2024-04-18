using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyColors : MonoBehaviour
{
    List<string> Tags = new List<string>{"Yellow", "Red", "Blue", "Green", "Purple"};
    private void OnTriggerEnter(Collider other){
         if (Tags.Contains(other.gameObject.tag))
        {
            Destroy(other.gameObject);
        }
    }
}
