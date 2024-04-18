using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMotion : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.down * 0.4f * Time.deltaTime);
    }
}
