using UnityEngine;
using System.Collections;

public static class GrassCellFill {
	public static ArrayList positionList = new ArrayList();
	
	public static void addPosition(Vector3 p) {
		positionList.Add(p);
	}
	
	public static ArrayList getPostionList() {
		return positionList;
	}
	
	public static void rem(Vector3 p) {
		positionList.Remove(p);
	}
}
