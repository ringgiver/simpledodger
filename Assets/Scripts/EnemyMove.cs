using UnityEngine;

public class EnemyMove : MonoBehaviour {
    
    public GameObject player;
    public float speed = 10f;

    private void Start()
    {
        player = GameObject.Find("Player"); 
    }
    private void Update () {
        // player.transform.position를 활용해서 dir을 계산
        Vector3 diff = player.transform.position - transform.position;
        var dir = diff.normalized; //거리와 상관없이 방향만 중요하게 만들어준다.
        transform.Translate(dir*speed*Time.deltaTime);

	}
}
