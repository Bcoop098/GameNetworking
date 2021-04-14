using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public PlayerInput owner;
    Rigidbody m_Rigidbody;
    [SerializeField]
    float timeUntilDeath = 5.0f;
    public int id;
    public int bulletPlayerIndex;
    public bool hasHitShield;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeUntilDeath = timeUntilDeath - Time.deltaTime;
        if (timeUntilDeath <= 0.0f)
        {

            Destroy(gameObject);
        }
    }
}
