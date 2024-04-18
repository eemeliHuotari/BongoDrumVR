using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnColors : MonoBehaviour
{
    public GameObject blue;
    public GameObject red;
    public GameObject yellow;
    public GameObject purple;
    public GameObject green;
    private int randomNumber;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(SpawnColor());
    }

    IEnumerator SpawnColor() 
    {
        while(true){
        randomNumber = Random.Range(1, 6);

        if (randomNumber == 1)
        {
            Instantiate(yellow);
        }

         if (randomNumber == 2)
        {
            Instantiate(red);
        }

        if (randomNumber == 3)
        {
            Instantiate(blue);
        }

        if (randomNumber == 4){
            Instantiate(green);
        }
        if (randomNumber == 5){
            Instantiate(purple);
        }
        yield return new WaitForSeconds(2f);
        }
    }
}
