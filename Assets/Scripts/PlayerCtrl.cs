using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public CharacterController charCtrl;
    public int HP;

    // 初始化
    void Start()
    {
        HP = 100;
    }

    // 更新:偵測操作
    void Update()
    {
      
    }

    public void Move()
    {
        //角色控制器.移動(往前)
        charCtrl.SimpleMove(Vector3.forward);
    }
}
