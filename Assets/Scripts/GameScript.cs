using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class GameScript : MonoBehaviour {
    public GameObject Cross, Nought;
    public Text ins;
    public enum Seed { EMPTY, CROSS, NOUGHT };
    public Seed turn;
    public void Awake()
    {
        ins.text = "Turn: " + turn.ToString();
    }
    public void SpawnNew(GameObject obj)
    {
        if (turn == Seed.CROSS)
        {
            Instantiate(Cross, obj.transform.position, Quaternion.identity);
            turn = Seed.NOUGHT;
        }
        else
        {
            Instantiate(Nought, obj.transform.position, Quaternion.identity);
            turn = Seed.CROSS;
        }
        Destroy(obj.gameObject);
        ins.text = "Turn: " + turn.ToString();
    }
}
