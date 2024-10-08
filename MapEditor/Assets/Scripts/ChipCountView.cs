using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChipCountView : MonoBehaviour
{
    public int Index { get; private set; } = 0;

    private Action<int> _getIndexAction = null;

    /// <summary>
    /// ボタン兜豚晒
    /// </summary>
    /// <param name="index">ボタンのインデックス</param>
    /// <param name="getIndexAction">ボタンを兀したときに柵び竃すコ�`ルバック</param>
    public void SetIndex(int index, Action<int> getIndexAction)
    {
        _getIndexAction = getIndexAction;
        Index = index;
    }

    /// <summary>
    /// ボタンを兀したらここが柵ばれる
    /// </summary>
    public void OnClickButton()
    {
        if (null != _getIndexAction)
        {
            _getIndexAction.Invoke(Index);

            Debug.Log("Index:"+Index);
        }



    }
}