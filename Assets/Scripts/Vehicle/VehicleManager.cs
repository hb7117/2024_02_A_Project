using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleManager : MonoBehaviour
{

    public Vehicle[] vehicles;          //탈것 객체 배열 선언한다.

    public Car car;
    public Bicycle bicycle;

    float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for(int i = 0; i < vehicles.Length; i ++)
        {
            vehicles[i].Move();
        }
        car.Move();
        bicycle.Move();

        Timer -= Time.deltaTime;

        if(Timer<0)         //1초마다 호출되게 한다 
        {
            car.Horn();     // 경적 함수 호출
            bicycle.Horn();
            Timer = 1;
        }
    }
}
