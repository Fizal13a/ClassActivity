using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovement : MonoBehaviour
{
    public int speed;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalinput * speed * Time.deltaTime);
    }







    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            score++;
            Destroy(collision.gameObject);

        }
    }

}
