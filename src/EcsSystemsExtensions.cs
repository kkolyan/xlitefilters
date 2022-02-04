using System;
using System.Reflection;
using Leopotam.EcsLite;

namespace Kk.XLiteFilters
{
    public static class EcsSystemsExtensions
    {
        public static EcsSystems InitXLiteFilters(this EcsSystems systems)
        {
            IEcsSystem[] list = null;
            int count = systems.GetAllSystems(ref list);
            for (int i = 0; i < count; i++)
            {
                IEcsSystem system = list[i];
                InitSystem(systems, system);
            }

            return systems;
        }

        private static void InitSystem(EcsSystems systems, IEcsSystem system)
        {

            foreach (FieldInfo field in system.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
            {
                EcsWorld ResolveWorld()
                {
                    string worldName = field.GetCustomAttribute<WorldNameAttribute>()?.worldName;
                    EcsWorld ecsWorld = systems.GetWorld(worldName) 
                                        ?? throw new Exception($"world not defined: \"{worldName}\"");
                    return ecsWorld;
                }
                
                if (field.FieldType == typeof(EcsWorld))
                {
                    field.SetValue(system, ResolveWorld());
                }
                else if (typeof(TypedFilter).IsAssignableFrom(field.FieldType))
                {
                    field.SetValue(system, Activator.CreateInstance(field.FieldType, ResolveWorld()));
                }
                else if (typeof(PoolSet).IsAssignableFrom(field.FieldType))
                {
                    field.SetValue(system, Activator.CreateInstance(field.FieldType, ResolveWorld()));
                }
            }
        }
    }
}