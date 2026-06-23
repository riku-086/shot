using UnityEngine;

public class target1 : MonoBehaviour
{
    public Camera targetCamera;
    public Vector3 minPosition = new Vector3(-10f, 2f, -10f);
    public Vector3 maxPosition = new Vector3(10f, 8f, 10f);
  
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out RaycastHit hit))
            {
                if(hit.transform==transform)
                {
                    Vector3 randompos = new Vector3(
                        Random.Range(-10f, 10f), Random.Range(2f, 8f), Random.Range(-10f, 10f));
                }
                targetCamera.transform.position = randompos; 
                }
            }
        }
    }
