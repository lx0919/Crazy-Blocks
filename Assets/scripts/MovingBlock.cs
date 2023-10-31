using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{

    float startingYPosition;
    public static int score;
    public static int highScore;

    [SerializeField] float moveSpeed = 3f;

    void Start()
    {
        score = 0;
        startingYPosition = transform.position.y;
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;

        if (transform.position.x <= -15)
        {
            transform.position += Vector3.right * 30f;
            float newY = startingYPosition + UnityEngine.Random.Range(-1f, 1f);
            transform.position = new Vector3(transform.position.x, newY, 0f);
            score++;
            if (highScore < score)
            {
                highScore = score;
            }
        }
    }
}