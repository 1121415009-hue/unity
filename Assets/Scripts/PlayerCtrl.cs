using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerCtrl : MonoBehaviour
{
    public CharacterController charChrl;
    public int HP;

    //��l��
    void Start()
    {
        HP = 100;
    }

    //��s:�����ʧ@
    void Update()
    {
     
    }

    public void Move(CallbackContext callback)
    {
        //���ⱱ�.����(���e)
        charChrl.SimpleMove(Vector3.forward);
    }
}
