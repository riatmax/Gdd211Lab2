using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> balls;
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private TMP_Text counter;

    // Start is called before the first frame update
    void Start()
    {
        balls = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = $"Ball Count: {balls.Count}";
    }
    public void createBall()
    {
        GameObject currBall = Instantiate(ballPrefab, transform.position, Quaternion.identity);
        balls.Add(currBall);
    }
    public void deleteAll()
    {
        for (int i = 0; i < balls.Count; i++)
        {
            Destroy(balls[i]);
        }
        balls.Clear();
    }
    public void setRed(float amount)
    {
        for (int i = 0; i < balls.Count; i++)
        {
            float green = balls[i].GetComponent<Renderer>().material.color.g;
            float blue = balls[i].GetComponent<Renderer>().material.color.b;
            balls[i].GetComponent<Renderer>().material.color = new Color(amount / 255f, green, blue); 
        }
    }
    public void setGreen(float amount)
    {
        for (int i = 0; i < balls.Count; i++)
        {
            float red = balls[i].GetComponent<Renderer>().material.color.r;
            float blue = balls[i].GetComponent<Renderer>().material.color.b;
            balls[i].GetComponent<Renderer>().material.color = new Color(red, amount / 255, blue);
        }
    }
    public void setBlue(float amount)
    {
        for (int i = 0; i < balls.Count; i++)
        {
            float green = balls[i].GetComponent<Renderer>().material.color.g;
            float red = balls[i].GetComponent<Renderer>().material.color.r;
            balls[i].GetComponent<Renderer>().material.color = new Color(red, green, amount / 255);
        }
    }
}
