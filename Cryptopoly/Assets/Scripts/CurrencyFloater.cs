using UnityEngine;

public class CurrencyFloater : MonoBehaviour
{
    private float initY;
    private float initX;
    // Start is called before the first frame update
    void Start()
    {
        float initY = transform.position.y;
        float initX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        initY+=5*Mathf.Sin(5*Time.deltaTime);
        initX+=5*Mathf.Sin(5*Time.deltaTime);
    }
}
