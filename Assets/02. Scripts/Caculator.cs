using UnityEngine;

public class Caculator : MonoBehaviour
{
    public int num1, num2;

    void Start()
    {
        int addresult = AddMethod();

        int minusresult = MinusMethod();

        Debug.Log($"´õÇÑ°ª : {addresult}, »«°ª : {minusresult}");
    }

    int AddMethod()
    {
        int result = num1 + num2;
        return result;
    }
    int MinusMethod()
    {
        int result = num1 - num2;
        return result;
    }
}
