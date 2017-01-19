﻿using System;

namespace SmartDataViewerV1
{
	[Serializable]
	public class Model
	{
		public Model()
		{
			NickName = string.Empty;
		}

		[ConfigEditorField(99, true)]
		public int ID;

		[ConfigEditorField(98, true)]
		public string NickName;
	}
}
