#region $name$
private MvxCommand _go$name$;
	public IMvxCommand Go$name$ {
		get {
			_go$name$ = _go$name$ ?? new MvxCommand (DoGo$name$);
			return _go$name$;
		}
	}

	public virtual void DoGo$name$ ()
	{
			// TODO do stuff here
	}
#endregion
