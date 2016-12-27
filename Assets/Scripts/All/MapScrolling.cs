using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapScrolling : MonoBehaviour
{
    //Script for spawning and moving chunks right/left
    public float speed;
    private float tempFloat;
    private float startPosX;
    private int Turn;

    [SerializeField]
    private Vector2 endPoint;

    [SerializeField]
    private Vector2 startPoint;

    //All the different chunks
    private GameObject chunk1;
    private GameObject chunk2;
    private GameObject chunk3;
    private GameObject chunk4;
    private List<GameObject> chunks;

    void Start()
    {
        //tempFloat = 0;
        startPosX = transform.position.x;
        //Get the prefab chunks from resource folder
        chunk1 = Resources.Load<GameObject>("Chunk1");
        chunk2 = Resources.Load<GameObject>("Chunk2");
        chunk3 = Resources.Load<GameObject>("Chunk3");
        chunk4 = Resources.Load<GameObject>("Chunk4");

        chunks = new List<GameObject>();

        //add chunks into a list
        chunks.Add(chunk1);
        chunks.Add(chunk2);
        chunks.Add(chunk3);
        chunks.Add(chunk4);
    }

    void Update()
    {
        Destroy();
        MoveDown();
    }

    //Moving the chunks left
    private void MoveDown()
    {
        tempFloat += (Time.deltaTime * speed);
        this.transform.position = new Vector2(startPosX - tempFloat, transform.position.y);
    }

    //Spawnig new / deleting the old chunks 
    private void Destroy()
    {
        if (transform.position.x < endPoint.x)
        {
            Destroy(this.gameObject);
            SpawnNew();
        }
    }

    //Spawn new randomized chunks
    private void SpawnNew()
    {
        Turn = Random.Range(0,4);
        Instantiate(chunks[Turn], startPoint, chunks[Turn].transform.rotation);
    }
}