using UnityEngine;

public class IntervalTest : MonoBehaviour {
    private float lastLogTime;
        private void Update()
    {
        var v1 = Mathf.Sin(Mathf.PI / 4);
        var v2 = Mathf.Cos(Mathf.PI / 4);
        var v3 = Random.Range(0, 2 * Mathf.PI);

        if(Time.time- lastLogTime > 1.5f) //현재시간 Time.time - 1.5초 이상 되쓸 때마다 hello를 찍는 것
        Debug.LogFormat("Hello {0}", Time.frameCount);
        lastLogTime = Time.time;
    }
}
