using UnityEngine;
using System.Collections;

public class MessageController : MonoBehaviour
{
    public Message messageScript;
    public string[] message;
    public string[] message2;// 表示させるメッセージ
    public string[] message3;// 表示させるメッセージ
    public string[] message4;// 表示させるメッセージ
    public string TagName;
    public string TagName2;// オブジェクトにつけるタグの名前
    public string TagName3;// オブジェクトにつけるタグの名前
    public string TagName4;// オブジェクトにつけるタグの名前

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == TagName)// もし、触れたもののタグがTagNameだったら、
        {
            StartCoroutine("Message",message);// Messageコルーチンを実行する
        }

        if (collision.gameObject.tag == TagName2)// もし、触れたもののタグがTagName2だったら、
        {
            StartCoroutine("Message", message2);// Messageコルーチンを実行する
        }

        if (collision.gameObject.tag == TagName3)// もし、触れたもののタグがTagName3だったら、
        {
            StartCoroutine("Message", message3);// Messageコルーチンを実行する
        }

        if (collision.gameObject.tag == TagName4)// もし、触れたもののタグがTagName4だったら、
        {
            StartCoroutine("Message", message4);// Messageコルーチンを実行する
        }
    }

    IEnumerator Message(string[] Conversation)// Messageコルーチン、引数を追加
    {
        yield return new WaitForSeconds(0.01f);
        messageScript.SetMessagePanel(Conversation);// messageScriptのSetMessagePanelを実行する
    }
}