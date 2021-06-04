using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlResistencia : MonoBehaviour
{
    public int resistencia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RegistrarImpacto(Vector3 puntoImpacto) {
        resistencia--;
        if (resistencia <= 0)
        {
            Destroy(transform.gameObject);
        }
    }

     private void OnParticleCollision(GameObject other) {
        Debug.Log("Colision cubo");
        Destroy(transform.gameObject);
    }

}
