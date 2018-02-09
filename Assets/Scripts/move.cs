//Simple Dodger 권준혁 2018.2.5
using UnityEngine;

public class move : MonoBehaviour {

    public float speed = 5;
    // public DirPad dirPad;
    public float movedPosition;
    void Update ()
    {
       /* if (dirPad.dragging)
        {
            var dn = dirPad.dir.normalized * Time.deltaTime; //단위 S벡터 변환
            transform.Translate(new Vector3(dn.x, 0, dn.y));
        }
       else */
        {
            var dx = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            var dz = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(new Vector3(dx, 0, dz));
        }

        //Vector3 movedPostiion = transform.position;
        //if (movedPosition.x < -50.0f)
        //{
        //    movedPosition.x = -50.0f;
        //}
        //if (movedPostiion.x > +50.0f)
        //{
        //    movedPosition.x = +50.0f;
        //} //z에서도 처리 필요
        //movedPosition.z = Mathf.Clamp(movedPosition.z, -50, +50);
        
        //transform.position = movedPosition;
    }

   // private void OnTriggerEnter(Collider other)
   // private void OnTriggerExit(Collider other)


            
}
