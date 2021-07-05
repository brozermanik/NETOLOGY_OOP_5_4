using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ProjectileData;

public class PlayerController : MonoBehaviour
{
    public GameObject _projectile;
    private List<GameObject> _projectiles;

    private List<ProjectileData.BaseProjectile> firedProjectiles = new List<ProjectileData.BaseProjectile>();

    public void AddProjectile(BaseProjectile data)
    {
        firedProjectiles.Add(data);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(ShootBullets());
        }
    }

    private IEnumerator ShootBullets()
    {
        Instantiate(_projectile, transform.position, transform.rotation);
        yield return new WaitForSeconds(3f);
    }
    
    

    static ProjectileData.BaseProjectile CreateProjectile()
    {
        float tempDamage = ProjectileData.BaseProjectile.Damage;
        float tempSpeed = ProjectileData.BaseProjectile.ProjectileSpeed;
        float tempDuration = ProjectileData.BaseProjectile.Duration;
        ProjectileData.FireTheProjectile();
        return null;
    }
}