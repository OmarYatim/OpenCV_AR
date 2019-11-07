using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SocketIO;

public class Rotation : MonoBehaviour
{
    #region public params
    public int Rot;
    #endregion

    #region Singleton
    public static Rotation Instance;
    #endregion

    #region Static params
    static SocketIOComponent socket;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        socket = GetComponent<SocketIOComponent>();
        socket.On("open", OnConnected);
        socket.On("Register", OnRegister);
        socket.On("Angle_Received", Get_Angle);
    }

    // Update is called once per frame
    void Update()
    {
    }

    #region Private Methods
    private void OnConnected(SocketIOEvent obj)
    {
        Debug.Log("conected");
    }

    private void OnRegister(SocketIOEvent obj)
    {
        Debug.Log("client conected with id : " + obj.data["id"]);
    }

    private void Get_Angle(SocketIOEvent obj)
    {
        string Quotes = obj.data["angle"].ToString();
        Quotes = Quotes.Remove(0, 1);
        Quotes = Quotes.Remove(Quotes.Length - 3);
        Rot = - int.Parse(Quotes);
    }
    #endregion

}
