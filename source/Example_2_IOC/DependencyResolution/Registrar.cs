using StructureMap;

namespace Example_2_IOC.DependencyResolution
{
	public class Registrar
	{
		static bool _dependenciesRegistered;

		public static void EnsureDependenciesRegistered()
		{
			if (!_dependenciesRegistered)
				ConfigureStructureMap();
		}

		static void ConfigureStructureMap()
		{
			ObjectFactory.Initialize(x => x.AddRegistry<ExampleRegistry>());

			ObjectFactory.AssertConfigurationIsValid();

			_dependenciesRegistered = true;
		}
	}
}