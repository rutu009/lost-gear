using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 燃料ゲージ : MonoBehaviour
{
    [SerializeField] float maxHp = 200f;
    Slider hpSlider;
    [SerializeField] float decreaseMove = 0.1f;
    [SerializeField] float decreaseJump = 0.5f;
    float nowHp;

    // Use this for initialization
    void Start ()
    {
        hpSlider = GetComponent<Slider>();

        nowHp = maxHp;

        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;
    }

    void Update()
    {
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            hpSlider.value -= decreaseMove;
            Debug.Log(nowHp);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            hpSlider.value -= decreaseJump;
            Debug.Log(nowHp);
        }
    }

    // Update is called once per frame

}
