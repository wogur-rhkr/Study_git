using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;

    public string changename;

    void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changename;
    }
}
