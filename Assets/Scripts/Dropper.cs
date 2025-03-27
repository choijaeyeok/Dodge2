using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeTowait = 2f;

    MeshRenderer mymeshrenderer;
    Rigidbody myrigidbody; 
void Start()
    {
        mymeshrenderer = GetComponent<MeshRenderer>();
        mymeshrenderer.enabled = false;
        //enabled는 렌더링(보이는지) 여부를 조절하는 속성
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.useGravity = false;
        //useGravity는 중력 적용 여부" 를 조절하는 속성
    }

    void Update()
    {
       if(Time.time > timeTowait)
        {
            
            mymeshrenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
    }
}
