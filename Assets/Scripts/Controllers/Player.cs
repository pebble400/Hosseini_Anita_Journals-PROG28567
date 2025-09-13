using JetBrains.Annotations;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public int howManyBombs = 10;
    public List<Transform> asteroidTransforms;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffset(new Vector3(0, 1));
        }
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            numberOfBombs(1, howManyBombs, new Vector3(0, 1));
        }
    }

     public void SpawnBombAtOffset(Vector3 inOffset)
    {
        GameObject newBomb = Instantiate(bombPrefab, transform.position + inOffset, Quaternion.identity);


    }
    public void numberOfBombs(float bombSpacing, int innumberOfBombs, Vector3 inOffset)
    {
        for(int i = 0; i < innumberOfBombs; i++)
        {
            GameObject newBomb = Instantiate(bombPrefab);
            Vector3 spawnPosition = transform.position - inOffset - new Vector3(0, bombSpacing * i);
            newBomb.transform.position = spawnPosition;
        }
       
    }
}
