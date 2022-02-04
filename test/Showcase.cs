using Kk.XLiteFilters;
using Leopotam.EcsLite;
using NUnit.Framework;

namespace xlitefilters.test
{
    public class Showcase
    {
        public struct A { }
        public struct B { }

        public struct C
        {
            public int value;
        }
        public struct D { }
        
        public class SimpleIterationCase: IEcsRunSystem
        {
            // injected as in classic
            private TypedFilter<A, B> _anb;

            public void Run(EcsSystems systems)
            {
                foreach (int entity in _anb)
                {
                    // as in ecs-classic
                    ref A a = ref _anb.Get1(entity);
                    ref B b = ref _anb.Get2(entity);
                }
            }
        }
        
        public class OptionalComponentsCase: IEcsRunSystem
        {
            private TypedFilter<A, B> _ab;

            // PoolSet is just a shorthand for several pool definitions
            // injected as in classic too
            private PoolSet<C, D> _cd;

            public void Run(EcsSystems systems)
            {
                // iterate over entities with A and B components
                foreach (int entity in _ab)
                {
                    // check if C component is also present and add it if not (positional access used as in ecs-classic)
                    if (!_cd.Has1(entity))
                    {
                        _cd.Add1(entity).value = 17;
                    }
                }
            }
        }
        
        public class CustomWorldCase: IEcsRunSystem
        {
            [WorldName("extraWorld")]
            private TypedFilter<A, B> _anb;
            [WorldName("extraWorld")]
            private PoolSet<C, D> _cnd;

            public void Run(EcsSystems systems)
            {
            }
        }

        [Test]
        public void Setup()
        {
            EcsSystems systems = new EcsSystems(new EcsWorld());
            systems.AddWorld(new EcsWorld(), "extraWorld");
            EcsSystems ecsSystems = systems
                .Add(new SimpleIterationCase())
                .Add(new OptionalComponentsCase())
                .Add(new CustomWorldCase())
                .InitXLiteFilters();
            ecsSystems.Init();
            ecsSystems.Run();
        }
    }
}