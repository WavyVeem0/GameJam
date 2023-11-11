using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float ShakeScale = 0.1f;
    private Vector3 startPosition;
    private void Awake()
    {
        startPosition = transform.position;
        StateOfShake(true);
    }

    public void StateOfShake(bool shaking)
    {
        if (shaking) StartCoroutine(Shaking());
        else StopAllCoroutines();
    }
    private IEnumerator Shaking()
    {
        for(; ; )
        {
            float x = Random.Range(0, ShakeScale);
            float y = Random.Range(0, ShakeScale);
            transform.position = new Vector3(startPosition.x + x, startPosition.y + y, startPosition.z);
            yield return new WaitForSeconds(0.05f);
        }
    }
}
