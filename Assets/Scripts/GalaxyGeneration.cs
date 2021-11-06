using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalaxyGeneration : MonoBehaviour
{
    public GameObject Spawn;
    GameObject GalaxyCenter;

    public int TailsCount = 4;
    public static int TailsVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        TailsVector = 360 / TailsCount;
        GalaxyCenter = this.gameObject;
        Instantiate(Spawn, new Vector3(0, 15, 0), Quaternion.identity);
        StartCoroutine(TailRotate());
    }
    IEnumerator TailRotate()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
}
