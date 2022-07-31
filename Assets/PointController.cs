using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    //���_��\������e�L�X�g
    private GameObject pointText;

    //���_�����Z����
    private static int totalpoint;
    

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������PointText�I�u�W�F�N�g���擾
        this.pointText = GameObject.Find("PointText");
  
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //�Փˎ��ɌĂ΂��֐�
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


