        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float zbound = 31.0f;
    private float xbound = 30.0f;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zbound || transform.position.z > zbound)
        {
            Destroy(gameObject);
            if (transform.position.z < -zbound) { gameManager.AddLives(-1); }
        }

        if (transform.position.x < -xbound || transform.position.x > xbound)
        {
            Destroy(gameObject);
        }
    }

}
