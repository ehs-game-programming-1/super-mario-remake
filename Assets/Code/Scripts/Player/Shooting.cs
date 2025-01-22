using UnityEngine;

public class Shooting : MonoBehaviour
{
    [ SerializeField ] private KeyCode shootingKey = KeyCode.E;   
    [ SerializeField ] private GameObject muzzle;

    private GameObject _objectToSpawn;

    /*private void Awake()
    {
        enabled = false;
    }
    */

      void Start()
     {
         // Disattiva l'oggetto quando inizia la scena di gioco
         muzzle.gameObject.SetActive(false);
     }
   

    // se viene Mario collide con il fiore, il muzzle si crea
    private void OnTriggerEnter2D(Collider2D other)
    {

            muzzle.gameObject.SetActive(true);
        
    }

     private void Update()
        {
            // se cliccato il pulsante "e" si crea un muzzle con la setta posizione e rotazione di "hands"
            if (Input.GetKeyDown(shootingKey))
            {
                GameObject muzzleInstance = Instantiate(muzzle, transform.position, transform.rotation);

             // al muzzle viene applicato una forza verso destra
                muzzleInstance.GetComponent<Rigidbody2D>().AddForce(transform.right * 10, ForceMode2D.Impulse);         


            }
        }



   /*     public void SetObjectToSpawn(GameObject go)
        {
            _objectToSpawn = go;
        }
    */
} 
