using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("跑步速度"), Range(0, 500)]
    public float speed = 1.5f;

    [Header("跳躍高度"), Range(0, 5000)]
    public int jump = 500;

    [Tooltip("儲存腳色是否在滑行")]
    public bool isSlide;

    [Tooltip("儲存腳色是否死亡")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterSlide = "觸發滑行";
    public string parameterDead = "觸發死亡";
}
