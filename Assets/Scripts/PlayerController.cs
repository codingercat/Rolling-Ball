using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    //public elements

    public float speed=0;
    public TextMeshProUGUI countText;
    
    public GameObject winTextObject;
    public GameObject loseTextObject;
    public GameObject plane;
    public GameObject Capsule;
    
    //audio sources

    public AudioSource gem;
    public AudioSource lost;
    public AudioSource win;

    //private elements

    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count=0;

        SetCountText();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
    }
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    public GameObject next;

    void SetCountText()
    {
        countText.text = "GEMS: " +count.ToString();
        if(count>=10)
        {
            Capsule.SetActive(false);
            winTextObject.SetActive(true);
            PlayWin();
            next.SetActive(true);
        }

    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);

    }

    public GameObject retry;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
         other.gameObject.SetActive(false); 
         count++; 
         PlayGem();    

         SetCountText();
        }
        if(other.gameObject.CompareTag("Capsule"))
        { 
            other.gameObject.SetActive(false);
            Destroy(plane,0.2f);
            loseTextObject.SetActive(true);
        }

        
        if(other.gameObject.CompareTag("Finish"))
        {
            loseTextObject.SetActive(true);
            PlayLost();
            retry.SetActive(true);  
            
        }
        


        
    }

    public void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void PlayGem(){
        gem.Play();
    }

    private void PlayLost(){
        lost.Play();
    }

    private void PlayWin(){
        win.Play();
    }
    

}
