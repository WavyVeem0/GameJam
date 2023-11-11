using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed;
    
    // Start is called before the first frame update
    private void Awake() {
        body = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");
        body.velocity = new Vector2(axisX * speed,axisY * speed);
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; 
        float rotateZ = Mathf.Atan2(diff.y,diff.x) * Mathf.Rad2Deg - 80; 
        transform.rotation=Quaternion.Euler(0f,0f,rotateZ);
    }
}
