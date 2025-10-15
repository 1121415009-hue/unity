using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public CharacterController charCtrl;
    public int HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = 100;
    }

    // Update is called once per frame
    void Update()
    {
        charCtrl.SimpleMove(Vector3.forward);
    }
}
