using System;
using Unity.Mathematics;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [ SerializeField ] private Transform muzzle;
    [ SerializeField ] private Direction bulletDirection;
    [ SerializeField ] private Bullet bulletToSpawn;

    [ SerializeField ] private float fireRate = 2f;
    private float _currentTime = 0f;

    private void Update()
    {
        _currentTime += Time.deltaTime;

        if ( _currentTime >= fireRate )
        {
            Bullet bullet = Instantiate( bulletToSpawn, muzzle.position, quaternion.identity );

            Vector3 direction = ( bulletDirection ) switch
            {
                Direction.Left => Vector3.left,
                Direction.Right => Vector3.right,
            };

            muzzle.localPosition = direction;
            
            bullet.SetVelocity(direction);

            _currentTime = 0f;
        }
    }

    private enum Direction { Left, Right }
}
