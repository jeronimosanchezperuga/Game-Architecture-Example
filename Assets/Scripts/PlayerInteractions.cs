using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.name);
        if (col.gameObject.CompareTag("Enemy"))
        {
            SOEnemy enemy = col.gameObject.GetComponent<EnemyScript>().enemyData;
            Debug.Log("Enemigo: " + enemy.name);
            GetComponent<HealthManager>().ReduceHealth(enemy.hitPoints);
        }
    }

}
