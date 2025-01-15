using System;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [ SerializeField ] private KeyCode shootingKey = KeyCode.E;
    [ SerializeField ] private Transform muzzle;
    
    private GameObject _objectToSpawn;

    private void Awake()
    {
        enabled = false;
    }

    private void Update()
    {
        if ( Input.GetKeyDown(shootingKey) )
        {
            GameObject go = Instantiate( _objectToSpawn, muzzle.position, Quaternion.identity );
        }
    }

    public void SetObjectToSpawn( GameObject go )
    {
        _objectToSpawn = go;
    }
}
