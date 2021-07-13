using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehaviour : MonoBehaviour
{
    public float rotationalSpeed = 20;

    public GameObject treePrefab;

    void Start()
    {
        int trees = Random.Range(50, 100);

        for(int i = 0; i < trees; i++)
        {
            Vector3 spawnPosition = Random.onUnitSphere * (5);
            Quaternion spawnRotation = Quaternion.identity;
            GameObject newTree = Instantiate(treePrefab, spawnPosition, spawnRotation) as GameObject;
            Vector3 gravityUp = (newTree.transform.position - transform.position).normalized;
            Vector3 localUp = newTree.transform.up;

            newTree.transform.rotation = Quaternion.FromToRotation(localUp, gravityUp) * newTree.transform.rotation;
            newTree.transform.parent = this.gameObject.transform;
        }

    }


    void Update()
    {
        this.transform.Rotate(0, rotationalSpeed * Time.deltaTime, 0);
    }
}
