using UnityEngine;
using UnityEngine.Serialization;

public class Orbit : MonoBehaviour
{
    float XAngleValue;
    float YAngleValue;

    [SerializeField] private float xSpeed = 4;
    [SerializeField] private float ySpeed = 4;
    [SerializeField] private float xradius = 4;
    [SerializeField] private float yradius = 4;

    // Update is called once per frame
    void Update()
    {
        XAngleValue += Time.deltaTime * xSpeed;
        YAngleValue += Time.deltaTime * ySpeed;
        this.transform.position = new Vector3 (Mathf.Cos(XAngleValue) * xradius, this.transform.position.y, Mathf.Sin(YAngleValue) * yradius);
    }
}
