using Common.Wrappers; //Only if you use Biendeo's code wrappers
using System;
using UnityEngine;

namespace HighwayRaise
{
	public class Loader
	{
		public void LoadTweak()
		{
			WrapperBase.InitializeLoaders(); //Only if you use Biendeo's code wrappers
			if (this.gameObject != null)

			{
				return;
			}
			this.gameObject = new GameObject("Tweak - Template", new Type[]
			{
				typeof(TemplateTweak)
			});
			UnityEngine.Object.DontDestroyOnLoad(this.gameObject);
			this.gameObject.SetActive(true);
		}

		public void UnloadTweak()
		{
			if (this.gameObject != null)
			{
				UnityEngine.Object.DestroyImmediate(this.gameObject);
				this.gameObject = null;
			}
		}

		private GameObject gameObject;
	}
}
