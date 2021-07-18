using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalScript : MonoBehaviour
{
    //GoalText?I?u?W?F?N?g??????????????????
    public Text goalText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) // (Collider collision)を(Collision collision)に
    {
        //?????A?????????Q?[???I?u?W?F?N?g???^?O??Player????????
        if(collision.gameObject.tag == "Player")
        {
            //GoalText???\??????
            goalText.gameObject.SetActive(true);
        }
    }

    /*ーーーーーーーーー修正機能１「衝突判定が上手く取れていない」ーーーーーーーーーーーーーーー
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    OnCollisionEnterは物体同士がぶつかった時に呼ばれる
    Coliderコンポーネント内のisTriggerにチェックは外す
    反発させるためには、判定したいオブジェクトにRigidBodyコンポーネントを追加して置く必要がある
    ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー*/
}
