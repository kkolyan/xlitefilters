using System.Runtime.CompilerServices;
using Leopotam.EcsLite;

namespace Kk.XLiteFilters
{
    public abstract class PoolSet
    {
        internal PoolSet() {}
    }
    
    public class PoolSet<T1> : PoolSet
            where T1 : struct
    {
        internal readonly EcsPool<T1> pool1;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2> : PoolSet
            where T1 : struct
            where T2 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
    }
    
    public class PoolSet<T1, T2, T3, T4> : PoolSet
            where T1 : struct
            where T2 : struct
            where T3 : struct
            where T4 : struct
    {
        internal readonly EcsPool<T1> pool1;
        internal readonly EcsPool<T2> pool2;
        internal readonly EcsPool<T3> pool3;
        internal readonly EcsPool<T4> pool4;

        public PoolSet(EcsWorld world)
        {
            pool1 = world.GetPool<T1>();
            pool2 = world.GetPool<T2>();
            pool3 = world.GetPool<T3>();
            pool4 = world.GetPool<T4>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Get1(int entity)
        {
            return ref pool1.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T1 Add1(int entity)
        {
            return ref pool1.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has1(int entity)
        {
            return pool1.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del1(int entity)
        {
            pool1.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Get2(int entity)
        {
            return ref pool2.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T2 Add2(int entity)
        {
            return ref pool2.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has2(int entity)
        {
            return pool2.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del2(int entity)
        {
            pool2.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Get3(int entity)
        {
            return ref pool3.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T3 Add3(int entity)
        {
            return ref pool3.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has3(int entity)
        {
            return pool3.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del3(int entity)
        {
            pool3.Del(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Get4(int entity)
        {
            return ref pool4.Get(entity);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T4 Add4(int entity)
        {
            return ref pool4.Add(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Has4(int entity)
        {
            return pool4.Has(entity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Del4(int entity)
        {
            pool4.Del(entity);
        }
        
    }
}