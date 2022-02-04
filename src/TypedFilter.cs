using Leopotam.EcsLite;

namespace Kk.XLiteFilters
{
    public abstract class TypedFilter
    {
        internal TypedFilter() {}
    }
    
    
    public sealed class TypedFilter<T1> : TypedFilter
            where T1 : struct
    {
        internal EcsFilter filter;
                
        internal readonly EcsPool<T1> pool1;

        public TypedFilter(EcsWorld world)
        {
            filter = world.Filter<T1>().End();
            pool1 = world.GetPool<T1>();
        }

        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        public EcsFilter.Enumerator GetEnumerator()
        {
            return filter.GetEnumerator();
        }
    }
    
    public sealed class TypedFilter<T1, T2> : TypedFilter
            where T1 : struct
            where T2 : struct
    {
        internal EcsFilter filter;
                
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;

        public TypedFilter(EcsWorld world)
        {
            filter = world.Filter<T1>().Inc<T2>().End();
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
        }

        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        public EcsFilter.Enumerator GetEnumerator()
        {
            return filter.GetEnumerator();
        }
    }
    
    public sealed class TypedFilter<T1, T2, T3> : TypedFilter
            where T1 : struct
            where T2 : struct
            where T3 : struct
    {
        internal EcsFilter filter;
                
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;

        public TypedFilter(EcsWorld world)
        {
            filter = world.Filter<T1>().Inc<T2>().Inc<T3>().End();
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
        }

        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        public EcsFilter.Enumerator GetEnumerator()
        {
            return filter.GetEnumerator();
        }
    }
    
    public sealed class TypedFilter<T1, T2, T3, T4> : TypedFilter
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
    {
        internal EcsFilter filter;
                
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;

        public TypedFilter(EcsWorld world)
        {
            filter = world.Filter<T1>().Inc<T2>().Inc<T3>().Inc<T4>().End();
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
        }

        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
        public EcsFilter.Enumerator GetEnumerator()
        {
            return filter.GetEnumerator();
        }
    }
}