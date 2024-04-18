using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;

public class DrumManager : MonoBehaviour
{
    private int drumNumber;
    public SpawnColors spawner;
    public float delay = 1.0f;
    public GameObject Drum1; 
    public GameObject Drum2; 
    public GameObject Drum3; 
    public GameObject Drum4;
    public GameObject Drum5;

    public GameObject yellowBox;
    public GameObject redBox;
    public GameObject blueBox;
    public GameObject greenBox;
    public GameObject purpleBox;

    private BoxHit yellow;
    private BoxHit green;
    private BoxHit red;
    private BoxHit blue;
    private BoxHit purple;

    private int drumHitScriptInstanceID1;
    private int drumHitScriptInstanceID2;
    private int drumHitScriptInstanceID3;
    private int drumHitScriptInstanceID4;
    private int drumHitScriptInstanceID5;


    private void Start()
    {
        DrumHit.OnDrumHit += HandleDrumHit;

        DrumHit drumHitComponent1 = Drum1.GetComponent<DrumHit>();
        drumHitScriptInstanceID1 = drumHitComponent1.GetInstanceID();
        
        DrumHit drumHitComponent2 = Drum2.GetComponent<DrumHit>();
        drumHitScriptInstanceID2 = drumHitComponent2.GetInstanceID();

        DrumHit drumHitComponent4 = Drum4.GetComponent<DrumHit>();
        drumHitScriptInstanceID4 = drumHitComponent4.GetInstanceID();

        DrumHit drumHitComponent5 = Drum5.GetComponent<DrumHit>();
        drumHitScriptInstanceID5 = drumHitComponent5.GetInstanceID();

        DrumHit drumHitComponent3 = Drum3.GetComponent<DrumHit>();
        drumHitScriptInstanceID3 = drumHitComponent3.GetInstanceID();

        yellow = yellowBox.GetComponent<BoxHit>();
        red = redBox.GetComponent<BoxHit>();
        green = greenBox.GetComponent<BoxHit>();
        blue = blueBox.GetComponent<BoxHit>();
        purple = purpleBox.GetComponent<BoxHit>();
    }

    private void OnDestroy()
    {
        DrumHit.OnDrumHit -= HandleDrumHit;
    }


    private void HandleDrumHit(int drumInstanceID)
    {
        if(drumInstanceID == drumHitScriptInstanceID1)
        {
            if (yellow.boxHit){
                Debug.Log("osui");
                yellow.boxHit = false;
            }
            else {
                Debug.Log("ei osunut");
            }
        }
        if(drumInstanceID == drumHitScriptInstanceID2)
        {
            if (red.boxHit){
                Debug.Log("osui");
                red.boxHit = false;
            }
            else {
                Debug.Log("ei osunut");
            }
        }
        if(drumInstanceID == drumHitScriptInstanceID3)
        {
             if (blue.boxHit){
                Debug.Log("osui");
                blue.boxHit = false;
            }
            else {
                Debug.Log("ei osunut");
            }
        }
        if(drumInstanceID == drumHitScriptInstanceID4)
        {
             if (green.boxHit){
                Debug.Log("osui");
                green.boxHit = false;
            }
            else {
                Debug.Log("ei osunut");
            }
        }
        if(drumInstanceID == drumHitScriptInstanceID5)
        {
            if (purple.boxHit){
                Debug.Log("osui");
                purple.boxHit = false;
            }
            else {
                Debug.Log("ei osunut");
            }
        }
    }
}