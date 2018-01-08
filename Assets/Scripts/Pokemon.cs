using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon {

	private Dictionary<string, int> statistics;
	private Dictionary<string, int> attackList;

	public Pokemon() {
		this.initializeStatistics ();
		this.initializeAttackList ();
	}

	private void initializeStatistics() {
		this.statistics = new Dictionary<string, int> ();

	}

	private void initializeAttackList() {
		this.attackList = new Dictionary<string, int> ();
	}

}