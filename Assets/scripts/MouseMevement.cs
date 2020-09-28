using UnityEngine;



public class MouseMevement : MonoBehaviour
{
    public bool mouseDown;
    public float moveSpeed = 1;
    // Update is called once per frame
    void Update()
    {
        if (mouseDown)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.Log("2d Screen Mouse: " + Input.mousePosition.x + " " + Input.mousePosition.y);

            //Debug.Log("Player: " + this.transform.position.x + " " + this.transform.position.z);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                float x = this.transform.position.x - hit.point.x;
                float z = this.transform.position.z - hit.point.z;
                float c = Mathf.Sqrt(x * x + z * z);
                float angle = Mathf.Asin((z / c));
                float angleDeg = Mathf.Rad2Deg * angle;
                //Debug.Log("Distance: " + c + " : Angle: " + angle + "degrees: " + angleDeg + " : " + x + " : " + z);


                Vector3 forceVector = new Vector3(-x, 0f, -z) * (this.moveSpeed / 100);
                GetComponent<Rigidbody>().AddForce(forceVector, ForceMode.VelocityChange);
            }
        }
    }
}
