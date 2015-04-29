this.DelayBind(() =>
{
	var set = this.CreateBindingSet<$view$, $vm$>();
	// TODO put bindings here
  // set.Bind(SomeView).For(s => s.DataContext).To(vm => vm.SomeViewModel);
	set.Apply();
});
