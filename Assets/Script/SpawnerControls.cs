using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControls : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float shootingtime = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 2f, shootingtime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnEnemy()
    {
        int enemyIndex = Random.Range(0, enemyPrefab.Length);
        //Transform pp = new Transform();
        //pp.position = new Vector3(0, 0, 0);
        //pp.rotation = Quaternion.identity;
        Vector3 pp = new Vector3(0, 1, 0); 
        Instantiate(enemyPrefab[enemyIndex], pp, Quaternion.identity);
    }
}
