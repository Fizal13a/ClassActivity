using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class weapon
{
    public string name;
    public int firerate;
    public int ammo;
}

public class PlayerMovement : MonoBehaviour
{
    public weapon weapon;

    public int speed;
    public int score;
    public int health = 100;
    public int jumpforce;
    private Rigidbody2D rigidbody;
    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        rigidbody = GetComponent<Rigidbody2D>();
        scoreText.text = "Score - " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        
    }

    void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.gameObject.tag == "Coin")
        {
            score++;
            scoreText.text = "Score - " + score.ToString();
            Destroy(obj.gameObject);
        }
        else if(obj.gameObject.tag == "Spikes")
        {
            health--;

        }


    }

    void Jump()
    {
        rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpforce);

    }

    
}
