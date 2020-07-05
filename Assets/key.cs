using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class key : MonoBehaviour
{
    public GameObject red;
    public GameObject blue;
    public GameObject green;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        red.gameObject.SetActive(true);
        blue.gameObject.SetActive(false);
        green.gameObject.SetActive(false);
        door.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("hit");

        if (collision.gameObject.tag == "red")
        { 
            blue.gameObject.SetActive(true);
        }

        if (collision.gameObject.tag == "blue")
        {
            green.gameObject.SetActive(true);
        }

        if (collision.gameObject.tag == "green")
        {
            door.gameObject.SetActive(true);
        }
        if (collision.gameObject.tag == "door")
        {
            SceneManager.LoadScene("battle");
        }
    }
}



    

