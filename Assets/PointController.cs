using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    //得点を表示するテキスト
    private GameObject pointText;

    //得点を加算する
    private static int totalpoint;
    

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のPointTextオブジェクトを取得
        this.pointText = GameObject.Find("PointText");
  
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {
        if (tag == "SmallStarTag")
        {
            totalpoint += 10;
        }
        else if (tag == "LargeStarTag")
        {
            totalpoint += 20;
        }
        else if (tag == "SmallCloudTag")
        {
            totalpoint += 10;
        }
        else if (tag == "LargeCloudTag")
        {
            totalpoint += 20;
        }
       

        this.pointText.GetComponent<Text>().text = totalpoint + "point";

    }


}


