using Unity.VisualScripting;
using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    [SerializeField] float in1, in2;
    [SerializeField] float power, absolute, sign, rounded, ceiled, floored, min, max, sqrt;
    void OnValidate()
    {
        power = Mathf.Pow(in1, in2);
        absolute = Mathf.Abs(in1);
        sign = Mathf.Sign(in1); //-1, 1 , elõjeles
        rounded = Mathf.Round(in1);
        ceiled = Mathf.Ceil(in1);
        floored = Mathf.Floor(in1);
        min = Mathf.Min(in1, in2);
        max = Mathf.Max(in1, in2);
        sqrt = Mathf.Sqrt(in1);

    }

}
