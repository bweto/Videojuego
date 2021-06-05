using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.UI;
public class HeroController : MonoBehaviour
{   

    public float speedMove = 5.0f;
    public float speedRotate = 200.0f;
    private Animator animator;
    public float x, y;

    void Start(){
        animator = GetComponent<Animator>();

    }

    void Update(){
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * speedRotate, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speedMove);

        animator.SetFloat("SpeedX", x);
        animator.SetFloat("SpeedY", y);
    }

    /*private Rigidbody rb;
    public float speed;
    //public Transform particles;

    //public  GameObject cuboMovible;
    //private ParticleSystem systemParticle;

    private Vector3 position;
    private float contador;

    //public float enemigos;
    
    private Vector3 positionGreenCube; 
    //public GameObject greenCube;

    private AudioSource audioRecoleccion;
    private Animator animator;

    //public GameObject poder;

    //public ParticleSystem poderPiso;
    
    public IEnumerator DetenerParticulas(ParticleSystem part){

        yield return new WaitForSecondsRealtime(5);

        part.Stop();
    }

    public IEnumerator Movimiento(){
        while(true){
            if(Vector3.Distance(transform.position, cuboMovible.transform.position) < 6f ){
                cuboMovible.transform.position = Vector3.Lerp(cuboMovible.transform.position,
                new Vector3(Random.Range(-10.0f, 10.0f), 0.97f, Random.Range(-10.0f, 10.0f)),
                10f * Time.deltaTime);
            }
            yield return new WaitForSecondsRealtime(0.1f);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {   
        //("Movimiento");
        //contador = 0f;
        //audioRecoleccion = GetComponent<AudioSource>();
        //rb = GetComponent<Rigidbody>();
        //positionGreenCube = greenCube.transform.position;
        //textoContador.text = "Contador: " + contador.ToString();
        //systemParticle = particles.GetComponent<ParticleSystem>();
        //systemParticle2 = particles2.GetComponent<ParticleSystem>();
        //systemParticle3 = particles3.GetComponent<ParticleSystem>();
        //systemParticle4 = particles4.GetComponent<ParticleSystem>();
        //systemParticle.Stop();
        //animator = GetComponent<Animator>();

        //systemParticle2.Stop();
        //systemParticle3.Stop();
        //systemParticle4.Stop();
        //transform.Rotate(new Vector3 (45, 45, 45) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Animar();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            LanzarPoder();
        }
    }

    public void Animar() {
        // animator.SetBool("isSendingMagic",true);
        //StartCoroutine(Reiniciar());
    }

    public IEnumerator Reiniciar() {
        animator.SetBool("isSendingMagic",true);
        yield return new WaitForSecondsRealtime(1.0f);
        poder.transform.position = transform.position;
        poder.SendMessage("Shoot");
        animator.SetBool("isSendingMagic", false);
        // animator.SetBool("isSendingMagic",false);
    }

    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
        //Debug.Log(contador == enemigos ? "Temino el juego" : "faltan recolectables"); 

    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Recolectable")){
            contador += contador;
            audioRecoleccion.Play();
            position = transform.position;
            particles.position = position;
            other.gameObject.SetActive(false);
            contador ++;
             Debug.Log("cantidad de elementos: " + contador); 
            systemParticle.Play();
            StartCoroutine(DetenerParticulas(systemParticle));
            //SceneManager.LoadScene(1);
            return;
        };

        if(other.gameObject.CompareTag("yellow")){
            position = positionGreenCube;
            //particles2.position = position;
            //other.gameObject.SetActive(false);
            //position = 
            //contador ++;
             //Debug.Log("cantidad de elementos: " + contador); 
            //systemParticle2.Play();
            return;
        }

        if(other.gameObject.CompareTag("Blue")){
            position = other.gameObject.transform.position;
            //particles3.position = position;
            other.gameObject.SetActive(false);
            contador ++;
             Debug.Log("cantidad de elementos: " + contador); 
            //systemParticle3.Play();
            return;
        }

        if(other.gameObject.CompareTag("green")){
            position = other.gameObject.transform.position;
            //particles4.position = position;
            other.gameObject.SetActive(false);
            contador ++;
             Debug.Log("cantidad de elementos: " + contador); 
            //systemParticle4.Play();
            return;
        }

    }

    public void LanzarPoder() {
        StartCoroutine(LanzaPoderCoRoutine());
    }


    public IEnumerator LanzaPoderCoRoutine() {
        animator.SetBool("LanzandoPoder", true);
        yield return new WaitForSecondsRealtime(3.0f);
        animator.SetBool("LanzandoPoder", false);
        poderPiso.Play();
        StartCoroutine(DetenerPoder());
    }

    public IEnumerator DetenerPoder() {
        yield return new WaitForSecondsRealtime(1.5f);
        poderPiso.Stop();
    }*/
}
   
