using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static List<ProjectileData.BasicProjectile> allMyProjectiles = new List<ProjectileData.BasicProjectile>();
    ProjectileData.BasicProjectile shot = new ProjectileData.BasicProjectile();
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            allMyProjectiles.Add(shot);
            foreach (var i in allMyProjectiles)
            {
                GameObject shots = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere), transform.position, transform.rotation);
                shots.transform.position += Vector3.forward * Time.deltaTime * 5;
            }
        }
        
    }
}
