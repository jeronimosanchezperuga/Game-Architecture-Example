using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "Scriptables")]
public class SOEnemy : ScriptableObject
{
    public string name;
    public int hitPoints;
    public int healthPoints;
    public AudioClip attackSound;
    public AudioClip idleSound;
    public AudioClip hitSound;
    public AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
