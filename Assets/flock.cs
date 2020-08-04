using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flock : MonoBehaviour
{
    public float speed = 10f;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        speed = GetSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        Swim();
    }

    void Swim()
    {
        transform.Translate(direction * Time.deltaTime * speed, 0, 0);
    }

    void Turn()
    {
        direction = -direction;

        // Multiply the player's x local scale by -1
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
        speed = GetSpeed();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        Turn();
    }

    float GetSpeed()
    {
        return Random.Range(10, 20);
    }
}
