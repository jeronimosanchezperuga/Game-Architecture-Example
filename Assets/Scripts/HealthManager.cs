using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] int health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        ReduceHealth(damage);
        //reproducir sonido
        //efecto visual de daño
        //animación correspondiente
    }

    public void ReduceHealth(int damage)
    {
        health-=damage;
        if(health < 0) 
        { 
            //death
            health = 0; 
        }
    }
}
