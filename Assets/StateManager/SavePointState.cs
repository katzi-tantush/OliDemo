using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePointState : MonoBehaviour
{
    List<GameObject> visitedSavePoints;

    void Start()
    {
        visitedSavePoints = new List<GameObject>();
    }

    public void VisitSavePoint(GameObject savePoint)
    {
        bool unVisitedSavePoint = !visitedSavePoints.Contains(savePoint);
        if (unVisitedSavePoint)
        {
            visitedSavePoints.Add(savePoint);
            Debug.Log(visitedSavePoints.Count);
        }
    }
}
