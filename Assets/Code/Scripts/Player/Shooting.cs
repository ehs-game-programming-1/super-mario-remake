using UnityEngine;

public class Shooting : MonoBehaviour
{
    [ SerializeField ] private KeyCode shootingKey = KeyCode.E;
    [ SerializeField ] private Transform muzzle;
    
    private Bullet _bulletToSpawn;

    private void Awake() => enabled = false;

    private void Update()
    {
        if ( !_bulletToSpawn ) return;

        Vector2 _position = Vector2.right;
        var direction = Input.GetAxis( "Horizontal" );

        _position = direction > 0 ? Vector2.right : Vector2.left;
        _position.y = 1;
        
        muzzle.localPosition = _position;
        
        if ( Input.GetKeyDown(shootingKey) )
        {
            Bullet bullet = Instantiate( _bulletToSpawn, muzzle.position, Quaternion.identity );
            bullet.SetVelocity(_position);
        }
    }

    public void SetObjectToSpawn( Bullet go ) => _bulletToSpawn = go;
}
