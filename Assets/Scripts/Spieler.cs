using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spieler : MonoBehaviour
{
    public GameObject ziegelPrefab;
    public GameObject ball;
    Rigidbody2D ballRB;
    bool ballUnterwegs = false;
    void Start()
    {
        for (int x = 1; x <= 10; x++)
        {
            for (int i = 1; i <= 5; i++)
            {
                Instantiate(ziegelPrefab, new Vector3(x * 1.2f - 6.6f, i * 0.75f - 0.25f, 0), Quaternion.identity);
            }
        }
        ballRB = ball.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xEingabe = Input.GetAxis("Horizontal");
        float yEingabe = Input.GetAxis("Vertical");
        if(!ballUnterwegs && yEingabe > 0)
        {
            ballRB.AddForce(new Vector2(300, 200));
            ballUnterwegs = true;
        }

    }
}
