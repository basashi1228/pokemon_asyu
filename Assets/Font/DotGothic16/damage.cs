using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 1000;
    int currentHp;
    //Slider������
    public Slider slider;

    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 1;
        //���݂�HP���ő�HP�Ɠ����ɁB
        currentHp = maxHp;
        Debug.Log("Start currentHp : " + currentHp);
    }

    void Update() {
        //�ő�HP�ɂ����錻�݂�HP��Slider�ɔ��f�B
        //int���m�̊���Z�͏����_�ȉ���0�ɂȂ�̂ŁA
        //(float)������float�̕ϐ��Ƃ��ĐU���킹��B
        slider.value = (float)currentHp / (float)maxHp; ;
        Debug.Log("slider.value : " + slider.value);

    }



    public void kusaAttack()
    {
        //�_���[�W��1�`100�̒��Ń����_���Ɍ��߂�B
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }

    public void denkiAttack()
    {
        //�_���[�W��1�`100�̒��Ń����_���Ɍ��߂�B
        int damage = Random.Range(0,1000 );
        currentHp -= damage;
    }

    public void kusa2Attack()
    {
        //�_���[�W��1�`100�̒��Ń����_���Ɍ��߂�B
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }

    public void denki2Attack()
    {
        //�_���[�W��1�`100�̒��Ń����_���Ɍ��߂�B
        int damage = Random.Range(25, 50);
        currentHp -= damage;
    }
}
