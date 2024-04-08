using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    
    [SerializeField] private GameObject food;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Destroy(other.gameObject);
        }
    }

    private void SpawnFruits()
    {
        bool fruitsSpawn = false;

        while (!fruitsSpawn)
        {
            Vector3 fruitPostion = new Vector3(Random.Range(-7f, 7f), Random.Range(-4f, 4f), 0f);
            if ((fruitPostion - transform.position).magnitude < 3)
            {
                continue;
            }
            else
            {
                Instantiate(food, fruitPostion, Quaternion.identity);
            }
        }
    }
}
