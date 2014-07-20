using System;

namespace Xamarin.Robotics.Mobile.Core.Bluetooth.LE
{
	public interface IDescriptor
	{
		object NativeDescriptor { get; }
		Guid ID { get; }
		string Name { get; }
	}
}

