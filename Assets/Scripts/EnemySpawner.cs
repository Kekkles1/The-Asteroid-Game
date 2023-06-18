using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;

    private GameObject enemyPrefab;

    public float spawnRate;
    // if i instantiate,i add to counter. if i destroy, i remove from counter
    public int spawnLimit;
    private int counter;

    private int rndx;
    private int rndy;
    private int rndEnemy;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        rndx = Random.Range(-23, 23);
        rndy = Random.Range(-1, 2);
        rndEnemy = Random.Range(1, 4);

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        counter = enemies.Length;

    }

    private void Spawn()
    {
        if (counter<=spawnLimit)
        {
            if (rndy <= 0)
            {
                rndy = -13;
            }
             rndy = 13;

            if (rndEnemy == 1)
            {
                enemyPrefab = enemyPrefab1;
            }
            else if (rndEnemy == 2)
            {
                enemyPrefab = enemyPrefab2;
            }
            else if (rndEnemy == 3)
            {
                enemyPrefab = enemyPrefab3;
            }
            else if (rndEnemy == 4)
            {
                enemyPrefab = enemyPrefab4;
            }

            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        }
        //Change();
        transform.position=new Vector3(rndx, rndy, transform.position.z);
    }
}
