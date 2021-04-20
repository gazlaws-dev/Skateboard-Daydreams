using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public GameObject initialObjectPrefab;
    public GameObject hiddenObjectPrefab;
    public int xOffest, yOffset;
    public float startTimeBetweenSpawn;
    public Text hintCounterText;

    float timeBetweenSpawn;
    Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject hiddenObjectInstance;
        if (timeBetweenSpawn <= 0)
        {
            Instantiate(initialObjectPrefab, transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;
            offset = new Vector3(xOffest, yOffset);

            //Instead of random, use some "fair" feeling function
            if (Random.value <= .5)
            { 
                hiddenObjectInstance = Instantiate(hiddenObjectPrefab, transform.position + offset , Quaternion.identity);
                hiddenObjectInstance.GetComponent<ClickControl>().hintCounterText = hintCounterText;
            }

        } else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
