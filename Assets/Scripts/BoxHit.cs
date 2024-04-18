using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoxHit : MonoBehaviour
{
    public string tag;
    public bool boxHit = false;
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == tag){
            boxHit = true;
        }
    }
}
