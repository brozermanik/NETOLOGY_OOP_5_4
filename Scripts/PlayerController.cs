using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Netology_5_4;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootBullets());
        }
    }

    private IEnumerator ShootBullets()
    {
        yield return new WaitForSeconds(3f);
    }
}