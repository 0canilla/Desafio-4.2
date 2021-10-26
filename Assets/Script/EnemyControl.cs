using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public float speed = 1;
    public float tamaño = 2;
    public float Despawn = 15;
    public new Vector3 mov = new Vector3(1, 0, 0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += mov*speed;
        Despawn -= Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Scale();
        }
        if (Despawn <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Scale()
    {
        transform.localScale = new Vector3(1, 1, 1) * tamaño;
    }
}
