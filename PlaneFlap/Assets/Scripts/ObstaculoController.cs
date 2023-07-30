using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaculoController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject obstaculo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left* Time.deltaTime* speed;
        Deletar();
    }
    void Deletar()
    {
        if(transform.position.x<-11)
        {
            Destroy(obstaculo);
        }
    }
}
