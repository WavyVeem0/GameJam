using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public GameObject player;
    public float ratio = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(player.transform.position.x,gameObject.transform.position.y,0);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, target, ratio);
    }
}
