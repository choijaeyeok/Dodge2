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
        //enabled�� ������(���̴���) ���θ� �����ϴ� �Ӽ�
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.useGravity = false;
        //useGravity�� �߷� ���� ����" �� �����ϴ� �Ӽ�
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
