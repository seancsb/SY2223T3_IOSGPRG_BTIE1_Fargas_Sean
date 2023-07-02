using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject[] objects;
    [SerializeField] float secondSpawn;
    [SerializeField] float minXPos;
    [SerializeField] float maxXPos;
    [SerializeField] float minYPos;
    [SerializeField] float maxYPos;

    int repeat;

    private void Start()
    {
        StartCoroutine(ObjectSpawn());
        //ObjectSpawn();
    }

    IEnumerator ObjectSpawn()
    {
        while (repeat != 20)
        {
            var xPos = Random.Range(minXPos, maxXPos);
            var yPos = Random.Range(minYPos, maxYPos);
            var position = new Vector3(xPos, yPos);
            GameObject gameObject = Instantiate(objects[Random.Range(0, objects.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            //Destroy(gameObject, 5f);
            repeat++;
        }
    }

    //void Update()
    //{
    //    if (repeat != 15)
    //    {
    //        ObjectSpawn();
    //    }
    //}

    //void ObjectSpawn()
    //{
    //    var xPos = Random.Range(minXPos, maxXPos);
    //    var yPos = Random.Range(minYPos, maxYPos);
    //    var position = new Vector3(xPos, yPos);
    //    GameObject gameObject = Instantiate(objects[Random.Range(0, objects.Length)], position, Quaternion.identity);
    //    Destroy(gameObject, 5f);
    //    repeat++;
    //}
}
