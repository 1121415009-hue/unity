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

    //初始化
    void Start()
    {
        HP = 100;
    }

    //更新:偵測動作
    void Update()
    {
     
    }

    public void Move(CallbackContext callback)
    {
        //角色控制器.移動(往前)
        charChrl.SimpleMove(Vector3.forward);
    }
}
