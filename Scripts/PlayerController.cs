using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyGame;

public class PlayerController : MonoBehaviour
{
    public List<GameObject> allMyProjectiles = new List<GameObject>();
    public bool isMyCoroutineStarted = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMyCoroutineStarted = true;
            if (isMyCoroutineStarted)
            {
                StartCoroutine("CreateBody");
            }
        }
        foreach (var ap in allMyProjectiles)
        {
            ap.transform.position += Vector3.forward * Time.deltaTime;
        }
    }

    public IEnumerator CreateBody()
    {
        GameObject bullet = GameObject. CreatePrimitive(PrimitiveType.Sphere);
        allMyProjectiles.Add(bullet);

        yield return isMyCoroutineStarted = false;
    }
}
