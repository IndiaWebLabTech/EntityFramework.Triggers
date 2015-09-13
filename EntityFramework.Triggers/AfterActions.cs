using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EntityFramework.Triggers {
	internal struct AfterActions {
		public List<Action<DbContext>> Static;
		public List<Action<DbContext>> Instance;
	}
}