using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Planform_controller : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    [SerializeField]
    GameObject platform;
    public Vector2 startPos; 


    public void OnBeginDrag(PointerEventData eventData)
    {
        startPos = Camera.main.ScreenToWorldPoint(eventData.position);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 temp = Camera.main.ScreenToWorldPoint(eventData.position);
        float offset = Mathf.Abs(startPos.x - temp.x);
        Vector3 plpos = platform.transform.position;
        MovePlatform(temp, offset, plpos);
        CheckBorder(plpos);
    }

    //Двигаем платформу проверяя не вышли ли за границы
    public void MovePlatform(Vector2 _temp, float _offset, Vector3 _plpos)
    {
        if(_plpos.x >= -1.7f & _plpos.x <= 1.7f)
        {
            if (startPos.x > _temp.x)
            {
                platform.transform.position -= new Vector3(_offset,0,0);
            }
            if (startPos.x < _temp.x)
            {
                platform.transform.position += new Vector3(_offset,0,0);
            }
            startPos = _temp;
        } 
    }

    //если вышли за границы то возвращаем обратно платформу
    public void CheckBorder(Vector3 _plpos)
    {
        if(_plpos.x < -1.7f)
        {
            platform.transform.position = new Vector3(-1.69f, platform.transform.position.y, 0);
        }
        if(_plpos.x > 1.7f)
        {
            platform.transform.position = new Vector3(1.69f, platform.transform.position.y, 0);
        }
    } 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
