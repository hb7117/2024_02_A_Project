using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{

    public Vehicle[] vehicles;          //Ż�� ��ü �迭 �����Ѵ�.

    public Car car;                 //�ڵ��� ����
    public Bicycle bicycle;         //������ ����

    float Timer;                //������ �ð� float ���� ����

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < vehicles.Length; i ++)  //�迭�� �ִ� Ż�͵��� �����δ�.
        {
            vehicles[i].Move();
        }
        car.Move();              //�̵� �Լ� ȣ��
        bicycle.Move();

        Timer -= Time.deltaTime;    //�ð��� ���δ�.

        if(Timer<0)         //1�ʸ��� ȣ��ǰ� �Ѵ�.
        {
            for (int i = 0;i < vehicles.Length;i --)
            {
                vehicles[i].Horn();
            }
          //car.Horn();     // ���� �Լ� ȣ��
          //bicycle.Horn();
          Timer = 1;
        }
    }
}
