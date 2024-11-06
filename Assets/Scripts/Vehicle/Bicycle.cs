using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bicycle : Vehicle
{

    public override void Move()
    {
        base.Move();
        //자전거만의 추가 동작
        transform.Rotate(0, 10, 0);

    }
    
    
        public override void Horn()
        {
            Debug.Log("자전거 경적 : 딩딩");
        }
   
}
