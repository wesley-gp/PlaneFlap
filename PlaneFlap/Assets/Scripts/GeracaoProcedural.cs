using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeracaoProcedural : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    [SerializeField] private GameObject obstaculo;
    // Start is called before the first frame update
    [SerializeField] private Vector3 posicao;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0)
        {
            posicao.y=Random.Range(minY,maxY);
            Instantiate(obstaculo,posicao,Quaternion.identity);
            timer=Random.Range(1f,3f);
        } 
        
    }
}
