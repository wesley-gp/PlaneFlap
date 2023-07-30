using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    //variaveis
    private Rigidbody2D meuRB;
    [SerializeField] private float speed;
    void Start()
    {
      meuRB = GetComponent<Rigidbody2D>();  
    }

    
    void Update()
    {
        movimento();
    }
    private void movimento()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            meuRB.velocity = Vector2.up * speed;

        } 
        if (meuRB.velocity.y<-speed)
        {
            meuRB.velocity = Vector2.down * speed;
        } 

    }
    private void OnTriggerEnter2D(Collider2D other) {
        SceneManager.LoadScene("Jogo");
    }
}
