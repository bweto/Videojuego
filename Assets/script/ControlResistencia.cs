using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlResistencia : MonoBehaviour
{
    public int resistencia;
    public AudioSource audioDestruirEnemigo;
    public ParticleSystem particleExplotions;
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
             StartCoroutine(ActivarParticulas(puntoImpacto));
     
        }
    }

     private void OnParticleCollision(GameObject other) {
        Debug.Log("Colision cubo");
        Destroy(transform.gameObject);
    }

    public IEnumerator ActivarParticulas(Vector3 puntoImpacto) {
        particleExplotions.transform.position = puntoImpacto;
        particleExplotions.Play();
        audioDestruirEnemigo.Play();
        yield return new WaitForSecondsRealtime(1.0f);
        particleExplotions.Stop();
        Destroy(transform.gameObject);
    }

}
