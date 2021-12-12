using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 1000;
    int currentHp;
    //Sliderを入れる
    public Slider slider;

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 1;
        //現在のHPを最大HPと同じに。
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    void Update() {
        //最大HPにおける現在のHPをSliderに反映。
        //int同士の割り算は小数点以下は0になるので、
        //(float)をつけてfloatの変数として振舞わせる。
        slider.value = (float)currentHp / (float)maxHp; ;
        Debug.Log("slider.value : " + slider.value);

    }



    public void kusaAttack()
    {
        //ダメージは1～100の中でランダムに決める。
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }

    public void denkiAttack()
    {
        //ダメージは1～100の中でランダムに決める。
        int damage = Random.Range(0,1000 );
        currentHp -= damage;
    }

    public void kusa2Attack()
    {
        //ダメージは1～100の中でランダムに決める。
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }

    public void denki2Attack()
    {
        //ダメージは1～100の中でランダムに決める。
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }
}
