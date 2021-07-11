using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ProjectileData;

public class PlayerController : MonoBehaviour
{
    public GameObject _projectile;
    private List<GameObject> _projectiles;
    private List<ProjectileData.BaseProjectile> firedProjectiles = new List<ProjectileData.BaseProjectile>();

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootBullets());
        }
    }

    private IEnumerator ShootBullets()
    {
        //GameObject shootProjectile = Instantiate(_projectile, transform.position, transform.rotation);
        GameObject shootProjectile = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        shootProjectile.AddComponent<Rigidbody>().AddRelativeForce(30,0,0);
        transform.position += transform.forward * 30 * Time.deltaTime;
        yield return new WaitForSeconds(3f);
    }
}