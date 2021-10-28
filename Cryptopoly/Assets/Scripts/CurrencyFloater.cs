using UnityEngine;

public class CurrencyFloater : MonoBehaviour
{
    private float initY;
    private float initX;
    private Vector3 posOffset = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        initY = transform.position.y;
        initX = transform.position.x;
        posOffset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        initY+=(0.01f)*Mathf.Cos(Time.time);
        initX+=(0.01f)*Mathf.Sin(Time.time);

        posOffset.x = initX;
        posOffset.y = initY;
        transform.position = posOffset;
        transform.Rotate(new Vector3(0f, 0f,(0.01f)*Mathf.Cos(Time.time)), Space.Self);

    }
}
