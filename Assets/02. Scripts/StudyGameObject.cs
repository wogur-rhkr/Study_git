using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "���� ĳ����";
    }

}
