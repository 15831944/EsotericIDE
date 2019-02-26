using System.Collections;
using System.Collections.Generic;


namespace EsotericIDE.Runic.runes {
	public class RuneReflectAll : IExecutableRune {
		public bool Execute(Pointer pointer, IRunicContext context) {
			pointer.direction = DirectionHelper.Reflect(pointer.direction);
			return true;
		}

		public IExecutableRune Register() {
			RuneRegistry.ALL_RUNES.Add('#', this);
			return this;
		}
	}
}