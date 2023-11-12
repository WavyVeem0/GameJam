using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public GameObject player;
    public float ratio = 0.1f;
    public float fireRate = 2f;
    public GameObject bullet;
    public GameObject spawnPoint;
    public GameObject candle;

    private float maxTimer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        maxTimer = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (CandleScript.counter < 3){
            fireRate -= Time.deltaTime;
            Vector3 target = new Vector3(player.transform.position.x,gameObject.transform.position.y,0);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, target, ratio);
            
            if(fireRate <= 0) 
            {
                Instantiate(bullet, spawnPoint.transform.position, gameObject.transform.rotation);
                fireRate = maxTimer;
            }
        }
        else 
        {
            IsOver.isOver = true;
            gameObject.transform.rotation = new Quaternion(Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f),Random.Range(-10.0f, 10.0f),1);
        }

        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            IsOver.isOver = true;
            Destroy(other.gameObject);
        }
    }

        
}
