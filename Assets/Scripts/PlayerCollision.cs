using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public PlayerHp playerHp;
    public Text hpText;
    public GameObject impact;
    public GameObject player;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        //이름으로구분
        //if(other.gameObject.name == "Enemy(Clone)") { 
        //if (other.GetComponent<EnemyMove>()) { 2번째 방법
        //if(other.GetComponent<EnemyMove>()) {
        //태그로 구분
        //if(other.tag == "Enemy"){ 3번째 방법 태그나 레이어 사용하기

        //  hpText.text = hp.ToString();
        playerHp.hp--;
        hpText.text = playerHp.hp.ToString();

        Destroy(other.gameObject);
        var  effect =   Instantiate(impact);
        effect.transform.position = player.transform.position;
               
        audioSource.Play();
       
    }



}
