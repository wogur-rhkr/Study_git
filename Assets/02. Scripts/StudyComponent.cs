using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    //-------------------------
    public GameObject newObj;
    public Mesh msh;
    public Material mat;

    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Player");
        
        //objtf.gameObject == obj

        Debug.Log($"<color=#000000>�̸� : {obj.name}</color>");
        Debug.Log($"<color=#FF0000>�±� : {obj.tag}</color>");
        Debug.Log($"<color=#00FF00>��ġ : {obj.transform.position}</color>");
        Debug.Log($"<color=#0000FF>ȸ�� : {obj.transform.rotation}</color>");
        Debug.Log($"<color=#FFFFFF>ũ�� : {obj.transform.lossyScale}</color>");

        Debug.Log($"Mesh ������ : {obj.GetComponent<MeshFilter>().mesh}");
        Debug.Log($"Material ������ : {obj.GetComponent<MeshRenderer>().material}");

        obj.GetComponent<MeshRenderer>().enabled = false;

        //---------------------------------------------------------------------------------

        //CreateCube();

        newObj = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public void CreateCube()
    {
        newObj = new GameObject("Cube");

        newObj.AddComponent<MeshFilter>();
        newObj.GetComponent<MeshFilter>().mesh = msh;
        newObj.AddComponent<MeshRenderer>();
        newObj.GetComponent<MeshRenderer>().material = mat;
        newObj.AddComponent<BoxCollider>();
    }

}
