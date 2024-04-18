using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DrumHit : MonoBehaviour
{
    public float hitDelay = 0.4f;
    public static bool hit = false;
    public static event Action<int> OnDrumHit;
    public GameObject rainEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (!hit && other.gameObject.tag == "StickHead")
        {
            Instantiate(rainEffect, transform.position, transform.rotation);
            OnDrumHit?.Invoke(GetInstanceID());
            hit = true;
            Invoke("Event", hitDelay);
        }
    }
    void Event()
    {
        hit = false; 
    }
}
