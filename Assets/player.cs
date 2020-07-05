using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public Text text;
    public int number;
    public Text damage;
    public int total;
    public Text hidame;
    public int hhidame;

    // Start is called before the first frame update
    void Start()
    {
        number = 0;
        hhidame = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void CountUp()
    {

        number = number + 1;
        text.text = number.ToString();
        hhidame = hhidame + 1;
        hidame.text = hhidame.ToString();
        if (hhidame >= 3)
        {
            SceneManager.LoadScene("gameover");
        }


    }
    public void Attack()
    {
        total += number;
        damage.text = total.ToString();

    }
}