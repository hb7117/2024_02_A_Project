using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��ü Ŭ���� : ������
public class Bicycle : Vehicle
{

    public override void Move()
    {
        base.Move();     //�⺻ �̵�
        //�����Ÿ��� �߰� ����
        transform.Rotate(0, 10, 0);

    }
    
    
        public override void Horn()
        {
            Debug.Log("������ ���� : ����");
        }
   
}
