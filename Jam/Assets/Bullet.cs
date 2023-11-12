using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject target;
    private Rigidbody2D rb;
    private float lifeTime = 1f;
    // Start is called before the first frame update
    void OnEnable() 
    {
        Debug.Log(1);
        target = GameObject.Find("PlayerPrefab");
        rb = gameObject.GetComponent<Rigidbody2D>();
        Vector3 forceVector = target.transform.position - gameObject.transform.position;
        rb.AddForce(forceVector);
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0) Destroy(gameObject);
    }
}
