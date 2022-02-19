using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("�]�B�t��"), Range(0, 500)]
    public float speed = 1.5f;

    [Header("���D����"), Range(0, 5000)]
    public int jump = 500;

    [Tooltip("�x�s�}��O�_�b�Ʀ�")]
    public bool isSlide;

    [Tooltip("�x�s�}��O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "Ĳ�o�Ʀ�";
    public string parameterDead = "Ĳ�o���`";
}
