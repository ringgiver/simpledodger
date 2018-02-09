using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float lastSpawnTime;
    public float spawnInterval = 1.0f;
    public GameObject enemyPrefab;
    public float spawnRadius = 2.0f;
    public GameObject player;

    private void Update()
    {
        if (Time.time - lastSpawnTime > spawnInterval)
        {
            Spawn();
            lastSpawnTime = Time.time;
        }
    }
    private void Spawn()
    {
        var enemy = Instantiate(enemyPrefab);
        var theta = Random.Range(0, 2 * Mathf.PI);
        var spawnPos = spawnRadius * new Vector3(Mathf.Cos(theta), 0, Mathf.Sin(theta));
        enemy.transform.position = player.transform.position + spawnPos;


    }
}







































/*public class Spawner : MonoBehaviour
{
     public GameObject spherePreFab;
    public GameObject enemySpawnPoints ;

    public float sppawnRaidus = 2.0f; //스폰 반경
    public float spawnInterval = 1.5f; // 스폰 시간 간격(초)
    public float spawnTime = 1.5f;

    private float lastLogTime;


    private void Update()
    {
        var v1 = Mathf.Sin(Mathf.PI / 4);
        var v2 = Mathf.Cos(Mathf.PI / 4);
        var v3 = Random.Range(0, 2 * Mathf.PI);

        if (Time.time - lastLogTime > 1.5f) //현재시간 Time.time - 1.5초 이상 되쓸 때마다 hello를 찍는 것
            Debug.LogFormat("Hello {0}", Time.frameCount);
        lastLogTime = Time.time;
    }

    void spawn()
    {
       SpawnEnemy();
    }

    private void SpawnEnemy()
    {
       var enemy1= Instantiate(spherePreFab, transform);
       enemy1.transform.localPosition = new Vector3(0, 0, 0);
    }

}
*/


