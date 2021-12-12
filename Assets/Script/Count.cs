using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{

    public int number = 0;
    public Text powerText;
    public Text damageText;
    int total;
    public AudioSource audioSource;
    public AudioClip SE;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CountUp()
    {
        number = number + 1;
        powerText.text = number.ToString();
    }

    public void Attack()
    {
        total += number;
        damageText.text = total.ToString();
        audioSource.PlayOneShot(SE);
    }
}
